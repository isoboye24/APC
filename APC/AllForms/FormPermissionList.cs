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
using System.Windows.Input;
using System.Windows.Interop;

namespace APC
{
    public partial class FormPermissionList : Form
    {
        public FormPermissionList()
        {
            InitializeComponent();
        }
        PermissionBLL bll = new PermissionBLL();
        PermissionDTO dto = new PermissionDTO();
        MemberDetailDTO detail = new MemberDetailDTO();
        MemberBLL memberBLL = new MemberBLL();
        private void FormPermissionList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbPermission.DataSource = dto.Permissions;
            General.ComboBoxProps(cmbPermission, "Permission", "PermissionID");
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
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
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].HeaderText = "Position";
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].HeaderText = "Access Level";
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
            #endregion
        }
        private void FillDataGrid()
        {
            bll = new PermissionBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.Members;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MemberDetailDTO> list = dto.Members;
            if (cmbPermission.SelectedIndex != -1)
            {
                list = list.Where(x => x.PermissionID == Convert.ToInt32(cmbPermission.SelectedValue)).ToList();
            }            
            dataGridView1.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (memberBLL.DeletePermission(detail))
                {

                }
                MessageBox.Show("Member was deleted");
                FillDataGrid();
                cmbPermission.SelectedIndex = -1;
            }
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbPermission.SelectedIndex = -1;
            FillDataGrid();
        }
    }
}
