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
    public partial class FormFinancialReport : Form
    {
        public FormFinancialReport()
        {
            InitializeComponent();
        }

        private void FormFinancialReport_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public FinancialReportDetailDTO detail = new FinancialReportDetailDTO();
        public bool isUpdate = false;
        private void FormFinancialReport_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtYear.Text = detail.Year;
                txtSummary.Text = detail.Summary;
            }
        }
        FinancialReportBLL bll = new FinancialReportBLL();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Trim() == "")
            {
                MessageBox.Show("Please enter year");
            }
            else
            {
                if (!isUpdate)
                {
                    FinancialReportDetailDTO financialReport = new FinancialReportDetailDTO();
                    financialReport.Year = txtYear.Text;
                    financialReport.Summary = txtSummary.Text;
                    financialReport.TotalAmountRaised = 0;
                    financialReport.TotalAmountSpent = 0;
                    if (bll.Insert(financialReport))
                    {
                        MessageBox.Show("Financial Report is created");
                        txtSummary.Clear();
                        txtYear.Clear();
                    }
                }
                else if (isUpdate)
                {
                    if (detail.Summary == txtSummary.Text.Trim() && detail.Year == txtYear.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.Year = txtYear.Text;
                        detail.Summary = txtSummary.Text;
                        detail.TotalAmountRaised = detail.TotalAmountRaised;
                        detail.TotalAmountSpent = detail.TotalAmountSpent;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Financial report was updated");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
