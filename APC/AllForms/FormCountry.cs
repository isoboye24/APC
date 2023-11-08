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
    public partial class FormCountry : Form
    {
        public FormCountry()
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
        CountryBLL bll = new CountryBLL();
        public CountryDetailDTO detail = new CountryDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCountry.Text.Trim()=="")
            {
                MessageBox.Show("Country is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    CountryDetailDTO country = new CountryDetailDTO();
                    country.CountryName = txtCountry.Text;
                    if (bll.Insert(country))
                    {
                        MessageBox.Show("Country was added");
                        txtCountry.Clear();
                    }
                }
                else
                {
                    if (detail.CountryName == txtCountry.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.CountryName = txtCountry.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Country was updated");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void FormCountry_Load(object sender, EventArgs e)
        {
            txtCountry.Text = detail.CountryName;
        }
    }
}
