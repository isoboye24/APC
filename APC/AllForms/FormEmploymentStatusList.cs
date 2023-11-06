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
    public partial class FormEmploymentStatusList : Form
    {
        public FormEmploymentStatusList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMaritalStatus open = new FormMaritalStatus();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormMaritalStatus open = new FormMaritalStatus();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
    }
}
