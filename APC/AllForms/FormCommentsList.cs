using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.BLL;
using APC.DAL.DTO;

namespace APC.AllForms
{
    public partial class FormCommentsList : Form
    {
        public FormCommentsList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormComments open = new FormComments();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormComments open = new FormComments();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormComments open = new FormComments();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
        GenderDTO dto = new GenderDTO();
        GenderBLL bll = new GenderBLL();
        private void FormCommentsList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbGender.DataSource = dto.Genders;
            cmbGender.DisplayMember = "GenderName";
            cmbGender.ValueMember = "GenderID";
            cmbGender.SelectedIndex = -1;
        }
    }
}
