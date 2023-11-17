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
    public partial class FormPermissionList : Form
    {
        public FormPermissionList()
        {
            InitializeComponent();
        }
        PermissionBLL bll = new PermissionBLL();
        PermissionDTO dto = new PermissionDTO();
        private void FormPermissionList_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbPermission.DataSource = dto.Permissions;
            cmbPermission.DisplayMember = "Permission";
            cmbPermission.ValueMember = "PermissionID";
            cmbPermission.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PermissionDetailDTO> list = dto.Permissions;
            list = list.Where(x => x.Permission.Contains(cmbPermission.Text)).ToList();
            dataGridView1.DataSource = list;
        }
    }
}
