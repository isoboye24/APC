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
    public partial class FormDeadMembersList : Form
    {
        public FormDeadMembersList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDeadMembers open = new FormDeadMembers();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormDeadMembers open = new FormDeadMembers();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
    }
}
