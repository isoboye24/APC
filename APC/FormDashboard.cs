﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APC.AllForms;
using FontAwesome.Sharp;

namespace APC
{
    public partial class FormDashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormDashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 40);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(245, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color normal = Color.MidnightBlue;
        }
        // Button Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.MidnightBlue;
                currentBtn.ForeColor = Color.PaleTurquoise;
                currentBtn.IconColor = Color.PaleTurquoise; ;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        // Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Home";
        }


        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // open only a form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }     

        private void picBoxMin_Click(object sender, EventArgs e)
        {
            
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void iconClose_MouseEnter(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.DeepSkyBlue;
        }

        private void iconClose_MouseHover(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.DeepSkyBlue;
        }

        private void iconClose_MouseLeave(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.DarkOrange;
        }
        private void picBoxMin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void iconMaximize_MouseEnter(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.DeepSkyBlue;
        }

        private void iconMaximize_MouseHover(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.DeepSkyBlue;
        }

        private void iconMaximize_MouseLeave(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.DarkOrange;
        }

        private void iconMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconMinimize_Click(object sender, EventArgs e)
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

        private void iconMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.DeepSkyBlue;
        }

        private void iconMinimize_MouseHover(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.DeepSkyBlue;
        }

        private void iconMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.DarkOrange;
        }
        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            // work on this
            currentChildForm.Close();
            Reset();
        }

        private void btnMembers_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormMembersList());
        }

        private void btnChildren_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormChildrenList());
        }

        private void btnComments_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormCommentsList());
        }

        private void btnFinancialReport_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);
            OpenChildForm(new FormFinancialReportList());
        }

        private void btnManage_Click_1(object sender, EventArgs e)
        {
            FormManagement open = new FormManagement();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }

        private void labelLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin open = new FormLogin();
            this.Hide();
            open.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }       

        private void panelRegMembers_Click(object sender, EventArgs e)
        {
            
        }
    }
}