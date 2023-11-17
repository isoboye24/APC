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
        private void btnUpdate_Click(object sender, EventArgs e)
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
        NationalityBLL bll = new NationalityBLL();
        NationalityDTO dto = new NationalityDTO();
        private void FormNationalityList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Nationalities;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nationality Name";
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            List<NationalityDetailDTO> list = dto.Nationalities;
            list = list.Where(x => x.Nationality.Contains(txtNationality.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new NationalityDetailDTO();
            detail.NationalityID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Nationality = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
