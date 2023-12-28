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

namespace APC.AllForms
{
    public partial class FormViewMember : Form
    {
        public FormViewMember()
        {
            InitializeComponent();
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

            txtPhone2.Hide();
            txtPhone3.Hide();
            labelPhone2.Hide();
            labelPhone3.Hide();
            btnViewChildren.Hide();
            labelNoOfChildren.Text = noOfChildren.ToString();
            if (Convert.ToInt32(labelNoOfChildren.Text) > 0)
            {
                labelChildren.Text = "Child";
                btnViewChildren.Text = "View Child";
                btnViewChildren.Visible = true;
            }
            if (Convert.ToInt32(labelNoOfChildren.Text) > 1)
            {
                labelChildren.Text = "Children";
                btnViewChildren.Text = "View Children";
                btnViewChildren.Visible = true;
            }

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
    }
}
