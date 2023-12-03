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
using System.Windows.Documents;
using System.Windows.Forms;

namespace APC
{
    public partial class FormAttendanceList : Form
    {
        public FormAttendanceList()
        {
            InitializeComponent();
        }
        AttendanceBLL bll = new AttendanceBLL();
        AttendanceDTO dto = new AttendanceDTO();
        private void FormAttendanceList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            dataGridView1.DataSource = dto.AttendanceLists;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Month";
            dataGridView1.Columns[2].HeaderText = "Year";
            dataGridView1.Columns[3].HeaderText = "Members";
            dataGridView1.Columns[4].HeaderText = "Female";
            dataGridView1.Columns[5].HeaderText = "Male";
            dataGridView1.Columns[6].HeaderText = "Dues Paid";
            dataGridView1.Columns[7].HeaderText = "Dues Expected";
            dataGridView1.Columns[8].HeaderText = "Balance";
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormAttendance open = new FormAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            FillDateGrid();
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            FormAttendance open = new FormAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            FillDateGrid();
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtNoOfAttend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtMonthlyDues_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }
        private void FillDateGrid()
        {
            bll = new AttendanceBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.AttendanceLists;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<AttendanceListDetailDTO> list = dto.AttendanceLists;
            if (txtMonthlyDues.Text.Trim() != "")
            {
                if (rbEqualMonDues.Checked)
                {
                    list = list.Where(x => x.TotalDuesPaid == Convert.ToInt32(txtMonthlyDues.Text)).ToList();
                }
                else if (rbLessMonDues.Checked)
                {
                    list = list.Where(x => x.TotalDuesPaid < Convert.ToInt32(txtMonthlyDues.Text)).ToList();
                }
                else if (rbMoreMonDues.Checked)
                {
                    list = list.Where(x => x.TotalDuesPaid > Convert.ToInt32(txtMonthlyDues.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criterion from the monthly dues group");
                }
            }
            if (txtNoOfAttend.Text.Trim() != "")
            {
                if (rbEqualAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembers == Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else if (rbLessAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembers < Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else if (rbMoreAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembers > Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Please select a criterion from the total number of attendance group");
                }
            }
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32((cmbMonth.SelectedValue))).ToList();
            }            
            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYear.Clear();
            txtNoOfAttend.Clear();
            txtMonthlyDues.Clear();
            rbEqualMonDues.Checked = false;
            rbLessMonDues.Checked = false;
            rbMoreMonDues.Checked = false;
            rbEqualAttend.Checked = false;
            rbLessAttend.Checked = false;
            rbMoreAttend.Checked = false;
            cmbMonth.SelectedIndex = -1;
            FillDateGrid();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<AttendanceListDetailDTO> list = dto.AttendanceLists;
            list = list.Where(x => x.Year.Contains(txtYear.Text.ToString())).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
