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
using System.Xml.Linq;

namespace APC.AllForms
{
    public partial class FormViewPersonalAttendances : Form
    {
        public FormViewPersonalAttendances()
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
        PersonalAttendanceBLL bll = new PersonalAttendanceBLL();
        PersonalAttendanceDTO dto = new PersonalAttendanceDTO();
        public MemberDetailDTO detail = new MemberDetailDTO();
        MemberBLL memberBLL = new MemberBLL();
        public bool isPresent = false;
        public bool isAbsent = false;
        public bool isAmountContributed = false;
        public bool isAmountExpected = false;
        public bool isPersonalBalance = false;
        decimal amountContributed = 0;
        decimal amountExpected = 0;
        decimal Balance = 0;
        private void FormViewPersonalAttendances_Load(object sender, EventArgs e)
        {
            labelTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label5.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rbEqualAttend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            rbLessAttend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            rbMoreAttend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            txtAmount.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbMonth.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbYear.Font = new Font("Segoe UI", 12, FontStyle.Regular);           
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelTotalAmount.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            labelTotalName.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            dto = bll.Select(detail.MemberID);
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");
            cmbYear.DataSource = dto.Years;
            cmbYear.SelectedIndex = -1;
            tableLayoutPanelChangingAmount.Hide();
            tableLayoutPanelTotal.Hide();

            amountContributed = memberBLL.GetAmountContributed(detail.MemberID);            
            amountExpected = memberBLL.GetAmountExpected();
            Balance = amountExpected - amountContributed;

            if (isPresent)
            {
                dataGridView1.DataSource = dto.PresentMember;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.Columns[5].HeaderText = "Year";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Gender";
                dataGridView1.Columns[12].HeaderText = "Att. Status";
                dataGridView1.Columns[13].HeaderText = "Monthly Dues";
                dataGridView1.Columns[14].HeaderText = "Expected Dues";
                dataGridView1.Columns[15].HeaderText = "Balance";
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s present attendance record";
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfile.ImageLocation = imagePath;
            }
            if (isAbsent)
            {
                dataGridView1.DataSource = dto.AbsentMember;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.Columns[5].HeaderText = "Year";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Gender";
                dataGridView1.Columns[12].HeaderText = "Att. Status";
                dataGridView1.Columns[13].HeaderText = "Monthly Dues";
                dataGridView1.Columns[14].HeaderText = "Expected Dues";
                dataGridView1.Columns[15].HeaderText = "Balance";
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s absent attendance record";
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfile.ImageLocation = imagePath;
            }
            if (isAmountContributed)
            {
                dataGridView1.DataSource = dto.AmountsContributed;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.Columns[5].HeaderText = "Year";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Gender";
                dataGridView1.Columns[12].HeaderText = "Att. Status";
                dataGridView1.Columns[13].HeaderText = "Monthly Dues";
                dataGridView1.Columns[14].HeaderText = "Expected Dues";
                dataGridView1.Columns[15].HeaderText = "Balance";
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s contributed amount record";
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfile.ImageLocation = imagePath;
                tableLayoutPanelChangingAmount.Visible = true;
                tableLayoutPanelTotal.Visible = true;
                labelTotalAmount.Text = "€" + amountContributed;
                labelTotalName.Text = "Total Amt. Contributed";
            }
            if (isAmountExpected)
            {
                dataGridView1.DataSource = dto.AmountExpected;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.Columns[5].HeaderText = "Year";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Gender";
                dataGridView1.Columns[12].HeaderText = "Att. Status";
                dataGridView1.Columns[13].HeaderText = "Monthly Dues";
                dataGridView1.Columns[14].HeaderText = "Expected Dues";
                dataGridView1.Columns[15].HeaderText = "Balance";
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s expected amount record";
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfile.ImageLocation = imagePath;
                tableLayoutPanelTotal.Visible = true;
                labelTotalAmount.Text = "€" + amountExpected + ".00";
                labelTotalName.Text = "Total Amt. Expected";
            }
            if (isPersonalBalance)
            {
                dataGridView1.DataSource = dto.AmountsBalance;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.Columns[5].HeaderText = "Year";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Gender";
                dataGridView1.Columns[12].HeaderText = "Att. Status";
                dataGridView1.Columns[13].HeaderText = "Monthly Dues";
                dataGridView1.Columns[14].HeaderText = "Expected Dues";
                dataGridView1.Columns[15].HeaderText = "Balance";
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 12);
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                }
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s balance amount record";
                string imagePath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                picProfile.ImageLocation = imagePath;
                tableLayoutPanelChangingAmount.Visible = true;
                tableLayoutPanelTotal.Visible = true;
                labelTotalAmount.Text = "€" + Balance;
                labelTotalName.Text = "Total Amt. Balance";
            }
        }

        private void ClearFilters()
        {
            cmbYear.DataSource = dto.Years;
            cmbYear.SelectedIndex = -1;
            cmbMonth.DataSource = dto.Months;
            cmbMonth.SelectedIndex = -1;
            txtAmount.Clear();
            rbEqualAttend.Checked = false;
            rbLessAttend.Checked = false;
            rbMoreAttend.Checked = false;
            dto = bll.Select(detail.MemberID);
            if (isPresent)
            {
                dataGridView1.DataSource = dto.PresentMember;
            }
            else if (isAbsent)
            {
                dataGridView1.DataSource = dto.AbsentMember;
            }
            else if (isAmountContributed)
            {
                dataGridView1.DataSource = dto.AmountsContributed;
            }
            else if (isAmountExpected)
            {
                dataGridView1.DataSource = dto.AmountExpected;
            }
            else if (isPersonalBalance)
            {
                dataGridView1.DataSource = dto.AmountsBalance;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dto = bll.Select(detail.MemberID);
            List<PersonalAttendanceDetailDTO> list = dto.PresentMember;
            if (cmbMonth.SelectedIndex != -1 && cmbYear.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue) && x.Year.Contains(cmbYear.SelectedValue.ToString())).ToList();
            }
            if (cmbMonth.SelectedIndex != -1)
            {
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            }
            if (cmbYear.SelectedIndex != -1)
            {
                list = list.Where(x => x.Year.Contains(cmbYear.SelectedValue.ToString())).ToList();
            }
            if (txtAmount.Text.Trim() != "")
            {
                if (isAmountContributed)
                {
                    if (rbLessAttend.Checked)
                    {
                        list = list.Where(x => x.MonthlyDue < Convert.ToDecimal(txtAmount.Text.Trim())).ToList();
                    }
                    else if (rbEqualAttend.Checked)
                    {
                        list = list.Where(x => x.MonthlyDue == Convert.ToDecimal(txtAmount.Text.Trim())).ToList();
                    }
                    else if (rbMoreAttend.Checked)
                    {
                        list = list.Where(x => x.MonthlyDue > Convert.ToDecimal(txtAmount.Text.Trim())).ToList();
                    }
                    else
                    {
                        MessageBox.Show("There is no result for amount contributed search");
                    }
                }
                if (isPersonalBalance)
                {
                    if (rbLessAttend.Checked)
                    {
                        list = list.Where(x => x.Balance < Convert.ToDecimal(txtAmount.Text.Trim())).ToList();
                    }
                    else if (rbEqualAttend.Checked)
                    {
                        list = list.Where(x => x.Balance == Convert.ToDecimal(txtAmount.Text.Trim())).ToList();
                    }
                    else if (rbMoreAttend.Checked)
                    {
                        list = list.Where(x => x.Balance > Convert.ToDecimal(txtAmount.Text.Trim())).ToList();
                    }
                    else
                    {
                        MessageBox.Show("There is no result for amount contributed search");
                    }
                }
            }
            dataGridView1.DataSource = list;
        }

        private void tableLayoutPanelChangingAmount_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
