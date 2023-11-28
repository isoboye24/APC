using APC.BLL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC.AllForms
{
    public partial class FormViewDeadMember : Form
    {
        public FormViewDeadMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DeadMembersDetailDTO detail = new DeadMembersDetailDTO();
        public bool isView = false;
        ChildBLL childBLL = new ChildBLL();
        int noOfChildren =  0;
        private void FormViewDeadMember_Load(object sender, EventArgs e)
        {
            noOfChildren = childBLL.SelectAllChildrenCount(detail.DeadMemberID);
            
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
                txtPosition.Text = detail.PositionName;
                labelBirthday.Text = detail.Birthday.ToShortDateString();
                labelMemSince.Text = detail.MembershipDate.ToShortDateString();                
                labelDeadDate.Text = detail.DeathDate.ToShortDateString();                
                txtCountry.Text = detail.CountryName;
                txtProfession.Text = detail.ProfessionName;
                txtGender.Text = detail.GenderName;
                txtNationality.Text = detail.NationalityName;
                txtMaritalStatus.Text = detail.MaritalStatusName;

                TimeSpan difference = detail.DeathDate - detail.Birthday;
                labelAge.Text = Math.Floor(difference.TotalDays / 365.25).ToString() + " years";
            }
        }

        private void btnViewChildren_Click(object sender, EventArgs e)
        {
            if (noOfChildren > 1)
            {
                FormViewChildrenList open = new FormViewChildrenList();
                open.memberID = detail.DeadMemberID;
                open.isParent = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
            else if (noOfChildren < 2 && noOfChildren > 0)
            {
                FormViewChild open = new FormViewChild();
                open.memberID = detail.DeadMemberID;
                open.isParent = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
