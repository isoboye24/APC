using APC.BLL;
using APC.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APC
{
    public partial class FormPosition : Form
    {
        public FormPosition()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormPosition_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PositionBLL bll = new PositionBLL();
        public PositionDetailDTO detail = new PositionDetailDTO();
        public bool isUpdate = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim()=="")
            {
                MessageBox.Show("Position is empty");
            }
            else
            {
                if (!isUpdate)
                {
                    PositionDetailDTO position = new PositionDetailDTO();
                    position.PositionName = txtPosition.Text;
                    if (bll.Insert(position))
                    {
                        MessageBox.Show("Position was added");
                        txtPosition.Clear();
                    }
                }
                else if(isUpdate)
                {
                    if (detail.PositionName == txtPosition.Text.Trim())
                    {
                        MessageBox.Show("There is no change");
                    }
                    else
                    {
                        detail.PositionName = txtPosition.Text;
                        if (bll.Update(detail))
                        {
                            MessageBox.Show("Position was updated");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void FormPosition_Load(object sender, EventArgs e)
        {
            txtPosition.Text = detail.PositionName;
        }        
    }
}
