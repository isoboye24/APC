using APC.AllForms;
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
    public partial class FormEventsList : Form
    {
        public FormEventsList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEvent open = new FormEvent();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormEvent open = new FormEvent();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormEvenImages open = new FormEvenImages();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
    }
}
