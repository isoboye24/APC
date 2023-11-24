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
using APC.BLL;
using FontAwesome.Sharp;

namespace APC.AllForms
{
    public partial class FormManagement : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormManagement()
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
        // Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(204, 102, 0);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(245, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color normal = Color.MidnightBlue;
        }
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
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkOrange;
            labelTitleChildForm.Text = "Management";
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
        private void labelHome_Click(object sender, EventArgs e)
        {
            FormDashboard open = new FormDashboard();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin open = new FormLogin();
            this.Hide();
            open.ShowDialog();
            this.Visible = true;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);            
        }
        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        ProfessionBLL profBll = new ProfessionBLL();
        PositionBLL posBll = new PositionBLL();
        MemberBLL memberBLL = new MemberBLL();
        
        private void FormManagement_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            posBll = new PositionBLL();
            profBll = new ProfessionBLL();
            General.ValueCount(labelTotalProfession, profBll.ProfessionCount(), 150, 29);
            General.ValueCount(labelTotalPosition, posBll.PositionCount(), 150, 29);
            General.ValueCount(labelTotalNationality, memberBLL.SelectCountUniqueNationality(), 150, 29);
        }

        private void iconClose_MouseEnter(object sender, EventArgs e)
        {
            iconClose.BackColor = RBGColors.color1;
        }

        private void iconClose_MouseHover(object sender, EventArgs e)
        {
            iconClose.BackColor = RBGColors.color1;
        }

        private void iconClose_MouseLeave(object sender, EventArgs e)
        {
            iconClose.BackColor = Color.DarkOrange;
        }
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconMaximize_MouseEnter(object sender, EventArgs e)
        {
            iconMaximize.BackColor = RBGColors.color1;
        }

        private void iconMaximize_MouseHover(object sender, EventArgs e)
        {
            iconMaximize.BackColor = RBGColors.color1;
        }

        private void iconMaximize_MouseLeave(object sender, EventArgs e)
        {
            iconMaximize.BackColor = Color.DarkOrange;
        }

        private void iconMaximize_Click(object sender, EventArgs e)
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

        private void iconMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconMinimize.BackColor = RBGColors.color1;
        }

        private void iconMinimize_MouseHover(object sender, EventArgs e)
        {
            iconMinimize.BackColor = RBGColors.color1;
        }

        private void iconMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconMinimize.BackColor = Color.DarkOrange;
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

        private bool buttonWasClicked = false;
        private void btnPosition_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormPositionList());
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormCountryList());
        }

        private void btnMaritalStatus_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormMaritalStatusList());
        }

        private void btnEmploymentStatus_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormEmploymentStatusList());
        }

        private void btnProfession_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormProfessionList());
        }        

        private void btnManagement_Click(object sender, EventArgs e)
        {
            if (buttonWasClicked)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormPermissionList());
        }

        private void btnNationality_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormNationalityList());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormContactList());
        }

        private void btnDeletedData_Click(object sender, EventArgs e)
        {
            buttonWasClicked = true;
            ActivateButton(sender, RBGColors.color1);
            OpenChildForm(new FormDeletedData());
        }
    }
}
