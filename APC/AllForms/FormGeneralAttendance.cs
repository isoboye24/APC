﻿using APC.BLL;
using APC.DAL;
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
    public partial class FormGeneralAttendance : Form
    {
        public FormGeneralAttendance()
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
        GeneralAttendanceBLL bll = new GeneralAttendanceBLL();
        public GeneralAttendanceDetailDTO detail = new GeneralAttendanceDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                GeneralAttendanceDetailDTO generalAttendance = new GeneralAttendanceDetailDTO();
                generalAttendance.Day = dateTimePickerGenAttDate.Value.Day;
                generalAttendance.MonthID = dateTimePickerGenAttDate.Value.Month;
                generalAttendance.Year = dateTimePickerGenAttDate.Value.Year.ToString();
                generalAttendance.Summary = txtSummary.Text.Trim();
                generalAttendance.TotalMembersPresent = 0;
                generalAttendance.TotalMembersAbsent = 0;
                generalAttendance.TotalDuesPaid = 0;
                generalAttendance.TotalDuesExpected = 0;
                generalAttendance.TotalDuesBalance = generalAttendance.TotalDuesExpected - generalAttendance.TotalDuesPaid;
                
                if (bll.Insert(generalAttendance))
                {
                    MessageBox.Show("Attendance was added");
                    dateTimePickerGenAttDate.Value = DateTime.Today;
                    txtSummary.Clear();
                }
            }
            else if (isUpdate)
            {
                if (dateTimePickerGenAttDate.Value == Convert.ToDateTime(detail.MonthID + "/" + detail.Day + "/" + detail.Year) && detail.Summary == txtSummary.Text.Trim())
                {
                    MessageBox.Show("There is no change");
                }
                else
                {
                    detail.Day = dateTimePickerGenAttDate.Value.Day;
                    detail.MonthID = dateTimePickerGenAttDate.Value.Month;
                    detail.Year = dateTimePickerGenAttDate.Value.Year.ToString();
                    detail.Summary = txtSummary.Text.Trim();
                    if (bll.Update(detail))
                    {
                        MessageBox.Show("Attendance was updated");
                        this.Close();
                    }
                }
            }
        }

        private void FormGeneralAttendance_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                labelTitle.Text = "Edit meeting on " + detail.Day + "." + detail.MonthID +"."+ detail.Year;
                dateTimePickerGenAttDate.Value = Convert.ToDateTime(detail.MonthID + "/" + detail.Day + "/" + detail.Year);
                txtSummary.Text = detail.Summary;
            }
        }
    }
}