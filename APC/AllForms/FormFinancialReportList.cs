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
    public partial class FormFinancialReportList : Form
    {
        public FormFinancialReportList()
        {
            InitializeComponent();
        }

        FinancialReportBLL bll = new FinancialReportBLL();
        FinancialReportDTO dto = new FinancialReportDTO();
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormFinancialReport open = new FormFinancialReport();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
            FillDataGrid();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (detail.FinancialReportID == 0)
            {
                MessageBox.Show("Please choose a Report from the table");
            }
            else
            {
                FormFinancialReport open = new FormFinancialReport();
                open.detail = detail;
                open.isUpdate = true;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                FillDataGrid();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (detail.FinancialReportID == 0)
            {
                MessageBox.Show("Please choose a Report from the table");
            }
            else
            {
                FormViewFinancialReport open = new FormViewFinancialReport();
                open.detail = detail;
                this.Hide();
                open.ShowDialog();
                this.Visible = true;
                FillDataGrid();
            }
        }

        private void FillDataGrid()
        {
            bll = new FinancialReportBLL();
            dto = bll.Select();
            dataGridView1.DataSource = dto.FinancialReports;
        }
        private void FormFinancialReportList_Load_1(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.FinancialReports;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Total Amount Raised";
            dataGridView1.Columns[2].HeaderText = "Total Amount Spent";
            dataGridView1.Columns[3].HeaderText = "Year";
            dataGridView1.Columns[4].Visible = false;

            General.ValueCountInDecimal(labelTotalAmountRaised, bll.SelectTotalRaisedAmount(), 148, 70);
            General.ValueCountInDecimal(labelTotalAmountSpent, bll.SelectTotalSpentAmount(), 148, 70);
            General.ValueCountInDecimal(labelTotalBalance, bll.SelectTotalRaisedAmount() - bll.SelectTotalSpentAmount(), 148, 70);
            if (LoginInfo.AccessLevel != 4)
            {
                btnDelete.Hide();
            }
        }
        FinancialReportDetailDTO detail = new FinancialReportDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new FinancialReportDetailDTO();
            detail.FinancialReportID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.TotalAmountRaised = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.TotalAmountSpent = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Year = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Summary = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            List<FinancialReportDetailDTO> list = dto.FinancialReports;
            list = list.Where(x => x.Year.Contains(txtYear.Text.Trim())).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.FinancialReportID == 0)
            {
                MessageBox.Show("Please choose a Report from the table");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?","Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Financial report was deleted");
                        FillDataGrid();
                    }
                }
                
            }
        }
    }
}
