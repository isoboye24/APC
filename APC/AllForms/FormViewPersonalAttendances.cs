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
        public bool isPresent = false;
        public bool isAbsent = false;
        private void FormViewPersonalAttendances_Load(object sender, EventArgs e)
        {
            dto = bll.Select(detail.MemberID);
            cmbMonth.DataSource = dto.Months;
            General.ComboBoxProps(cmbMonth, "MonthName", "MonthID");

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
                //dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].HeaderText = "Gender";
                dataGridView1.Columns[12].HeaderText = "Att. Status";
                dataGridView1.Columns[13].HeaderText = "Monthly Dues";
                dataGridView1.Columns[14].HeaderText = "Expected Dues";
                dataGridView1.Columns[15].HeaderText = "Balance";
                dataGridView1.Columns[16].Visible = false;
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s present attendance record";
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
                labelTitle.Text = detail.Surname + " " + detail.Name + "'s absent attendance record";
            }
        }
    }
}
