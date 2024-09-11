using APC.AllForms;
using APC.BLL;
using APC.DAL.DAO;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace APC
{
    public partial class FormMembersList : Form
    {
        public FormMembersList()
        {
            InitializeComponent();
        }
        MemberBLL bll = new MemberBLL();
        MemberDTO dto = new MemberDTO();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMembers open = new FormMembers();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Members;
            ClearFilters();
            GetMemberCounts();
        }
        MemberDetailDTO detail = new MemberDetailDTO();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.MemberID == 0)
            {
                MessageBox.Show("Please choose a member from the table");
            }
            else
            {
                FormMembers open = new FormMembers();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new MemberBLL();
                dto = bll.Select();
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
                FormViewMember open = new FormViewMember();
                open.detail = detail;
                open.isView = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                dto = bll.Select();
                dataGridView1.DataSource = dto.Members;
                ClearFilters();
            }            
        }
       
        private void FormMembersList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label6.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            label7.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            label8.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            label9.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelNoOfDivisor.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            labelNoOfFemale.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            labelNoOfMen.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            txtName.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            txtSurname.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbGender.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbNationality.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbPosition.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbProfession.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnView.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSearch.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClear.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();

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
            dataGridView1.Columns[37].Visible = false;
            dataGridView1.Columns[38].Visible = false;
            dataGridView1.Columns[39].Visible = false;
            dataGridView1.Columns[40].Visible = false;
            dataGridView1.Columns[41].Visible = false;
            dataGridView1.Columns[42].Visible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            #endregion
            GetMemberCounts();

            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
        }
        private void GetMemberCounts()
        {
            labelNoOfMen.Text = bll.SelectCountMale().ToString();
            labelNoOfFemale.Text = bll.SelectCountFemale().ToString();
            labelNoOfDivisor.Text = bll.SelectCountDivisor().ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.MemberID == 0)
            {
                MessageBox.Show("Please select a member from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Member was deleted");
                        bll = new MemberBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Members;
                        ClearFilters();                        
                        GetMemberCounts();
                    }
                }
            }
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
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
            detail.NameOfNextOfKin = dataGridView1.Rows[e.RowIndex].Cells[40].Value.ToString();
            detail.RelationshipToKinID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[41].Value);
            detail.RelationshipToKin = dataGridView1.Rows[e.RowIndex].Cells[42].Value.ToString();
        }
    }
}
