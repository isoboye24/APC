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
    public partial class FormExpenditureList : Form
    {
        public FormExpenditureList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormExpenditure open = new FormExpenditure();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            ClearFilters();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ExpenditureID == 0)
            {
                MessageBox.Show("Please choose an expenditure from the table");
            }
            else
            {
                FormExpenditure open = new FormExpenditure();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }            
        }
        private void btnView_Click(object sender, EventArgs e)
        {            
            if (detail.ExpenditureID == 0)
            {
                MessageBox.Show("Please choose an expenditure from the table");
            }
            else
            {
                FormViewExpenditure open = new FormViewExpenditure();
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                ClearFilters();
            }
        }
        ExpenditureBLL bll = new ExpenditureBLL();
        ExpenditureDTO dto = new ExpenditureDTO();
        ExpenditureDetailDTO detail = new ExpenditureDetailDTO();
        private void FormExpenditureList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

            dataGridView1.DataSource = dto.Expenditures;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Summary";
            dataGridView1.Columns[2].HeaderText = "Amount Spent (€)";
            dataGridView1.Columns[3].HeaderText = "Day";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Month";
            dataGridView1.Columns[6].HeaderText = "Year";
            dataGridView1.Columns[7].Visible = false;
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
        }

        private void ClearFilters()
        {
            txtYear.Clear();
            cmbMonth.SelectedIndex = -1;
            bll = new ExpenditureBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.Expenditures;
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<ExpenditureDetailDTO> list = dto.Expenditures;
            list = list.Where(x => x.Year.Contains(txtYear.Text)).ToList();
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ExpenditureDetailDTO> list = dto.Expenditures;
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new ExpenditureDetailDTO();
            detail.ExpenditureID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.Summary = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.AmountSpent = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Day = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detail.MonthID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.Month = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            detail.Year = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            detail.ExpenditureDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ExpenditureID ==0)
            {
                MessageBox.Show("Please select an expenditure from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Expenditure was deleted");
                        ClearFilters();
                    }
                }
            }
        }
    }
}
