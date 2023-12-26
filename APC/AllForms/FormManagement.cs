using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.BLL;
using FontAwesome.Sharp;

namespace APC.AllForms
{
    public partial class FormManagement : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private FormDashboard dashboardForm;
        public FormManagement()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            dashboardForm = new FormDashboard();
        }
        // Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(204, 102, 0);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(245, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color normal = Color.MidnightBlue;
        }
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
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkOrange;
            labelTitleChildForm.Text = "Management";
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
        public FormProperties formDetail = new FormProperties();
        public FormProperties initialDetail = new FormProperties();
        private void labelHome_Click(object sender, EventArgs e)
        {            
            dashboardForm = new FormDashboard();
            //dashboardForm.StartPosition = formDetail.StartPosition;
            //dashboardForm.Location = formDetail.Location;
            //dashboardForm.Size = formDetail.Size;
            //dashboardForm.WindowState = formDetail.WindowState;
            this.Hide();
            dashboardForm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin open = new FormLogin();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);            
        }
        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ProfessionBLL profBll = new ProfessionBLL();
        PositionBLL posBll = new PositionBLL();
        MemberBLL memberBLL = new MemberBLL();
        PermissionBLL permissionBLL = new PermissionBLL();
        EventsBLL eventBLL = new EventsBLL();
        
        private void FormManagement_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            if (WindowState == FormWindowState.Normal)
            {
                RefreshAllCards(150, 29);
            }
            else
            {
                RefreshAllCards(300, 42);
            }
        }
        private void RefreshAllCards(int x, int y)
        {
            General.ValueCount(labelTotalProfession, profBll.SelectUniqueProfessionCount(), x, y);
            General.ValueCount(labelTotalPosition, posBll.SelectUniquePositionCount(), x, y);
            General.ValueCount(labelTotalNationality, memberBLL.SelectCountUniqueNationality(), x, y);
            General.ValueCount(labelTotalPermission, permissionBLL.SelectPermittedMembersCount(), x, y);
            General.ValueCount(labelTotalEvent, eventBLL.SelectEventCount(), x, y);
        }
        private void iconClose_MouseEnter(object sender, EventArgs e)
        {
            iconClose.BackColor = RBGColors.color1;
        }

        private void iconClose_MouseHover(object sender, EventArgs e)
        {
            iconClose.BackColor = RBGColors.color1;
        }

        private void iconClose_MouseLeave(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.DarkOrange;
        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMaximize_MouseEnter(object sender, EventArgs e)
        {
            iconMaximize.BackColor = RBGColors.color1;
        }

        private void iconMaximize_MouseHover(object sender, EventArgs e)
        {
            iconMaximize.BackColor = RBGColors.color1;
        }

        private void iconMaximize_MouseLeave(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.DarkOrange;
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {                
                if (this.Owner is FormDashboard dashboardForm)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.RefreshAllCards(300, 42);
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.RefreshAllCards(300, 42);
                }                
            }
            else
            {                
                if (this.Owner is FormDashboard dashboardForm)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.RefreshAllCards(300, 42);
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.RefreshAllCards(150, 42);
                }
            }
        }

        private void iconMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconMinimize.BackColor = RBGColors.color1;
        }

        private void iconMinimize_MouseHover(object sender, EventArgs e)
        {
            iconMinimize.BackColor = RBGColors.color1;
        }

        private void iconMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.DarkOrange;
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

        private bool buttonWasClicked = false;
        private void btnPosition_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormPositionList());
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormCountryList());
        }

        private void btnMaritalStatus_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormMaritalStatusList());
        }

        private void btnEmploymentStatus_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormEmploymentStatusList());
        }

        private void btnProfession_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormProfessionList());
        }        

        private void btnManagement_Click(object sender, EventArgs e)
        {
            if (buttonWasClicked)
            {
                currentChildForm.Close();
                Reset();
                if (WindowState == FormWindowState.Normal)
                {                    
                    RefreshAllCards(150, 42);
                }
                else
                {                    
                    RefreshAllCards(300, 42);
                }
            }
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormPermissionList());
        }

        private void btnNationality_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormNationalityList());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormContactList());
        }

        private void btnDeletedData_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormDeletedData());
        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                RefreshAllCards(150, 42);
            }
            else
            {
                RefreshAllCards(300, 42);
            }
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.DarkOrange;
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.DarkOrange;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.BackColor = Color.White;
        }

        private void panelTotalNationality_Click(object sender, EventArgs e)
        {
            btnNationality.PerformClick();
        }

        private void panelTotalEvent_Click(object sender, EventArgs e)
        {
            dashboardForm.TriggerEventButtonOnClick();
        }

        private void panelTotalProfession_Click(object sender, EventArgs e)
        {
            btnProfession.PerformClick();
        }

        private void panelTotalPermission_Click(object sender, EventArgs e)
        {
            btnPermission.PerformClick();
        }

        private void panelTotalPosition_Click(object sender, EventArgs e)
        {
            btnPosition.PerformClick();
        }

        private void FormManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Owner is FormDashboard dashboardForm)
            {
                dashboardForm.WindowState = this.WindowState;
            }
        }
    }
}
