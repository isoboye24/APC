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
    public partial class FormExpenditure : Form
    {
        public FormExpenditure()
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
        ExpenditureBLL bll = new ExpenditureBLL();
        public ExpenditureDetailDTO detail = new ExpenditureDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (txtAmountSpent.Text.Trim()=="")
            {
                MessageBox.Show("Add amount");
            }
            else if(txtSummary.Text.Trim() == "")
            {
                MessageBox.Show("Add summary");
            }
            else
            {
                if (!isUpdate)
                {
                    ExpenditureDetailDTO expenditure = new ExpenditureDetailDTO();
                    expenditure.AmountSpent = Convert.ToDecimal(txtAmountSpent.Text);
                    expenditure.Summary = txtSummary.Text;
                    expenditure.Day = dateTimePickerExpDate.Value.Day;
                    expenditure.MonthID = dateTimePickerExpDate.Value.Month;
                    expenditure.Year = dateTimePickerExpDate.Value.Year.ToString();
                    if (bll.Insert(expenditure))
                    {
                        MessageBox.Show("Expenditure was added");
                        txtAmountSpent.Clear();
                        txtSummary.Clear();
                        dateTimePickerExpDate.Value = DateTime.Today;
                    }
                }
                else if(isUpdate)
                {
                    
                    if (detail.AmountSpent == Convert.ToDecimal(txtAmountSpent.Text) && detail.Summary == txtSummary.Text
                        && detail.Day == Convert.ToInt32(dateTimePickerExpDate.Value.Day) && detail.MonthID == Convert.ToInt32(dateTimePickerExpDate.Value.Month)
                        && detail.Year == dateTimePickerExpDate.Value.Year.ToString())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.AmountSpent = Convert.ToDecimal(txtAmountSpent.Text);
                        detail.Summary = txtSummary.Text;
                        detail.Day = dateTimePickerExpDate.Value.Day;
                        detail.MonthID = dateTimePickerExpDate.Value.Month;
                        detail.Year = dateTimePickerExpDate.Value.Year.ToString();
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Expenditure was updated");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void txtAmountSpent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void FormExpenditure_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtAmountSpent.Text = detail.AmountSpent.ToString();
                txtSummary.Text = detail.Summary;
                try
                {
                    string dateValue = detail.Day + "/" + detail.MonthID + "/" + detail.Year;
                    dateTimePickerExpDate.Value = DateTime.Parse(dateValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid date format. Just click on Ok to continue.");
                }                
            }
        }
    }
}
