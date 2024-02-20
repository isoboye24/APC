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
    public partial class FormDeadMembersList : Form
    {
        public FormDeadMembersList()
        {
            InitializeComponent();
        }

        MemberDetailDTO detail = new MemberDetailDTO();
        MemberBLL bll = new MemberBLL();
        MemberDTO dto = new MemberDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.MemberID == 0)
            {
                MessageBox.Show("Please choose a member from the table.");
            }
            else
            {
                FormMembers open = new FormMembers();
                open.isUpdate = true;
                open.isUpdateDeadMember = true;
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new MemberBLL();
                dto = bll.SelectDeadMembers();
                dataGridView1.DataSource = dto.Members;
                ClearFilters();
                GetMemberCounts();
            }            
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (detail.MemberID == 0)
            {
                MessageBox.Show("Please choose a member from the table");
            }
            else
            {
                FormViewDeadMember open = new FormViewDeadMember();
                open.detail = detail;
                open.isView = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                dto = bll.SelectDeadMembers();
                dataGridView1.DataSource = dto.Members;
                ClearFilters();
                GetMemberCounts();
            }
        }
        private void FormDeadMembersList_Load(object sender, EventArgs e)
        {
            dto = bll.SelectDeadMembers();
            cmbGender.DataSource = dto.Genders;
            General.ComboBoxProps(cmbGender, "GenderName", "genderID");

            cmbProfession.DataSource = dto.Professions;
            General.ComboBoxProps(cmbProfession, "Profession", "professionID");

            cmbPosition.DataSource = dto.Positions;
            General.ComboBoxProps(cmbPosition, "PositionName", "positionID");

            cmbNationality.DataSource = dto.Nationalities;
            General.ComboBoxProps(cmbNationality, "Nationality", "NationalityID");
            #region
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
            dataGridView1.Columns[19].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            dataGridView1.Columns[35].Visible = false;
            dataGridView1.Columns[36].Visible = false;
            dataGridView1.Columns[37].HeaderText = "Died on";
            dataGridView1.Columns[37].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[38].HeaderText = "Aged";
            dataGridView1.Columns[38].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[39].Visible = false;
            //dataGridView1.Columns[39].Visible = false;
            //dataGridView1.Columns[40].Visible = false;
            //dataGridView1.Columns[41].Visible = false;
            #endregion
            GetMemberCounts();            
        }
        private void GetMemberCounts()
        {
            labelNoOfMen.Text = bll.SelectCountDeadMale().ToString();
            labelNoOfFemale.Text = bll.SelectCountDeadFemale().ToString();
            labelNoOfDivisor.Text = bll.SelectCountDeadDivisor().ToString();
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new MemberDetailDTO();
            detail.MemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Username = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.Password = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            detail.EmailAddress = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            detail.HouseAddress = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            detail.MembershipDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.CountryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
            detail.CountryName = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            detail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.NationalityName = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.ProfessionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detail.ProfessionName = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            detail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[16].Value);
            detail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            detail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[18].Value);
            detail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            detail.EmploymentStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[20].Value);
            detail.EmploymentStatusName = dataGridView1.Rows[e.RowIndex].Cells[21].Value.ToString();
            detail.MaritalStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[22].Value);
            detail.MaritalStatusName = dataGridView1.Rows[e.RowIndex].Cells[23].Value.ToString();
            detail.PermissionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[24].Value);
            detail.PermissionName = dataGridView1.Rows[e.RowIndex].Cells[25].Value.ToString();
            detail.PhoneNumber = dataGridView1.Rows[e.RowIndex].Cells[26].Value.ToString();
            detail.PhoneNumber2 = dataGridView1.Rows[e.RowIndex].Cells[27].Value.ToString();
            detail.PhoneNumber3 = dataGridView1.Rows[e.RowIndex].Cells[28].Value.ToString();
            detail.isCountryDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[29].Value);
            detail.isNationalityDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[30].Value);
            detail.isProfessionDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[31].Value);
            detail.isPositionDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[32].Value);
            detail.isEmpStatusDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[33].Value);
            detail.isMarStatusDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[34].Value);
            detail.MembershipStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[35].Value);
            detail.MembershipStatus = dataGridView1.Rows[e.RowIndex].Cells[36].Value.ToString();
            detail.DeadDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[37].Value);
            detail.DeadAge = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[38].Value);
            detail.LGA = dataGridView1.Rows[e.RowIndex].Cells[39].Value.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<MemberDetailDTO> list = dto.Members;
            list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            List<MemberDetailDTO> list = dto.Members;
            list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MemberDetailDTO> list = dto.Members;
            if (cmbNationality.SelectedIndex != -1)
            {
                list = list.Where(x => x.NationalityID == Convert.ToInt32(cmbNationality.SelectedValue)).ToList();
            }
            if (cmbGender.SelectedIndex != -1)
            {
                list = list.Where(x => x.GenderID == Convert.ToInt32(cmbGender.SelectedValue)).ToList();
            }
            if (cmbPosition.SelectedIndex != -1)
            {
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            }
            if (cmbProfession.SelectedIndex != -1)
            {
                list = list.Where(x => x.ProfessionID == Convert.ToInt32(cmbProfession.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
        private void ClearFilters()
        {
            txtName.Clear();
            txtSurname.Clear();
            cmbNationality.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            cmbProfession.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Members;
        }
    }
}
