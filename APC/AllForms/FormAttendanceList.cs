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
    public partial class FormAttendanceList : Form
    {
        public FormAttendanceList()
        {
            InitializeComponent();
        }        

        private void FormAttendanceList_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormAttendance open = new FormAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FormAttendance open = new FormAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            FormAttendance open = new FormAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
    }
}
