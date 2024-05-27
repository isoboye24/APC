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
    public partial class FormNationalityList : Form
    {
        public FormNationalityList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNationality open = new FormNationality();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Nationalities;
        }
        NationalityDetailDTO detail = new NationalityDetailDTO();
        DualNationalityDetailDTO dualNatDetail = new DualNationalityDetailDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.NationalityID == 0)
            {
                MessageBox.Show("Please choose a nationality from the table");
            }
            else
            {
                FormNationality open = new FormNationality();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new NationalityBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Nationalities;
            }            
        }
        NationalityBLL bll = new NationalityBLL();
        NationalityDTO dto = new NationalityDTO();
        DualNationalityBLL dualNatBLL = new DualNationalityBLL();
        private void FormNationalityList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtNationality.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();
            dataGridView1.DataSource = dto.Nationalities;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nationality Name";
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

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            List<NationalityDetailDTO> list = dto.Nationalities;
            list = list.Where(x => x.Nationality.Contains(txtNationality.Text)).ToList();
            dataGridView1.DataSource = list;
        }        

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            detail = new NationalityDetailDTO();
            detail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Nationality = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dualNatDetail.DualNationalityID = detail.NationalityID;
            if (detail.NationalityID==0 || dualNatDetail.DualNationalityID==0)
            {
                MessageBox.Show("Please choose a nationality from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail) && dualNatBLL.Delete(dualNatDetail))
                    {
                        MessageBox.Show("Nationality was deleted");
                        bll = new NationalityBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Nationalities;
                        txtNationality.Clear();
                    }
                }
            }
        }
    }
}
