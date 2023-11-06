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

namespace APC
{
    public partial class FormComments : Form
    {
        public FormComments()
        {
            InitializeComponent();
        }

        private void FormComments_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormComments_Click(object sender, EventArgs e)
        {

        }
        GenderDTO dto = new GenderDTO();
        GenderBLL bll = new GenderBLL();
        private void FormComments_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbGender.DataSource = dto.Genders;
            cmbGender.DisplayMember = "GenderName";
            cmbGender.ValueMember = "GenderID";
            cmbGender.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
