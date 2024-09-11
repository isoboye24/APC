using APC.AllForms;
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
    public partial class FormCountryList : Form
    {
        public FormCountryList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCountry open = new FormCountry();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Countries;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.CountryID == 0)
            {
                MessageBox.Show("Please select a country from the table");
            }
            else
            {
                FormCountry open = new FormCountry();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                bll = new CountryBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Countries;
            }            
        }
        CountryBLL bll = new CountryBLL();
        CountryDTO dto = new CountryDTO();
        CountryDetailDTO detail = new CountryDetailDTO();
        
        private void FormCountryList_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtCountry.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            btnAdd.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnUpdate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDelete.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dto = bll.Select();
            dataGridView1.DataSource = dto.Countries;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Country Name";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            }
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
        }       

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            List<CountryDetailDTO> list = dto.Countries;
            list = list.Where(x => x.CountryName.Contains(txtCountry.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new CountryDetailDTO();
            detail.CountryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.CountryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.CountryID == 0)
            {
                MessageBox.Show("Please select a country from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Country was deleted");
                        bll = new CountryBLL();
                        dto = bll.Select();
                        dataGridView1.DataSource = dto.Countries;
                        txtCountry.Clear();
                    }
                }
            }
        }
    }
}
