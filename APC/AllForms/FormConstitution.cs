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
    public partial class FormConstitution : Form
    {
        public FormConstitution()
        {
            InitializeComponent();
        }

        public ConstitutionDetailDTO detail = new ConstitutionDetailDTO();
        ConstitutionBLL bll = new ConstitutionBLL();
        public bool isUpdate = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConstitution_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtAmount.Text = detail.Fine.ToString();
                txtSection.Text = detail.Section;
                txtConstitution.Text = detail.ConstitutionText;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Amount is empty.");
            }
            else if (txtSection.Text.Trim() == "")
            {
                MessageBox.Show("Title is empty.");
            }
            else if (txtConstitution.Text.Trim() == "")
            {
                MessageBox.Show("Constitution is empty.");
            }
            else
            {
                if (!isUpdate)
                {
                    ConstitutionDetailDTO constitution = new ConstitutionDetailDTO();
                    constitution.ConstitutionText = txtConstitution.Text.Trim();
                    constitution.Fine = Convert.ToInt32(txtAmount.Text.Trim());
                    constitution.Section = txtSection.Text.Trim();
                    if (bll.Insert(constitution))
                    {
                        MessageBox.Show("Constitution is added.");
                        txtAmount.Clear();
                        txtConstitution.Clear();
                        txtSection.Clear();
                    }
                }
                else if (isUpdate)
                {
                    if (detail.ConstitutionText == txtConstitution.Text.Trim() 
                        && detail.Section == txtSection.Text.Trim()
                        && detail.Fine == Convert.ToDecimal(txtAmount.Text.Trim()))
                    {
                        MessageBox.Show("There is no change!");
                    }
                    else
                    {
                        detail.ConstitutionText = txtConstitution.Text.Trim();
                        detail.Fine = Convert.ToDecimal(txtAmount.Text.Trim());
                        detail.Section = txtSection.Text.Trim();
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Constitution is updated!");
                            this.Close();
                        }
                    }
                }
            }
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

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
