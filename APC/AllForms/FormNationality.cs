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
    public partial class FormNationality : Form
    {
        public FormNationality()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        NationalityBLL bll = new NationalityBLL();
        public NationalityDetailDTO detail = new NationalityDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNationality.Text.Trim() == "")
            {
                MessageBox.Show("Nationality is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    NationalityDetailDTO nationality = new NationalityDetailDTO();
                    nationality.Nationality = txtNationality.Text;
                    if (bll.Insert(nationality))
                    {
                        MessageBox.Show("Nationality was added");
                        txtNationality.Clear();
                    }
                }
                else if (isUpdate)
                {
                    if (detail.NationalityID == 0)
                    {
                        MessageBox.Show("Please select a nationality from the table");
                    }
                    else
                    {
                        detail.Nationality = txtNationality.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Nationality was update");
                            this.Close();
                        }
                    }
                }

            }
        }

        private void FormNationality_Load(object sender, EventArgs e)
        {
            txtNationality.Text = detail.Nationality;
        }
    }
}
