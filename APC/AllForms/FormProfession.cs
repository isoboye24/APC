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
    public partial class FormProfession : Form
    {
        public FormProfession()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ProfessionBLL bll = new ProfessionBLL();
        public ProfessionDetailDTO detail = new ProfessionDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProfession.Text.Trim()=="")
            {
                MessageBox.Show("Profession is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    ProfessionDetailDTO profession = new ProfessionDetailDTO();
                    profession.Profession = txtProfession.Text;
                    if (bll.Insert(profession))
                    {
                        MessageBox.Show("Profession was added");
                        txtProfession.Clear();
                    }
                }
                else if (isUpdate)
                {
                    if (detail.Profession==txtProfession.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.Profession = txtProfession.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Profession was updated");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void FormProfession_Load(object sender, EventArgs e)
        {
            txtProfession.Text = detail.Profession;
        }
    }
}
