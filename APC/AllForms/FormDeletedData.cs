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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace APC.AllForms
{
    public partial class FormDeletedData : Form
    {
        public FormDeletedData()
        {
            InitializeComponent();
        }
        MemberBLL bll = new MemberBLL();
        DeletedDataDTO dto = new DeletedDataDTO();
        MemberDetailDTO memberDetail = new MemberDetailDTO();
        CountryBLL countryBLL = new CountryBLL();
        CountryDetailDTO countryDetail = new CountryDetailDTO();
        NationalityBLL nationalityBLL = new NationalityBLL();
        NationalityDetailDTO nationalityDetail = new NationalityDetailDTO();
        ProfessionBLL professionBLL = new ProfessionBLL();
        ProfessionDetailDTO professionDetail = new ProfessionDetailDTO();
        PositionBLL positionBLL = new PositionBLL();
        PositionDetailDTO positionDetail = new PositionDetailDTO();
        EmploymentStatusBLL empStatusBLL = new EmploymentStatusBLL();
        EmploymentStatusDetailDTO empStatusDetail = new EmploymentStatusDetailDTO();
        MaritalStatusBLL marStatusBLL = new MaritalStatusBLL();
        MaritalStatusDetailDTO marStatusDetail = new MaritalStatusDetailDTO();
        ChildBLL childBLL = new ChildBLL();
        ChildDetailDTO childDetail = new ChildDetailDTO();
        CommentBLL commentBLL = new CommentBLL();
        CommentDetailDTO commentDetail = new CommentDetailDTO();
        DeadMembersBLL deadMemberBLL = new DeadMembersBLL();
        DeadMembersDetailDTO deadMemDetail = new DeadMembersDetailDTO();
        DocumentBLL documentBLL = new DocumentBLL();
        DocumentDetailDTO documentDetail = new DocumentDetailDTO();
        EventImageBLL eventImageBLL = new EventImageBLL();
        EventImageDetailDTO eventImageDetail = new EventImageDetailDTO();
        EventsBLL eventBLL = new EventsBLL();
        EventsDetailDTO eventDetail = new EventsDetailDTO();
        GeneralAttendanceBLL genAttendBLL = new GeneralAttendanceBLL();
        GeneralAttendanceDetailDTO genAttendDetail = new GeneralAttendanceDetailDTO();
        ExpenditureBLL expendutureBLL = new ExpenditureBLL();
        ExpenditureDetailDTO expenditureDetail = new ExpenditureDetailDTO();
        FinancialReportBLL financialRepBLl = new FinancialReportBLL();
        FinancialReportDetailDTO financialRepDetail = new FinancialReportDetailDTO();
        private void FormDeletedData_Load(object sender, EventArgs e)
        {
            cmbDeletedData.Items.Add("Registered Members");
            cmbDeletedData.Items.Add("Countries");
            cmbDeletedData.Items.Add("Nationalities");
            cmbDeletedData.Items.Add("Professions");
            cmbDeletedData.Items.Add("Positions");
            cmbDeletedData.Items.Add("Employment Statuses");
            cmbDeletedData.Items.Add("Marital Statuses");
            cmbDeletedData.Items.Add("Children");
            cmbDeletedData.Items.Add("Comments");
            cmbDeletedData.Items.Add("Dead Members");
            cmbDeletedData.Items.Add("Documents");
            cmbDeletedData.Items.Add("Event Images");
            cmbDeletedData.Items.Add("Events");
            cmbDeletedData.Items.Add("General Attendance");
            cmbDeletedData.Items.Add("Expenditure");
            cmbDeletedData.Items.Add("Financial Report");

            dto = bll.Select(true);
            dataGridView1.DataSource = dto.Members;
            #region
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Name";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].HeaderText = "Nationality";
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].HeaderText = "Profession";
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].HeaderText = "Position";
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].HeaderText = "Gender";
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
            dataGridView1.Columns[28].Visible = false;
            dataGridView1.Columns[29].Visible = false;
            dataGridView1.Columns[30].Visible = false;
            dataGridView1.Columns[31].Visible = false;
            dataGridView1.Columns[32].Visible = false;
            dataGridView1.Columns[33].Visible = false;
            dataGridView1.Columns[34].Visible = false;
            #endregion
        }

        private void cmbDeletedData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0)
            {
                dataGridView1.DataSource = dto.Members;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Surname";
                dataGridView1.Columns[4].HeaderText = "Name";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].HeaderText = "Nationality";
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].HeaderText = "Profession";
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].HeaderText = "Position";
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[19].HeaderText = "Gender";
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[23].Visible = false;
                dataGridView1.Columns[24].Visible = false;
                dataGridView1.Columns[25].Visible = false;
                dataGridView1.Columns[26].Visible = false;
                dataGridView1.Columns[27].Visible = false;
                dataGridView1.Columns[28].Visible = false;
                dataGridView1.Columns[29].Visible = false;
                dataGridView1.Columns[30].Visible = false;
                dataGridView1.Columns[31].Visible = false;
                dataGridView1.Columns[32].Visible = false;
                dataGridView1.Columns[33].Visible = false;
                dataGridView1.Columns[34].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                dataGridView1.DataSource = dto.Countries;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Country Name";
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dto.Nationalities;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nationality Name";
            }
            else if (cmbDeletedData.SelectedIndex == 3)
            {
                dataGridView1.DataSource = dto.Professions;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Profession Name";
            }
            else if (cmbDeletedData.SelectedIndex == 4)
            {
                dataGridView1.DataSource = dto.Positions;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Prosition Name";
            }
            else if (cmbDeletedData.SelectedIndex == 5)
            {
                dataGridView1.DataSource = dto.EmploymentStatuses;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Employment Status";
            }
            else if (cmbDeletedData.SelectedIndex == 6)
            {
                dataGridView1.DataSource = dto.MaritalStatuses;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Marital Status";
            }
            else if (cmbDeletedData.SelectedIndex == 7)
            {
                dataGridView1.DataSource = dto.Children;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Surname";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Gender";
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].HeaderText = "Nationality";
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].HeaderText = "Mother's name";
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = false;
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].HeaderText = "Father's name";
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[21].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 8)
            {
                dataGridView1.DataSource = dto.Comments;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Comment";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Surname";
                dataGridView1.Columns[4].HeaderText = "Name";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "Gender";
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].HeaderText = "Month";
                dataGridView1.Columns[11].HeaderText = "Year";
                dataGridView1.Columns[12].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 9)
            {
                dataGridView1.DataSource = dto.DeadMembers;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Surname";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "Birth Date";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Died";
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].HeaderText = "Nationality";
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].HeaderText = "Profession";
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].HeaderText = "Position";
                dataGridView1.Columns[15].Visible = false;
                dataGridView1.Columns[16].HeaderText = "Gender";
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[21].Visible = false;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[23].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 10)
            {
                dataGridView1.DataSource = dto.Documents;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Document Name";
                dataGridView1.Columns[2].HeaderText = "Document Type";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "Date";
                dataGridView1.Columns[8].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 11)
            {
                dataGridView1.DataSource = dto.EventImages;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "No.";
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[7].HeaderText = "Picture Caption";
                dataGridView1.Columns[8].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 12)
            {
                dataGridView1.DataSource = dto.Events;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Year";
                dataGridView1.Columns[5].HeaderText = "Event Title";
                dataGridView1.Columns[6].HeaderText = "Summary";
                dataGridView1.Columns[7].Visible = false;
            }
            else if (cmbDeletedData.SelectedIndex == 13)
            {
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
            }
            else if (cmbDeletedData.SelectedIndex == 14)
            {
                dataGridView1.DataSource = dto.Expenditures;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Summary";
                dataGridView1.Columns[2].HeaderText = "Amount Spent (€)";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].HeaderText = "Month";
                dataGridView1.Columns[6].HeaderText = "Year";
            }
            else if (cmbDeletedData.SelectedIndex == 15)
            {
                dataGridView1.DataSource = dto.FinancialReports;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Total Amount Raised";
                dataGridView1.Columns[2].HeaderText = "Total Amount Spent";
                dataGridView1.Columns[3].HeaderText = "Year";
                dataGridView1.Columns[4].Visible = false;
            }
            else
            {
                MessageBox.Show("Unknown data");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0 || cmbDeletedData.SelectedIndex == -1)
            {
                memberDetail = new MemberDetailDTO();
                memberDetail.MemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                memberDetail.Username = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                memberDetail.Password = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                memberDetail.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                memberDetail.Name = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                memberDetail.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                memberDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                memberDetail.EmailAddress = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                memberDetail.HouseAddress = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                memberDetail.MembershipDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                memberDetail.CountryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                memberDetail.CountryName = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                memberDetail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                memberDetail.NationalityName = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                memberDetail.ProfessionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
                memberDetail.ProfessionName = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                memberDetail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[16].Value);
                memberDetail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                memberDetail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[18].Value);
                memberDetail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
                memberDetail.EmploymentStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[20].Value);
                memberDetail.EmploymentStatusName = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
                memberDetail.MaritalStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[22].Value);
                memberDetail.MaritalStatusName = dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();
                memberDetail.PermissionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[24].Value);
                memberDetail.PermissionName = dataGridView1.Rows[e.RowIndex].Cells[25].Value.ToString();
                memberDetail.PhoneNumber = dataGridView1.Rows[e.RowIndex].Cells[26].Value.ToString();
                memberDetail.PhoneNumber2 = dataGridView1.Rows[e.RowIndex].Cells[27].Value.ToString();
                memberDetail.PhoneNumber3 = dataGridView1.Rows[e.RowIndex].Cells[28].Value.ToString();
                memberDetail.isCountryDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[29].Value);
                memberDetail.isNationalityDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[30].Value);
                memberDetail.isProfessionDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[31].Value);
                memberDetail.isPositionDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[32].Value);
                memberDetail.isEmpStatusDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[33].Value);
                memberDetail.isMarStatusDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[34].Value);
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                countryDetail = new CountryDetailDTO();
                countryDetail.CountryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                countryDetail.CountryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                nationalityDetail = new NationalityDetailDTO();
                nationalityDetail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                nationalityDetail.Nationality = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 3)
            {
                professionDetail = new ProfessionDetailDTO();
                professionDetail.ProfessionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                professionDetail.Profession = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 4)
            {
                positionDetail = new PositionDetailDTO();
                positionDetail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                positionDetail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }            
            else if (cmbDeletedData.SelectedIndex == 5)
            {
                empStatusDetail = new EmploymentStatusDetailDTO();
                empStatusDetail.EmploymentStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                empStatusDetail.EmploymentStatus = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 6)
            {
                marStatusDetail = new MaritalStatusDetailDTO();
                marStatusDetail.MaritalStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                marStatusDetail.MaritalStatus = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 7)
            {
                childDetail = new ChildDetailDTO();
                childDetail.ChildID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                childDetail.Surname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                childDetail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                childDetail.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                childDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                childDetail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                childDetail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                childDetail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                childDetail.NationalityName = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                childDetail.MotherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                childDetail.MothersName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                childDetail.MothersSurname = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                childDetail.MotherNationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                childDetail.MotherNationalityName = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                childDetail.MotherImagePath = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                childDetail.FatherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
                childDetail.FathersName = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                childDetail.FathersSurname = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                childDetail.FatherNationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[18].Value);
                childDetail.FatherNationalityName = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
                childDetail.FatherImagePath = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
                childDetail.isNationalityDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[21].Value);
            }
            else if (cmbDeletedData.SelectedIndex == 8)
            {
                commentDetail = new CommentDetailDTO();
                commentDetail.CommentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                commentDetail.CommentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                commentDetail.MemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                commentDetail.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                commentDetail.Name = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                commentDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                commentDetail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                commentDetail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                commentDetail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                commentDetail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                commentDetail.MonthName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                commentDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                commentDetail.isMemberDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            }
            else if (cmbDeletedData.SelectedIndex == 9)
            {
                deadMemDetail = new DeadMembersDetailDTO();
                deadMemDetail.DeadMemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                deadMemDetail.Surname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                deadMemDetail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                deadMemDetail.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                deadMemDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                deadMemDetail.MembershipDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                deadMemDetail.DeathDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                deadMemDetail.CountryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                deadMemDetail.CountryName = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                deadMemDetail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                deadMemDetail.NationalityName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                deadMemDetail.ProfessionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
                deadMemDetail.ProfessionName = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                deadMemDetail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
                deadMemDetail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                deadMemDetail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
                deadMemDetail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                deadMemDetail.MaritalStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[17].Value);
                deadMemDetail.MaritalStatusName = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                deadMemDetail.isCountryDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[19].Value);
                deadMemDetail.isNationalityDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[20].Value);
                deadMemDetail.isProfessionDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[21].Value);
                deadMemDetail.isPositionDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[22].Value);
                deadMemDetail.isMarStatusDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[23].Value);
            }
            else if (cmbDeletedData.SelectedIndex == 10)
            {
                documentDetail = new DocumentDetailDTO();
                documentDetail.DocumentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                documentDetail.DocumentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                documentDetail.DocumentType = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                documentDetail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                documentDetail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                documentDetail.MonthName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                documentDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                documentDetail.Date = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                documentDetail.DocumentPath = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 11)
            {
                eventImageDetail = new EventImageDetailDTO();
                eventImageDetail.EventImageID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                eventImageDetail.EventID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                eventImageDetail.EventTitle = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                eventImageDetail.EventYear = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                eventImageDetail.Summary = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                eventImageDetail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                eventImageDetail.Counter = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                eventImageDetail.ImageCaption = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                eventImageDetail.isEventDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            }
            else if (cmbDeletedData.SelectedIndex == 12)
            {
                eventDetail = new EventsDetailDTO();
                eventDetail.EventID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                eventDetail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                eventDetail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                eventDetail.MonthName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                eventDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                eventDetail.EventTitle = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                eventDetail.Summary = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                eventDetail.CoverImagePath = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 13)
            {
                genAttendDetail = new GeneralAttendanceDetailDTO();
                genAttendDetail.GeneralAttendanceID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                genAttendDetail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                genAttendDetail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                genAttendDetail.Month = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                genAttendDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                genAttendDetail.TotalMembersPresent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                genAttendDetail.TotalMembersAbsent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                genAttendDetail.TotalDuesPaid = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                genAttendDetail.TotalDuesExpected = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                genAttendDetail.TotalDuesBalance = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                genAttendDetail.Summary = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 14)
            {
                expenditureDetail = new ExpenditureDetailDTO();
                expenditureDetail.ExpenditureID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                expenditureDetail.Summary = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                expenditureDetail.AmountSpent = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                expenditureDetail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                expenditureDetail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                expenditureDetail.Month = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                expenditureDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            else if (cmbDeletedData.SelectedIndex == 15)
            {
                financialRepDetail = new FinancialReportDetailDTO();
                financialRepDetail.FinancialReportID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                financialRepDetail.TotalAmountRaised = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                financialRepDetail.TotalAmountSpent = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                financialRepDetail.Year = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                financialRepDetail.Summary = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (cmbDeletedData.SelectedIndex == 0 || cmbDeletedData.SelectedIndex == -1)
            {
                if (memberDetail.MemberID == 0)
                {
                    MessageBox.Show("Please choose member from the table");
                }
                if (memberDetail.isCountryDeleted)
                {
                    MessageBox.Show("Country was deleted. Get back the country first.");
                }
                else if (memberDetail.isNationalityDeleted)
                {
                    MessageBox.Show("Nationality was deleted. Get back the nationality first.");
                }
                else if (memberDetail.isProfessionDeleted)
                {
                    MessageBox.Show("Profession was deleted. Get back the profession first.");
                }
                else if (memberDetail.isPositionDeleted)
                {
                    MessageBox.Show("Position was deleted. Get back the position first.");
                }
                else if (memberDetail.isEmpStatusDeleted)
                {
                    MessageBox.Show("Employment status was deleted. Get back the employment status first.");
                }
                else if (memberDetail.isMarStatusDeleted)
                {
                    MessageBox.Show("marital status was deleted. Get back the marital status first.");
                }
                else if (bll.GetBack(memberDetail))
                {
                    MessageBox.Show("Member was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Members;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 1)
            {
                if (countryBLL.GetBack(countryDetail))
                {
                    MessageBox.Show("Country was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Countries;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 2)
            {
                if (nationalityBLL.GetBack(nationalityDetail))
                {
                    MessageBox.Show("Nationality was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Nationalities;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 3)
            {
                if (professionBLL.GetBack(professionDetail))
                {
                    MessageBox.Show("Profession was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Professions;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 4)
            {
                if (positionBLL.GetBack(positionDetail))
                {
                    MessageBox.Show("Position was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Positions;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 5)
            {
                if (empStatusBLL.GetBack(empStatusDetail))
                {
                    MessageBox.Show("Employment status was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.EmploymentStatuses;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 6)
            {
                if (marStatusBLL.GetBack(marStatusDetail))
                {
                    MessageBox.Show("Marital status was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.MaritalStatuses;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 7)
            {
                if (childDetail.isNationalityDeleted)
                {
                    MessageBox.Show("Nationality was deleted. Get back the nationality first.");
                }
                else if (childBLL.GetBack(childDetail))
                {
                    MessageBox.Show("Child was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Children;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 8)
            {
                if (commentDetail.isMemberDeleted)
                {
                    MessageBox.Show("Member was deleted. Get back the member first.");
                }
                else if (commentBLL.GetBack(commentDetail))
                {
                    MessageBox.Show("Comment was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Comments;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 9)
            {
                if (deadMemDetail.isCountryDeleted)
                {
                    MessageBox.Show("Country was deleted. Get back the country first.");
                }
                else if (deadMemDetail.isNationalityDeleted)
                {
                    MessageBox.Show("Nationality was deleted. Get back the nationality first.");
                }
                else if (deadMemDetail.isProfessionDeleted)
                {
                    MessageBox.Show("Profession was deleted. Get back the profession first.");
                }
                else if (deadMemDetail.isPositionDeleted)
                {
                    MessageBox.Show("Position was deleted. Get back the position first.");
                }                
                else if (deadMemDetail.isMarStatusDeleted)
                {
                    MessageBox.Show("marital status was deleted. Get back the marital status first.");
                }
                else if (deadMemberBLL.GetBack(deadMemDetail))
                {
                    MessageBox.Show("Dead member's info was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.DeadMembers;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 10)
            {                
                if (documentBLL.GetBack(documentDetail))
                {
                    MessageBox.Show("Document was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Documents;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 11)
            {
                if (eventImageDetail.isEventDeleted)
                {
                    MessageBox.Show("Event was deleted. Get back the event first.");
                }
                else if (eventImageBLL.GetBack(eventImageDetail))
                {
                    MessageBox.Show("Picture was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.EventImages;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 12)
            {                
                if (eventBLL.GetBack(eventDetail))
                {
                    MessageBox.Show("Event was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Events;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 13)
            {
                if (genAttendBLL.GetBack(genAttendDetail))
                {
                    MessageBox.Show("Attendance was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.GeneralAttendance;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 14)
            {
                if (expendutureBLL.GetBack(expenditureDetail))
                {
                    MessageBox.Show("Expenditure was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.Expenditures;
                }
            }
            else if (cmbDeletedData.SelectedIndex == 15)
            {
                if (financialRepBLl.GetBack(financialRepDetail))
                {
                    MessageBox.Show("Financial report was retrieved");
                    dto = bll.Select(true);
                    dataGridView1.DataSource = dto.FinancialReports;
                }
            }
        }
    }
}
