﻿using APC.BLL;
using APC.DAL.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace APC
{
    public partial class FormPersonalAttendance : Form
    {
        public FormPersonalAttendance()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        PersonalAttendanceBLL bll = new PersonalAttendanceBLL();
        PersonalAttendanceDTO dto = new PersonalAttendanceDTO();
        MemberDetailDTO memberDetail = new MemberDetailDTO();
        AttendanceStatusDetailDTO attStatusDetail = new AttendanceStatusDetailDTO();
        public GeneralAttendanceDetailDTO generalAttendanceDetail = new GeneralAttendanceDetailDTO();
        public PersonalAttendanceDetailDTO personalDetail = new PersonalAttendanceDetailDTO();
        public bool isUpdate = false;
        private void FormAttendance_Load(object sender, EventArgs e)
        {
            dto = bll.Select();

            #region
            dataGridViewAttendanceStatuses.DataSource = dto.AttendanceStatuses;
            dataGridViewAttendanceStatuses.Columns[0].Visible = false;
            dataGridViewAttendanceStatuses.Columns[1].HeaderText = "Attend. Status";

            dataGridViewMembers.DataSource = dto.Members;
            dataGridViewMembers.Columns[0].Visible = false;
            dataGridViewMembers.Columns[1].Visible = false;
            dataGridViewMembers.Columns[2].Visible = false;
            dataGridViewMembers.Columns[3].HeaderText = "Surname";
            dataGridViewMembers.Columns[4].HeaderText = "Name";
            dataGridViewMembers.Columns[5].Visible = false;
            dataGridViewMembers.Columns[6].Visible = false;
            dataGridViewMembers.Columns[7].Visible = false;
            dataGridViewMembers.Columns[8].Visible = false;
            dataGridViewMembers.Columns[9].Visible = false;
            dataGridViewMembers.Columns[10].Visible = false;
            dataGridViewMembers.Columns[11].Visible = false;
            dataGridViewMembers.Columns[12].Visible = false;
            dataGridViewMembers.Columns[13].Visible = false;
            dataGridViewMembers.Columns[14].Visible = false;
            dataGridViewMembers.Columns[15].Visible = false;
            dataGridViewMembers.Columns[16].Visible = false;
            dataGridViewMembers.Columns[17].Visible = false;
            dataGridViewMembers.Columns[18].Visible = false;
            dataGridViewMembers.Columns[19].HeaderText = "Gender";
            dataGridViewMembers.Columns[20].Visible = false;
            dataGridViewMembers.Columns[21].Visible = false;
            dataGridViewMembers.Columns[22].Visible = false;
            dataGridViewMembers.Columns[23].Visible = false;
            dataGridViewMembers.Columns[24].Visible = false;
            dataGridViewMembers.Columns[25].Visible = false;
            dataGridViewMembers.Columns[26].Visible = false;
            dataGridViewMembers.Columns[27].Visible = false;
            dataGridViewMembers.Columns[28].Visible = false;
            #endregion

            if (isUpdate)
            {
                txtSurname.Text = personalDetail.Surname;
                txtName.Text = personalDetail.Name;
                txtGender.Text = personalDetail.Gender;
                txtAttendanceStatus.Text = personalDetail.AttendanceStatusName;
                txtMonthlyDues.Text = personalDetail.MonthlyDue.ToString();
                string imagePath = Application.StartupPath + "\\images\\" + personalDetail.ImagePath;
                picProfilePic.ImageLocation = imagePath;

                tableLayoutPanelMemberList.Hide();
            }
        }

        private void txtMonthlyDues_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            List<MemberDetailDTO> list = dto.Members;
            list = list.Where(x => x.Surname.Contains(txtSearchSurname.Text)).ToList();
            dataGridViewMembers.DataSource = list;
        }

        private void dataGridViewMembers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            memberDetail = new MemberDetailDTO();
            memberDetail.MemberID = Convert.ToInt32(dataGridViewMembers.Rows[e.RowIndex].Cells[0].Value);
            txtSurname.Text = dataGridViewMembers.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtName.Text = dataGridViewMembers.Rows[e.RowIndex].Cells[4].Value.ToString();
            memberDetail.ImagePath = dataGridViewMembers.Rows[e.RowIndex].Cells[6].Value.ToString();
            string imagePath = Application.StartupPath + "\\images\\" + memberDetail.ImagePath;
            picProfilePic.ImageLocation = imagePath;
            txtGender.Text = dataGridViewMembers.Rows[e.RowIndex].Cells[19].Value.ToString();
        }

        private void dataGridViewAttendanceStatuses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            attStatusDetail = new AttendanceStatusDetailDTO();
            attStatusDetail.AttendanceStatusID = Convert.ToInt32(dataGridViewAttendanceStatuses.Rows[e.RowIndex].Cells[0].Value);
            txtAttendanceStatus.Text = dataGridViewAttendanceStatuses.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        
        private void txtSearchSurname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (memberDetail.MemberID == 0)
            {
                MessageBox.Show("Please choose a member from the table");
            }
            if (attStatusDetail.AttendanceStatusID == 0)
            {
                MessageBox.Show("Please choose an attendance status from the table");
            }            
            else
            {
                if (!isUpdate)
                {
                    bool isUnique = bll.IsUnique(memberDetail.MemberID, generalAttendanceDetail.GeneralAttendanceID);
                    if (!isUnique)
                    {
                        MessageBox.Show("This member has been added");
                    }
                    else
                    {
                        PersonalAttendanceDetailDTO attendance = new PersonalAttendanceDetailDTO();
                        attendance.AttendanceStatusID = attStatusDetail.AttendanceStatusID;
                        attendance.MemberID = memberDetail.MemberID;
                        attendance.ExpectedDue = 10;
                        if (txtMonthlyDues.Text.Trim() == "")
                        {
                            attendance.MonthlyDue = 0;
                        }
                        else
                        {
                            attendance.MonthlyDue = Convert.ToDecimal(txtMonthlyDues.Text);
                        }
                        attendance.Balance = attendance.ExpectedDue - attendance.MonthlyDue;
                        attendance.Day = generalAttendanceDetail.Day;
                        attendance.MonthID = generalAttendanceDetail.MonthID;
                        attendance.Year = generalAttendanceDetail.Year;
                        attendance.GeneralAttendanceID = generalAttendanceDetail.GeneralAttendanceID;
                        if (bll.Insert(attendance))
                        {
                            MessageBox.Show("Attendance was added");
                            txtMonthlyDues.Clear();
                        }               
                    }
                }
                else if (isUpdate)
                {
                    if (personalDetail.AttendanceStatusName == txtAttendanceStatus.Text && personalDetail.MonthlyDue == Convert.ToDecimal(txtMonthlyDues.Text))
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        personalDetail.AttendanceStatusID = attStatusDetail.AttendanceStatusID;
                        personalDetail.ExpectedDue = 10;
                        if (txtMonthlyDues.Text.Trim() == "")
                        {
                            personalDetail.MonthlyDue = 0;
                        }
                        else
                        {
                            personalDetail.MonthlyDue = Convert.ToDecimal(txtMonthlyDues.Text);
                        }
                        personalDetail.Balance = personalDetail.ExpectedDue - personalDetail.MonthlyDue;
                        personalDetail.Day = personalDetail.Day;
                        personalDetail.MonthID = personalDetail.MonthID;
                        personalDetail.Year = personalDetail.Year;
                        personalDetail.GeneralAttendanceID = personalDetail.GeneralAttendanceID;
                        if (bll.Update(personalDetail))
                        {
                            MessageBox.Show("The member was updated");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void txtExpectedMonthlyDue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtExpectedMonthlyDue_Click(object sender, EventArgs e)
        {

        }
    }
}