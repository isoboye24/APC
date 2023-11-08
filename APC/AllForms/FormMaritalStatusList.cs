using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.BLL;
using APC.DAL.DTO;

namespace APC
{
    public partial class FormMaritalStatusList : Form
    {
        public FormMaritalStatusList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMaritalStatus open = new FormMaritalStatus();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.MaritalStatuses;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.MaritalStatusID == 0)
            {
                MessageBox.Show("Please select a marital status from the table");
            }
            else
            {
                FormMaritalStatus open = new FormMaritalStatus();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new MaritalStatusBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.MaritalStatuses;
            }            
        }
        MaritalStatusBLL bll = new MaritalStatusBLL();
        MaritalStatusDTO dto = new MaritalStatusDTO();        
        private void FormMaritalStatusList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.MaritalStatuses;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Marital Status Name";
        }

        private void txtMaritalStatus_TextChanged(object sender, EventArgs e)
        {
            List<MaritalStatusDetailDTO> list = dto.MaritalStatuses;
            list = list.Where(x => x.MaritalStatus.Contains(txtMaritalStatus.Text)).ToList();
            dataGridView1.DataSource = list;
        }
        MaritalStatusDetailDTO detail = new MaritalStatusDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new MaritalStatusDetailDTO();
            detail.MaritalStatusID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.MaritalStatus = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.MaritalStatusID == 0)
            {
                MessageBox.Show("Please select a marital status from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        bll = new MaritalStatusBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.MaritalStatuses;
                        txtMaritalStatus.Clear();
                    }
                }
            }
        }
    }
}
