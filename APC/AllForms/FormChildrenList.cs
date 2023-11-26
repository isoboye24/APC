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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC
{
    public partial class FormChildrenList : Form
    {
        public FormChildrenList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormChildren open = new FormChildren();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Children;
            ClearFilters();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormViewChild open = new FormViewChild();
            open.detail = detail;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Children;
            ClearFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormChildren open = new FormChildren();
            open.detail = detail;
            open.isUpdate = true;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            bll = new ChildBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.Children;
            ClearFilters();
        }
        ChildBLL bll = new ChildBLL();
        ChildDTO dto = new ChildDTO();
        ChildDetailDTO detail = new ChildDetailDTO();
        private void FormChildrenList_Load(object sender, EventArgs e)
        {

            dto = bll.Select();
            cmbGender.DataSource = dto.Genders;
            cmbNationality.DataSource = dto.Nationalities;
            General.ComboBoxProps(cmbGender, "GenderName", "GenderID");
            General.ComboBoxProps(cmbNationality, "Nationality", "NationalityID");

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

            labelMaleChildren.Text = bll.SelectAllMaleChildren().ToString();
            labelFemaleChildren.Text = bll.SelectAllFemaleChildren().ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<ChildDetailDTO> list = dto.Children;
            list = list.Where(x => x.Name.Contains(txtName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            List<ChildDetailDTO> list = dto.Children;
            list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtMothersName_TextChanged(object sender, EventArgs e)
        {
            List<ChildDetailDTO> list = dto.Children;
            list = list.Where(x => x.MothersName.Contains(txtMothersName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void txtFathersName_TextChanged(object sender, EventArgs e)
        {
            List<ChildDetailDTO> list = dto.Children;
            list = list.Where(x => x.FathersName.Contains(txtFathersName.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ChildDetailDTO> list = dto.Children;
            if (cmbGender.SelectedIndex != -1)
            {
                list = list.Where(x => x.GenderID == Convert.ToInt32(cmbGender.SelectedValue)).ToList();
            }
            if (cmbNationality.SelectedIndex != -1)
            {
                list = list.Where(x => x.NationalityID == Convert.ToInt32(cmbNationality.SelectedValue)).ToList();
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
            txtFathersName.Clear();
            txtMothersName.Clear();
            cmbGender.SelectedIndex = -1;
            cmbNationality.SelectedIndex = -1;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Children;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ChildID == 0)
            {
                MessageBox.Show("Please select a child from the table");
            }          
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Child was deleted");
                        bll = new ChildBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Children;
                        ClearFilters();
                    }                                       
                }
            }
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            detail = new ChildDetailDTO();
            detail.ChildID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Surname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.Birthday = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detail.ImagePath = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.GenderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            detail.GenderName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            detail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            detail.NationalityName = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            detail.MotherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.MothersName = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detail.MothersSurname = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            detail.MotherNationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.MotherNationalityName = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.MotherImagePath = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            detail.FatherID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
            detail.FathersName = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            detail.FathersSurname = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
            detail.FatherNationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[18].Value);
            detail.FatherNationalityName = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            detail.FatherImagePath = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
        }
    }
}
