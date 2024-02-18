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
using System.Windows.Media;

namespace APC.AllForms
{
    public partial class FormViewMeetingsSummary : Form
    {
        public FormViewMeetingsSummary()
        {
            InitializeComponent();
        }
        public GeneralAttendanceDetailDTO detail = new GeneralAttendanceDetailDTO();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormViewMeetingsSummary_Load(object sender, EventArgs e)
        {
            this.Text = "Summary of meeting on " + detail.Day + "." + detail.MonthID + "." + detail.Year;
            txtSummary.Text = detail.Summary;
            string[] words = detail.Summary.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            labelWordsCount.Text = words.Length.ToString();
        }
    }
}
