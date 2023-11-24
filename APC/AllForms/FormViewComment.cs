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
    public partial class FormViewComment : Form
    {
        public FormViewComment()
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
        public CommentDetailDTO detail = new CommentDetailDTO();
        private void FormViewComment_Load(object sender, EventArgs e)
        {
            txtName.Text = detail.Name;
            txtSurname.Text = detail.Surname;
            txtComment.Text = detail.CommentName;
            string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
            picProfilePic.ImageLocation = imagePath;
            labelDate.Text = detail.Day.ToString() + "/" + detail.MonthID.ToString() + "/" + detail.Year;
            labelTitle.Text = detail.Surname + " " + detail.Name + "'s comment";
        }
    }
}
