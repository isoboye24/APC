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

namespace APC.AllForms
{
    public partial class FormViewGeneralAttendance : Form
    {
        public FormViewGeneralAttendance()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFilters()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtMonthlyDues.Clear();
            rbLess.Checked = false;
            rbMore.Checked = false;
            rbEqual.Checked = false;
            cmbAttendanceStatus.SelectedIndex = -1;
        }
        private void FillDateGrid()
        {
            bll = new PersonalAttendanceBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.GeneralAttendance;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        PersonalAttendanceBLL bll = new PersonalAttendanceBLL();
        PersonalAttendanceDTO dto = new PersonalAttendanceDTO();
        public GeneralAttendanceDetailDTO detail = new GeneralAttendanceDetailDTO();
        private void FormViewAttendance_Load(object sender, EventArgs e)
        {
            dto = bll.Select();

            cmbAttendanceStatus.DataSource = dto.AttendanceStatuses;
            General.ComboBoxProps(cmbAttendanceStatus, "AttendanceStatusName", "AttendanceStatusID");

            dto = bll.SelectMembersSet(detail.GeneralAttendanceID);
            dataGridView1.DataSource = dto.PersonalAttendances;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Surname";
            dataGridView1.Columns[8].HeaderText = "Name";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Gender";
            dataGridView1.Columns[12].HeaderText = "Status";
            dataGridView1.Columns[13].HeaderText = "Dues Paid";
            dataGridView1.Columns[14].HeaderText = "Expected Dues";
            dataGridView1.Columns[15].HeaderText = "Balance";
            dataGridView1.Columns[16].Visible = false;

            labelTitle.Text = "Meeting on " + detail.Day + "." + detail.MonthID + "." + detail.Year;
            ShowRecordData();
        }
        private void ShowRecordData()
        {
            labelTotalMembersPresent.Text = detail.TotalMembersPresent.ToString();
            labelTotalMembersAbsent.Text = detail.TotalMembersAbsent.ToString();
            labelTotalDuesPaid.Text = detail.TotalDuesPaid.ToString();
            labelTotalDuesExpected.Text = detail.TotalDuesExpected.ToString();
            labelTotalDuesBalance.Text = detail.TotalDuesBalance.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormPersonalAttendance open = new FormPersonalAttendance();
            open.generalAttendanceDetail = detail;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.SelectMembersSet(detail.GeneralAttendanceID);
            dataGridView1.DataSource = dto.PersonalAttendances;
            ShowRecordData();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
