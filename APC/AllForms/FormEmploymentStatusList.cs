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

namespace APC
{
    public partial class FormEmploymentStatusList : Form
    {
        public FormEmploymentStatusList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEmploymentStatus open = new FormEmploymentStatus();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.EmploymentStatuses;
        }
        EmploymentStatusDetailDTO detail = new EmploymentStatusDetailDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormEmploymentStatus open = new FormEmploymentStatus();
            open.detail = detail;
            open.isUpdate = true;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            bll = new EmploymentStatusBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.EmploymentStatuses;
        }
        EmploymentStatusBLL bll = new EmploymentStatusBLL();
        EmploymentStatusDTO dto = new EmploymentStatusDTO();
        private void FormEmploymentStatusList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtEmpStatus.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();
            dataGridView1.DataSource = dto.EmploymentStatuses;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Employment Status";
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
        }

        private void txtEmpStatus_TextChanged(object sender, EventArgs e)
        {
            List<EmploymentStatusDetailDTO> list = dto.EmploymentStatuses;
            list = list.Where(x => x.EmploymentStatus.Contains(txtEmpStatus.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new EmploymentStatusDetailDTO();
            detail.EmploymentStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.EmploymentStatus = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.EmploymentStatusID==0)
            {
                MessageBox.Show("Please select an employment status from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Employment status was deleted");
                        bll = new EmploymentStatusBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.EmploymentStatuses;
                        txtEmpStatus.Clear();
                    }
                }
            }
        }
    }
}
