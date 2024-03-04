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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace APC.AllForms
{
    public partial class FormContactList : Form
    {
        public FormContactList()
        {
            InitializeComponent();
        }
        MemberBLL bll = new MemberBLL();
        MemberDTO dto = new MemberDTO();
        MemberDetailDTO detail = new MemberDetailDTO();
        private void FormContactList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Members;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Name";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Email";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].HeaderText = "Phone Number";
            dataGridView1.Columns[27].HeaderText = "Phone Number 2";
            dataGridView1.Columns[28].HeaderText = "Phone Number 3";
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
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            List<MemberDetailDTO> list = dto.Members;
            list = list.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            dataGridView1.DataSource = list;
        }

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
            }
        }
        private void ClearFilters() 
        {           
            txtSurname.Clear();
            dto = bll.Select();
            dataGridView1.DataSource = dto.Members;
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
            detail.NameOfNextOfKin = dataGridView1.Rows[e.RowIndex].Cells[40].Value.ToString();
            detail.RelationshipToKinID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[41].Value);
            detail.RelationshipToKin = dataGridView1.Rows[e.RowIndex].Cells[42].Value.ToString();
        }
    }
}
