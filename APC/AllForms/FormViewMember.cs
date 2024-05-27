using APC.DAL.DTO;
using APC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.DAL;
using System.Runtime.InteropServices;

namespace APC.AllForms
{
    public partial class FormViewMember : Form
    {
        public FormViewMember()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnViewChildren_Click(object sender, EventArgs e)
        {
            if (noOfChildren > 1)
            {
                FormViewChildrenList open = new FormViewChildrenList();
                open.memberID = detail.MemberID;
                open.isParent = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
            else if(noOfChildren < 2 && noOfChildren > 0)
            {
                FormViewChild open = new FormViewChild();
                open.memberID = detail.MemberID;
                open.isParent = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }            
        }
        public MemberDetailDTO detail = new MemberDetailDTO();
        public bool isView = false;
        ChildBLL childBLL = new ChildBLL();
        int noOfChildren = 0;
        int commentCount = 0;
        CommentBLL commentBLL = new CommentBLL();
        CommentDetailDTO commentDetail = new CommentDetailDTO();
        CommentDTO dto = new CommentDTO();
        MemberBLL bll = new MemberBLL();
        int attendancePresentCount = 0;
        int attendanceAbsentCount = 0;
        decimal amountContributed = 0;
        decimal amountExpected = 0;
        decimal Balance = 0;
        public bool isFormer = false;
        private void FormViewMember_Load(object sender, EventArgs e)
        {
            labelCommentText.Hide();
            labelNoOfComments.Hide();
            btnNoComments.Hide();

            dto = commentBLL.SelectMembersCommentList(detail.MemberID);
            commentCount = dto.Comments.Count(x => x.MemberID == detail.MemberID);
            labelNoOfComments.Text = commentCount.ToString();
            if (commentCount == 1)
            {
                labelCommentText.Visible = true;
                labelNoOfComments.Visible = true;
                btnNoComments.Visible = true;
                btnNoComments.Text = "View Comment";
            }
            else if(commentCount > 1)
            {
                labelCommentText.Visible = true;
                labelCommentText.Text = "Comments";
                labelNoOfComments.Visible = true;
                btnNoComments.Visible = true;
            }

            noOfChildren = childBLL.SelectAllChildrenCount(detail.MemberID);
            btnViewChildren.Hide();
            labelNoOfChildren.Text = noOfChildren.ToString();
            if (noOfChildren > 0)
            {
                labelChildren.Text = "Child";
                btnViewChildren.Text = "View Child";
                btnViewChildren.Visible = true;
            }
            if (noOfChildren > 1)
            {
                labelChildren.Text = "Children";
                btnViewChildren.Text = "View Children";
                btnViewChildren.Visible = true;
            }

            attendancePresentCount = bll.GetNoOfMembersPresentAttendance(detail.MemberID);
            labelNoOfPresent.Text = attendancePresentCount.ToString();
            btnViewPresentAttendance.Hide();
            if (attendancePresentCount > 0)
            {
                btnViewPresentAttendance.Visible = true;
            }

            attendanceAbsentCount = bll.GetNoOfMembersAbsentAttendance(detail.MemberID);
            labelNoOfAbsent.Text = attendanceAbsentCount.ToString();
            btnViewAbsentAttendance.Hide();
            if (attendanceAbsentCount > 0)
            {
                btnViewAbsentAttendance.Visible = true;
            }
            amountContributed = bll.GetAmountContributed(detail.MemberID);
            labelAmountContributed.Text = "€" + amountContributed;
            btnViewAmountContributed.Hide();
            if (amountContributed > 0)
            {
                btnViewAmountContributed.Visible = true;
            }
            amountExpected = bll.GetAmountExpected();
            labelAmountExpected.Text = "€" + amountExpected + ".00";
            btnViewAmountExpected.Hide();
            if (amountExpected > 0)
            {
                btnViewAmountExpected.Visible = true;
            }
            Balance = amountExpected - amountContributed;
            labelPersonalBalance.Text = "€" + Balance;
            btnViewPersonalBalance.Hide();
            if (Balance > 0)
            {
                btnViewPersonalBalance.Visible = true;
            }

            txtPhone2.Hide();
            txtPhone3.Hide();
            labelPhone2.Hide();
            labelPhone3.Hide();
            if (isView)
            {
                labelMemberNameTitle.Text = detail.Surname + " " + detail.Name;
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfilePic.ImageLocation = imagePath;

                txtName.Text = detail.Name;
                txtSurname.Text = detail.Surname;
                txtAddress.Text = detail.HouseAddress;
                txtPosition.Text = detail.PositionName;
                labelBirthday.Text = detail.Birthday.ToShortDateString();
                labelMemSince.Text = detail.MembershipDate.ToShortDateString();
                txtUsername.Text = detail.Username;
                txtPassword.Text = detail.Password;
                txtEmail.Text = detail.EmailAddress;
                txtPhone1.Text = detail.PhoneNumber;
                txtLGA.Text = detail.LGA;
                if (detail.PhoneNumber2 != "")
                {
                    txtPhone2.Visible = true;
                    labelPhone2.Visible = true;
                }
                if (detail.PhoneNumber3 != "")
                {
                    txtPhone3.Visible = true;
                    labelPhone3.Visible = true;
                }
                txtPhone2.Text = detail.PhoneNumber2;
                txtPhone3.Text = detail.PhoneNumber3;
                txtCountry.Text = detail.CountryName;
                txtProfession.Text = detail.ProfessionName;
                txtEmpStatus.Text = detail.EmploymentStatusName;
                txtGender.Text = detail.GenderName;
                txtNationality.Text = detail.NationalityName;
                txtMaritalStatus.Text = detail.MaritalStatusName;
                txtPermission.Text = detail.PermissionName;
                txtNextOfKin.Text = detail.NameOfNextOfKin;
                txtNextOfKinRelationship.Text = detail.RelationshipToKin;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewComments_Click(object sender, EventArgs e)
        {
            if (commentCount > 1)
            {
                FormSingleCommentList open = new FormSingleCommentList();
                open.memberID = detail.MemberID;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
            else if (commentCount < 2 && commentCount > 0)
            {
                commentDetail = dto.Comments.First(x => x.MemberID == detail.MemberID);
                FormViewComment open = new FormViewComment();
                open.detail = commentDetail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }
        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            if (attendancePresentCount > 0)
            {
                FormViewPersonalAttendances open = new FormViewPersonalAttendances();
                open.detail = detail;
                open.isPresent = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnViewAbsentAttendance_Click(object sender, EventArgs e)
        {
            if (attendanceAbsentCount > 0)
            {
                FormViewPersonalAttendances open = new FormViewPersonalAttendances();
                open.detail = detail;
                open.isAbsent = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnViewAmountContributed_Click(object sender, EventArgs e)
        {
            if (amountContributed > 0)
            {
                FormViewPersonalAttendances open = new FormViewPersonalAttendances();
                open.detail = detail;
                open.isAmountContributed = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnViewAmountExpected_Click(object sender, EventArgs e)
        {
            if (amountExpected > 0)
            {
                FormViewPersonalAttendances open = new FormViewPersonalAttendances();
                open.detail = detail;
                open.isAmountExpected = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void btnViewPersonalBalance_Click(object sender, EventArgs e)
        {
            if (Balance > 0)
            {
                FormViewPersonalAttendances open = new FormViewPersonalAttendances();
                open.detail = detail;
                open.isPersonalBalance = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
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
    }
}
