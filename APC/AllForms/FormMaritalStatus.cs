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
    public partial class FormMaritalStatus : Form
    {
        public FormMaritalStatus()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MaritalStatusBLL bll = new MaritalStatusBLL();
        public bool isUpdate = false;
        public MaritalStatusDetailDTO detail = new MaritalStatusDetailDTO();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaritalStatus.Text.Trim()=="")
            {
                MessageBox.Show("Marital status is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    MaritalStatusDetailDTO maritalStatus = new MaritalStatusDetailDTO();
                    maritalStatus.MaritalStatus = txtMaritalStatus.Text;
                    if (bll.Insert(maritalStatus))
                    {
                        MessageBox.Show("Marital status was added");
                        txtMaritalStatus.Clear();
                    }
                }
                else if(isUpdate)
                {
                    if (detail.MaritalStatus == txtMaritalStatus.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.MaritalStatus = txtMaritalStatus.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Marital status was updated");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMaritalStatus_Load(object sender, EventArgs e)
        {
            txtMaritalStatus.Text = detail.MaritalStatus;
        }
    }
}
