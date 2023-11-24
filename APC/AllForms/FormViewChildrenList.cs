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
    public partial class FormViewChildrenList : Form
    {
        public FormViewChildrenList()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormViewChild open = new FormViewChild();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
