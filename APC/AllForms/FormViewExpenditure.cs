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
    public partial class FormViewExpenditure : Form
    {
        public FormViewExpenditure()
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
        public ExpenditureDetailDTO detail = new ExpenditureDetailDTO();
        private void FormViewExpenditure_Load(object sender, EventArgs e)
        {
            txtAmountSpent.Text = detail.AmountSpent.ToString();
            txtSummary.Text = detail.Summary;
            txtDate.Text = detail.Day + "/" + detail.MonthID +"/"+ detail.Year;
            labelTitle.Text = $"Expenditure on {txtDate.Text}";
        }
    }
}
