using APC.AllForms;
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
using System.Xml.Linq;

namespace APC
{
    public partial class FormGeneralAttendanceList : Form
    {
        public FormGeneralAttendanceList()
        {
            InitializeComponent();
        }
        GeneralAttendanceBLL bll = new GeneralAttendanceBLL();
        GeneralAttendanceDTO dto = new GeneralAttendanceDTO();
        GeneralAttendanceDetailDTO detail = new GeneralAttendanceDetailDTO();
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormGeneralAttendance open = new FormGeneralAttendance();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            ClearFilters();
            FillDateGrid();
        }
        private void btnView_Click_1(object sender, EventArgs e)
        {
            if (detail.GeneralAttendanceID == 0)
            {
                MessageBox.Show("Please choose an attendance from the table");
            }
            else
            {
                FormViewGeneralAttendance open = new FormViewGeneralAttendance();
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
                FillDateGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.GeneralAttendanceID == 0)
            {
                MessageBox.Show("Please choose an attendance from the table");
            }
            else
            {
                FormGeneralAttendance open = new FormGeneralAttendance();
                open.isUpdate = true;
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
                FillDateGrid();
            }
        }

        private void FormAttendanceList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            rbEqualAttend.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            rbEqualMonDues.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            rbLessAttend.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            rbLessMonDues.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            rbMoreAttend.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            rbMoreMonDues.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            txtMonthlyDues.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtNoOfAttend.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtYear.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbMonth.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnView.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnAbsentees.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSearch.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClear.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            dataGridView1.DataSource = dto.GeneralAttendance;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Month";
            dataGridView1.Columns[4].HeaderText = "Year";
            dataGridView1.Columns[5].HeaderText = "Members Present";
            dataGridView1.Columns[6].HeaderText = "Members Absent";
            dataGridView1.Columns[7].HeaderText = "Dues Paid";
            dataGridView1.Columns[8].HeaderText = "Dues Expected";
            dataGridView1.Columns[9].HeaderText = "Balance";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
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
            bll = new GeneralAttendanceBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.GeneralAttendance;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<GeneralAttendanceDetailDTO> list = dto.GeneralAttendance;
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
                    list = list.Where(x => x.TotalMembersPresent == Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else if (rbLessAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembersPresent < Convert.ToInt32(txtNoOfAttend.Text)).ToList();
                }
                else if (rbMoreAttend.Checked)
                {
                    list = list.Where(x => x.TotalMembersPresent > Convert.ToInt32(txtNoOfAttend.Text)).ToList();
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
            ClearFilters();
            FillDateGrid();
        }
        private void ClearFilters()
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
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<GeneralAttendanceDetailDTO> list = dto.GeneralAttendance;
            list = list.Where(x => x.Year.Contains(txtYear.Text.ToString())).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new GeneralAttendanceDetailDTO();
            detail.GeneralAttendanceID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Month = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Year = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.TotalMembersPresent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.TotalMembersAbsent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detail.TotalDuesPaid = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.TotalDuesExpected = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detail.TotalDuesBalance = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.Summary = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.AttendanceDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.GeneralAttendanceID == 0)
            {
                MessageBox.Show("Please choose an attendance from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Attendance was deleted");
                        ClearFilters();
                        FillDateGrid();
                    }
                }
            }
        }

        private void btnAbsentees_Click(object sender, EventArgs e)
        {
            FormNotifications open = new FormNotifications();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
