﻿using APC.BLL;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
            FillDataGrid();
        }
        PersonalAttendanceBLL bll = new PersonalAttendanceBLL();
        PersonalAttendanceDTO dto = new PersonalAttendanceDTO();
        public GeneralAttendanceDetailDTO detail = new GeneralAttendanceDetailDTO();
        PersonalAttendanceDetailDTO personalDetail = new PersonalAttendanceDetailDTO();
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

        private void FillDataGrid()
        {
            bll = new PersonalAttendanceBLL();
            dto = bll.SelectMembersSet(detail.GeneralAttendanceID);
            dataGridView1.DataSource = dto.PersonalAttendances;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormPersonalAttendance open = new FormPersonalAttendance();
            open.generalAttendanceDetail = detail;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            FillDataGrid();
            ShowRecordData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (personalDetail.AttendanceID == 0)
            {
                MessageBox.Show("Please choose a member from the table");
            }
            else
            {
                FormPersonalAttendance open = new FormPersonalAttendance();
                open.personalDetail = personalDetail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                FillDataGrid();
                ShowRecordData();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            personalDetail = new PersonalAttendanceDetailDTO();
            personalDetail.AttendanceID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            personalDetail.AttendanceStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            personalDetail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            personalDetail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            personalDetail.MonthName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            personalDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            personalDetail.MemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            personalDetail.Surname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            personalDetail.Name = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            personalDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            personalDetail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            personalDetail.Gender = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            personalDetail.AttendanceStatusName = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            personalDetail.MonthlyDue = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
            personalDetail.ExpectedDue = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            personalDetail.Balance = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
            personalDetail.GeneralAttendanceID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[16].Value);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            List<PersonalAttendanceDetailDTO> list = dto.PersonalAttendances;
            list = list.Where(x => x.Surname.Contains(txtSurname.Text.Trim())).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<PersonalAttendanceDetailDTO> list = dto.PersonalAttendances;
            list = list.Where(x => x.Name.Contains(txtName.Text.Trim())).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PersonalAttendanceDetailDTO> list = dto.PersonalAttendances;
            if (cmbAttendanceStatus.SelectedIndex != -1)
            {
                list = list.Where(x => x.AttendanceStatusID == Convert.ToInt32(cmbAttendanceStatus.SelectedValue)).ToList();
            }
            if (txtMonthlyDues.Text.Trim() != "")
            {
                if (rbEqual.Checked)
                {
                    list = list.Where(x => x.MonthlyDue == Convert.ToDecimal(txtMonthlyDues.Text)).ToList();
                }
                if (rbLess.Checked)
                {
                    list = list.Where(x => x.MonthlyDue < Convert.ToDecimal(txtMonthlyDues.Text)).ToList();
                }
                if (rbMore.Checked)
                {
                    list = list.Where(x => x.MonthlyDue > Convert.ToDecimal(txtMonthlyDues.Text)).ToList();
                }
            }
            dataGridView1.DataSource = list;
        }
    }
}