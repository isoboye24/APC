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
    public partial class FormFinedMember : Form
    {
        public FormFinedMember()
        {
            InitializeComponent();
        }

        public FinedMemberDetailDTO detail = new FinedMemberDetailDTO();
        public bool isUpdate = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
