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
    public partial class FormEmploymentStatus : Form
    {
        public FormEmploymentStatus()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        EmploymentStatusBLL bll = new EmploymentStatusBLL();
        public EmploymentStatusDetailDTO detail = new EmploymentStatusDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmpStatus.Text.Trim()=="")
            {
                MessageBox.Show("Employment status is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    EmploymentStatusDetailDTO employmentStatus = new EmploymentStatusDetailDTO();
                    employmentStatus.EmploymentStatus = txtEmpStatus.Text;
                    if (bll.Insert(employmentStatus))
                    {
                        MessageBox.Show("Employment status was added");
                        txtEmpStatus.Clear();
                    }
                }
                else if (isUpdate)
                {
                    if (detail.EmploymentStatus==txtEmpStatus.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.EmploymentStatus = txtEmpStatus.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Employment status was updated");
                            this.Close();
                        }
                    }
                }
            }
        }
        private void FormEmploymentStatus_Load(object sender, EventArgs e)
        {
            txtEmpStatus.Text = detail.EmploymentStatus;
        }
    }
}
