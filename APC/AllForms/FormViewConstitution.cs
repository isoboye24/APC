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
    public partial class FormViewConstitution : Form
    {
        public FormViewConstitution()
        {
            InitializeComponent();
        }
        public ConstitutionDetailDTO detail = new ConstitutionDetailDTO();

        private void FormViewConstitution_Load(object sender, EventArgs e)
        {
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelFine.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelSection.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnClose.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            txtConstitution.Text = detail.ConstitutionText;
            labelFine.Text = "€ " + detail.Fine;
            labelSection.Text = detail.Section;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
