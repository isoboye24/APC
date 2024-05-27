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
    public partial class FormPositionList : Form
    {
        public FormPositionList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormPosition open = new FormPosition();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Positions;
        }       
        PositionDTO dto = new PositionDTO();
        PositionBLL bll = new PositionBLL();
        private void FormPositionList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtPosition.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();
            dataGridView1.DataSource = dto.Positions;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Position Name";
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

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            List<PositionDetailDTO> list = dto.Positions;
            list = list.Where(x => x.PositionName.Contains(txtPosition.Text)).ToList();
            dataGridView1.DataSource = list;
        }
        PositionDetailDTO detail = new PositionDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new PositionDetailDTO();
            detail.PositionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.PositionName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.PositionID == 0)
            {
                MessageBox.Show("Please select a position from the table");
            }
            else
            {
                FormPosition open = new FormPosition();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new PositionBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Positions;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.PositionID == 0)
            {
                MessageBox.Show("Please select a position from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Position was deleted");
                        bll = new PositionBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Positions;
                        txtPosition.Clear();
                    }
                }
            }
        }
    }
}
