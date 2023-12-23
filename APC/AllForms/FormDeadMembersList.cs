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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDeadMembers open = new FormDeadMembers();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.DeadMembers;
            ClearFilters();
            GetMemberCounts();
        }
        DeadMembersDetailDTO detail = new DeadMembersDetailDTO();
        DeadMembersBLL bll = new DeadMembersBLL();
        DeadMembersDTO dto = new DeadMembersDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormDeadMembers open = new FormDeadMembers();
            open.isUpdate = true;
            open.detail = detail;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            bll = new DeadMembersBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.DeadMembers;
            ClearFilters();
            GetMemberCounts();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (detail.DeadMemberID == 0)
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
                dto = bll.Select();
                dataGridView1.DataSource = dto.DeadMembers;
                ClearFilters();
                GetMemberCounts();
            }
        }
        private void FormDeadMembersList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbGender.DataSource = dto.Genders;
            General.ComboBoxProps(cmbGender, "GenderName", "genderID");

            cmbProfession.DataSource = dto.Professions;
            General.ComboBoxProps(cmbProfession, "Profession", "professionID");

            cmbPosition.DataSource = dto.Positions;
            General.ComboBoxProps(cmbPosition, "PositionName", "positionID");

            cmbNationality.DataSource = dto.Nationalities;
            General.ComboBoxProps(cmbNationality, "Nationality", "NationalityID");

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

            GetMemberCounts();
        }
        private void GetMemberCounts()
        {
            labelNoOfMen.Text = bll.SelectCountMale().ToString();
            labelNoOfFemale.Text = bll.SelectCountFemale().ToString();
            labelNoOfDivisor.Text = bll.SelectCountDivisor().ToString();
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new DeadMembersDetailDTO();
            detail.DeadMemberID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Surname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.MembershipDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.DeathDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            detail.CountryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.CountryName = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            detail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.NationalityName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.ProfessionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detail.ProfessionName = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            detail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
            detail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            detail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
            detail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            detail.MaritalStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[17].Value);
            detail.MaritalStatusName = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<DeadMembersDetailDTO> list = dto.DeadMembers;
            list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            List<DeadMembersDetailDTO> list = dto.DeadMembers;
            list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DeadMembersDetailDTO> list = dto.DeadMembers;
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
            dataGridView1.DataSource = dto.DeadMembers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.DeadMemberID == 0)
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
                        bll = new DeadMembersBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.DeadMembers;
                        ClearFilters();
                        GetMemberCounts();
                    }
                }
            }
        }
    }
}
