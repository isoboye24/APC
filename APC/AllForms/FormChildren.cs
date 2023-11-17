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
    public partial class FormChildren : Form
    {
        public FormChildren()
        {
            InitializeComponent();
        }

        private void FormChildren_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormChildren_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
