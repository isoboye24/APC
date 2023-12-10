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
    public partial class FormViewFinancialReport : Form
    {
        public FormViewFinancialReport()
        {
            InitializeComponent();
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
        private void FormViewFinancialReport_Load(object sender, EventArgs e)
        {
            labelTitle.Text = "Financial Report in " + detail.Year;
            txtSummary.Text = detail.Summary;
            General.ValueCountInDecimal(labelTotalAmountRaised, detail.TotalAmountRaised, 87, 78);
            General.ValueCountInDecimal(labelTotalAmountSpent, detail.TotalAmountSpent, 87, 78);
            General.ValueCountInDecimal(labelTotalBalance, detail.TotalAmountRaised - detail.TotalAmountSpent, 87, 78);
        }
    }
}
