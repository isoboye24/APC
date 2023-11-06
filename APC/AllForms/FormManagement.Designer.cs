namespace APC.AllForms
{
    partial class FormManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.iconProfilePic = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnManagement = new FontAwesome.Sharp.IconButton();
            this.btnComments = new FontAwesome.Sharp.IconButton();
            this.btnYear = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfession = new FontAwesome.Sharp.IconButton();
            this.btnEmploymentStatus = new FontAwesome.Sharp.IconButton();
            this.btnMaritalStatus = new FontAwesome.Sharp.IconButton();
            this.btnCountry = new FontAwesome.Sharp.IconButton();
            this.btnPosition = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 5);
            this.panel2.TabIndex = 16;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelHome);
            this.panelLogo.Location = new System.Drawing.Point(-1, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 12;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelHome.Location = new System.Drawing.Point(13, 13);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(164, 65);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(81, 13);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(201, 40);
            this.labelTitleChildForm.TabIndex = 12;
            this.labelTitleChildForm.Text = "Management";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleBar.Controls.Add(this.labelUsername);
            this.panelTitleBar.Controls.Add(this.iconProfilePic);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconMinimize);
            this.panelTitleBar.Controls.Add(this.iconMaximize);
            this.panelTitleBar.Controls.Add(this.iconClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(973, 56);
            this.panelTitleBar.TabIndex = 15;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(561, 27);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 17);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Vincent2023";
            // 
            // iconProfilePic
            // 
            this.iconProfilePic.BackColor = System.Drawing.Color.DarkOrange;
            this.iconProfilePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconProfilePic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconProfilePic.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconProfilePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProfilePic.IconSize = 35;
            this.iconProfilePic.Location = new System.Drawing.Point(502, 12);
            this.iconProfilePic.Name = "iconProfilePic";
            this.iconProfilePic.Size = new System.Drawing.Size(53, 35);
            this.iconProfilePic.TabIndex = 14;
            this.iconProfilePic.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.DarkOrange;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(43, 16);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 13;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.DarkOrange;
            this.iconMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.Location = new System.Drawing.Point(843, 12);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(32, 32);
            this.iconMinimize.TabIndex = 12;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            this.iconMinimize.MouseEnter += new System.EventHandler(this.iconMinimize_MouseEnter);
            this.iconMinimize.MouseLeave += new System.EventHandler(this.iconMinimize_MouseLeave);
            this.iconMinimize.MouseHover += new System.EventHandler(this.iconMinimize_MouseHover);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.Color.DarkOrange;
            this.iconMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximize.Location = new System.Drawing.Point(886, 12);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(32, 32);
            this.iconMaximize.TabIndex = 12;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            this.iconMaximize.MouseEnter += new System.EventHandler(this.iconMaximize_MouseEnter);
            this.iconMaximize.MouseLeave += new System.EventHandler(this.iconMaximize_MouseLeave);
            this.iconMaximize.MouseHover += new System.EventHandler(this.iconMaximize_MouseHover);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.DarkOrange;
            this.iconClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconClose.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(929, 12);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(32, 32);
            this.iconClose.TabIndex = 12;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            this.iconClose.MouseEnter += new System.EventHandler(this.iconClose_MouseEnter);
            this.iconClose.MouseLeave += new System.EventHandler(this.iconClose_MouseLeave);
            this.iconClose.MouseHover += new System.EventHandler(this.iconClose_MouseHover);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnManagement);
            this.panelMenu.Controls.Add(this.btnComments);
            this.panelMenu.Controls.Add(this.btnYear);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnProfession);
            this.panelMenu.Controls.Add(this.btnEmploymentStatus);
            this.panelMenu.Controls.Add(this.btnMaritalStatus);
            this.panelMenu.Controls.Add(this.btnCountry);
            this.panelMenu.Controls.Add(this.btnPosition);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 700);
            this.panelMenu.TabIndex = 14;
            // 
            // btnManagement
            // 
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnManagement.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnManagement.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManagement.IconSize = 24;
            this.btnManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.Location = new System.Drawing.Point(0, 109);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManagement.Size = new System.Drawing.Size(200, 40);
            this.btnManagement.TabIndex = 4;
            this.btnManagement.Text = "    Management";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnComments
            // 
            this.btnComments.FlatAppearance.BorderSize = 0;
            this.btnComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComments.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnComments.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btnComments.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnComments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComments.IconSize = 24;
            this.btnComments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComments.Location = new System.Drawing.Point(0, 162);
            this.btnComments.Name = "btnComments";
            this.btnComments.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnComments.Size = new System.Drawing.Size(200, 40);
            this.btnComments.TabIndex = 4;
            this.btnComments.Text = "    Comments";
            this.btnComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComments.UseVisualStyleBackColor = true;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // btnYear
            // 
            this.btnYear.FlatAppearance.BorderSize = 0;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnYear.IconChar = FontAwesome.Sharp.IconChar.Bomb;
            this.btnYear.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnYear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYear.IconSize = 24;
            this.btnYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYear.Location = new System.Drawing.Point(0, 474);
            this.btnYear.Name = "btnYear";
            this.btnYear.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnYear.Size = new System.Drawing.Size(200, 40);
            this.btnYear.TabIndex = 7;
            this.btnYear.Text = "    Year";
            this.btnYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnLogout.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 24;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 526);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "    Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 673);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 27);
            this.panel1.TabIndex = 0;
            // 
            // btnProfession
            // 
            this.btnProfession.FlatAppearance.BorderSize = 0;
            this.btnProfession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfession.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnProfession.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnProfession.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnProfession.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfession.IconSize = 24;
            this.btnProfession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfession.Location = new System.Drawing.Point(0, 422);
            this.btnProfession.Name = "btnProfession";
            this.btnProfession.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProfession.Size = new System.Drawing.Size(200, 40);
            this.btnProfession.TabIndex = 5;
            this.btnProfession.Text = "    Professtion";
            this.btnProfession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfession.UseVisualStyleBackColor = true;
            this.btnProfession.Click += new System.EventHandler(this.btnProfession_Click);
            // 
            // btnEmploymentStatus
            // 
            this.btnEmploymentStatus.FlatAppearance.BorderSize = 0;
            this.btnEmploymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploymentStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploymentStatus.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnEmploymentStatus.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnEmploymentStatus.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnEmploymentStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmploymentStatus.IconSize = 24;
            this.btnEmploymentStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploymentStatus.Location = new System.Drawing.Point(0, 370);
            this.btnEmploymentStatus.Name = "btnEmploymentStatus";
            this.btnEmploymentStatus.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmploymentStatus.Size = new System.Drawing.Size(200, 40);
            this.btnEmploymentStatus.TabIndex = 4;
            this.btnEmploymentStatus.Text = "    Employ. Status";
            this.btnEmploymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploymentStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmploymentStatus.UseVisualStyleBackColor = true;
            this.btnEmploymentStatus.Click += new System.EventHandler(this.btnEmploymentStatus_Click);
            // 
            // btnMaritalStatus
            // 
            this.btnMaritalStatus.FlatAppearance.BorderSize = 0;
            this.btnMaritalStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaritalStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaritalStatus.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnMaritalStatus.IconChar = FontAwesome.Sharp.IconChar.Ring;
            this.btnMaritalStatus.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnMaritalStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaritalStatus.IconSize = 24;
            this.btnMaritalStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaritalStatus.Location = new System.Drawing.Point(0, 318);
            this.btnMaritalStatus.Name = "btnMaritalStatus";
            this.btnMaritalStatus.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMaritalStatus.Size = new System.Drawing.Size(200, 40);
            this.btnMaritalStatus.TabIndex = 3;
            this.btnMaritalStatus.Text = "    Marital Status";
            this.btnMaritalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaritalStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaritalStatus.UseVisualStyleBackColor = true;
            this.btnMaritalStatus.Click += new System.EventHandler(this.btnMaritalStatus_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.FlatAppearance.BorderSize = 0;
            this.btnCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountry.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnCountry.IconChar = FontAwesome.Sharp.IconChar.EarthAfrica;
            this.btnCountry.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnCountry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCountry.IconSize = 24;
            this.btnCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCountry.Location = new System.Drawing.Point(0, 266);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCountry.Size = new System.Drawing.Size(200, 40);
            this.btnCountry.TabIndex = 2;
            this.btnCountry.Text = "    Country";
            this.btnCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.FlatAppearance.BorderSize = 0;
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnPosition.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnPosition.IconColor = System.Drawing.Color.PaleTurquoise;
            this.btnPosition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPosition.IconSize = 24;
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.Location = new System.Drawing.Point(0, 214);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPosition.Size = new System.Drawing.Size(200, 40);
            this.btnPosition.TabIndex = 1;
            this.btnPosition.Text = "    Position";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(200, 695);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(973, 5);
            this.panel8.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1168, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 634);
            this.panel3.TabIndex = 17;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 61);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(968, 634);
            this.panelDesktop.TabIndex = 18;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseDown);
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 700);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManagement";
            this.Load += new System.EventHandler(this.FormManagement_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconMaximize;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelHome;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconButton btnProfession;
        private FontAwesome.Sharp.IconButton btnEmploymentStatus;
        private FontAwesome.Sharp.IconButton btnMaritalStatus;
        private FontAwesome.Sharp.IconPictureBox iconProfilePic;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconButton btnCountry;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelUsername;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private FontAwesome.Sharp.IconButton btnPosition;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnYear;
        private FontAwesome.Sharp.IconButton btnComments;
        private FontAwesome.Sharp.IconButton btnManagement;
    }
}