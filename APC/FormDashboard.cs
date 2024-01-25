using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.AllForms;
using APC.BLL;
using APC.DAL.DTO;
using FontAwesome.Sharp;

namespace APC
{
    public partial class FormDashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        FormManagement managementForm;
        public FormDashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(245, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color normal = Color.MidnightBlue;
        }
        // Button Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.PaleTurquoise;
                currentBtn.IconColor = Color.PaleTurquoise; ;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        // Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Dashboard";
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only a form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }

        private void picBoxMin_Click(object sender, EventArgs e)
        {

        }
        MemberBLL memberBLL = new MemberBLL();
        CommentBLL commentBLL = new CommentBLL();
        ChildBLL childBLL = new ChildBLL();
        GeneralAttendanceBLL generalAttendanceBLL = new GeneralAttendanceBLL();
        PersonalAttendanceBLL personalAttendanceBLL = new PersonalAttendanceBLL();
        EventsBLL eventBLL = new EventsBLL();
        FormProperties initialDetail = new FormProperties();
        public bool isAdmin = false;
        public bool isEditor = false;
        private void FormDashboard_Load(object sender, EventArgs e)
        {

            MemberDTO memberDTO = memberBLL.Select();
            MemberDetailDTO detail = memberDTO.Members.First(x => x.MemberID == LoginInfo.MemberID);
            string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
            picProfilePic.ImageLocation = imagePath;
            labelNameSurname.Text = detail.Name + " " + detail.Surname;
            labelAccessLevel.Text = detail.PermissionName;

            if (!isAdmin && !isEditor)
            {
                tableLayoutPanelRealCards.Hide();
                btnAttendance.Hide();
                btnChildren.Hide();
                btnFinancialReport.Hide();
                btnExpenditure.Hide();
                btnEvents.Hide();
                btnDeadMembers.Hide();
                btnDocuments.Hide();
                btnManage.Hide();
                btnMembers.Text = "    Profile";
                btnMembers.Location = new Point(0, 118);

                CommentDTO dto = commentBLL.Select();
                int commentCount = dto.Comments.Count(x => x.MemberID == LoginInfo.MemberID);
                if (commentCount < 1)
                {
                    btnComments.Hide();
                }
                else if (commentCount == 1)
                {
                    btnComments.Visible = true;
                    btnComments.Text = "    Comment";
                }
                else
                {
                    btnComments.Visible = true;
                }
            }

            initialDetail.StartPosition = FormStartPosition.Manual;
            initialDetail.Location = this.Location;
            initialDetail.Size = this.Size;
            initialDetail.WindowState = this.WindowState;

            this.ControlBox = false;
            if (WindowState == FormWindowState.Normal)
            {
                RefreshAllCards(171, 42);
            }
            else
            {
                RefreshAllCards(350, 42);
            }
        }

        private void RefreshAllCards(int x, int y)
        {
            General.ValueCount(labelNoOfRegMem, memberBLL.SelectAllMembersCount(), x, y);
            General.ValueCount(labelTotalComments, commentBLL.SelectAllCommentsCount(), x, y);
            General.ValueCount(labelMonthlyComments, commentBLL.SelectMonthlyCommentsCount(), x, y);
            General.ValueCount(labelNoOfChildren, childBLL.SelectAllChildren(), x, y);
            General.ValueCount(labelLastMeetingAttendance, personalAttendanceBLL.SelectLastMeetingAttendance(DateTime.Now.Month, DateTime.Now.Year), x, y);            
            labelLastEventDate.Text = eventBLL.SelectRecentEvent();

            string monthToday = DateTime.Now.ToString("MMMM");
            string yearToday = DateTime.Now.Year.ToString();
            if (Convert.ToInt32(labelMonthlyComments.Text) > 1)
            {
                labelComment.Text = "comments";
            }
            else
            {
                labelComment.Text = "comment";
            }
            int todayMonth = DateTime.Now.Month;
            int todayYear = DateTime.Today.Year;
            labelCommentMonthName.Text = monthToday;
            labelDuesMonthName.Text = monthToday;
            labelMonthlyDuesYearName.Text = yearToday;
            labelTotalDuesYear.Text = yearToday;
            General.ValueCountInDecimal(labelMonthlyDues, generalAttendanceBLL.SelectMonthlyDues(todayMonth), x-50, y);            
            General.ValueCountInDecimal(labelYearlyDues, generalAttendanceBLL.SelectYearlyDues(todayYear), x-50, y);            
        }

        private void iconClose_MouseEnter(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.Orange;
        }

        private void iconClose_MouseHover(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.Orange;
        }

        private void iconClose_MouseLeave(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.DarkOrange;
        }
        private void picBoxMin_Click_1(object sender, EventArgs e)
        {

        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_MouseEnter(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.Orange;
        }

        private void iconMaximize_MouseHover(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.Orange;
        }

        private void iconMaximize_MouseLeave(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.DarkOrange;
        }

        private void iconMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.StartPosition = initialDetail.StartPosition;
                this.Location = initialDetail.Location;
                this.Size = initialDetail.Size;
                this.WindowState = initialDetail.WindowState;
            }
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.Orange;
        }

        private void iconMinimize_MouseHover(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.Orange;
        }

        private void iconMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.DarkOrange;
        }
        private bool buttonWasClicked = false;
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            if (buttonWasClicked)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void btnMembers_Click_1(object sender, EventArgs e)
        {            
            int memberCount = memberBLL.SelectAllMembersCount();
            if (memberCount > 0)
            {
                if (!isAdmin && !isEditor)
                {
                    MemberDTO dto = memberBLL.Select();
                    MemberDetailDTO detail = dto.Members.First(x => x.MemberID == LoginInfo.MemberID);
                    FormViewMember open = new FormViewMember();
                    open.detail = detail;
                    open.isView = true;
                    this.Hide();
                    open.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    buttonWasClicked = true;
                    ActivateButton(sender, RBGColors.color2);
                    OpenChildForm(new FormMembersList());
                }

            }
        }

        private void btnChildren_Click_1(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormChildrenList());
        }

        private void btnFinancialReport_Click_1(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormFinancialReportList());
        }
        FormProperties formDetail = new FormProperties();
        private void btnManage_Click_1(object sender, EventArgs e)
        {
            managementForm = new FormManagement();
            managementForm.StartPosition = FormStartPosition.Manual;
            managementForm.Location = this.Location;
            managementForm.Size = this.Size;
            managementForm.WindowState = this.WindowState;

            formDetail.StartPosition = FormStartPosition.Manual;
            formDetail.Location = this.Location;
            formDetail.Size = this.Size;
            formDetail.WindowState = this.WindowState;
            managementForm.formDetail = formDetail;

            if (WindowState == FormWindowState.Normal)
            {
                RefreshAllCards(171, 42);
            }
            else
            {
                RefreshAllCards(350, 42);
            }
            this.Hide();
            managementForm.ShowDialog();
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            if (buttonWasClicked)
            {
                currentChildForm.Close();
                Reset();                
            }
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin open = new FormLogin();
            this.Hide();
            open.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRegMembers_Click(object sender, EventArgs e)
        {
            btnMembers.PerformClick();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormGeneralAttendanceList());
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormEventsList());
        }

        private void btnExpenditure_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormExpenditureList());
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            int memberCount = memberBLL.SelectAllMembersCount();
            if (memberCount > 0)
            {
                if (!isAdmin && !isEditor)
                {
                    CommentDTO dto = commentBLL.Select();
                    int commentCount = dto.Comments.Count(x => x.MemberID == LoginInfo.MemberID);
                    CommentDetailDTO detail = dto.Comments.First(x => x.MemberID == LoginInfo.MemberID);
                    if (commentCount > 1)
                    {
                        FormSingleCommentList open = new FormSingleCommentList();
                        open.memberID = detail.MemberID;
                        this.Hide();
                        open.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        FormViewComment open = new FormViewComment();
                        open.detail = detail;
                        this.Hide();
                        open.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    buttonWasClicked = true;
                    ActivateButton(sender, RBGColors.color1);
                    OpenChildForm(new FormCommentsList());
                }
            }
        }

        private void btnDeadMembers_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormDeadMembersList());
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormDocumentList());
        }

        private void panelNoOfChildren_Click(object sender, EventArgs e)
        {
            btnChildren.PerformClick();
        }

        private void panelMeetingAttend_Click(object sender, EventArgs e)
        {
            btnAttendance.PerformClick();
        }

        private void panelLastEvent_Click(object sender, EventArgs e)
        {
            btnEvents.PerformClick();
        }

        private void panelTotalComment_Click(object sender, EventArgs e)
        {
            btnComments.PerformClick();
        }

        private void panelMonthlyComment_Click(object sender, EventArgs e)
        {
            btnComments.PerformClick();
        }

        private void panelMonthlyDues_Click(object sender, EventArgs e)
        {
            btnAttendance.PerformClick();
        }

        private void panelYearlyDues_Click(object sender, EventArgs e)
        {
            btnAttendance.PerformClick();
        }

        public void TriggerEventButtonOnClick()
        {
            btnEvents.PerformClick();
        }

        private void labelLastEventDate_Click(object sender, EventArgs e)
        {

        }

        private void panelLastEvent_Click_1(object sender, EventArgs e)
        {
            btnEvents.PerformClick();
        }
    }
}
