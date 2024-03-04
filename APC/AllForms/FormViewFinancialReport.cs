using APC.BLL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
       
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            labelTotalAmountRaised.Text = detail.TotalAmountRaised.ToString();
            labelTotalAmountSpent.Text = detail.TotalAmountSpent.ToString();
            labelTotalBalance.Text = (detail.TotalAmountRaised - detail.TotalAmountSpent).ToString();
        }        
    }
}
