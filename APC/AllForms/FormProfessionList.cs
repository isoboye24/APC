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
    public partial class FormProfessionList : Form
    {
        public FormProfessionList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProfession open = new FormProfession();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Professions;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormProfession open = new FormProfession();
            open.detail = detail;
            open.isUpdate = true;
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            bll = new ProfessionBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.Professions;
        }
        ProfessionBLL bll = new ProfessionBLL();
        ProfessionDTO dto = new ProfessionDTO();
        private void FormProfessionList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtProfession.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();
            dataGridView1.DataSource = dto.Professions;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Profession Name";
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

        private void txtProfession_TextChanged(object sender, EventArgs e)
        {
            List<ProfessionDetailDTO> list = dto.Professions;
            list = list.Where(x => x.Profession.Contains(txtProfession.Text)).ToList();
            dataGridView1.DataSource = list;
        }
        ProfessionDetailDTO detail = new ProfessionDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new ProfessionDetailDTO();
            detail.ProfessionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Profession = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ProfessionID == 0)
            {
                MessageBox.Show("Please select a profession from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Profession was deleted");
                        bll = new ProfessionBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Professions;
                        txtProfession.Clear();
                    }
                }
            }
        }
    }
}
