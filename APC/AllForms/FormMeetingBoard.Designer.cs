namespace APC.AllForms
{
    partial class FormMeetingBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.meetingsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAbsentees = new System.Windows.Forms.Button();
            this.labelTotalMeetings = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthlyDues = new System.Windows.Forms.TextBox();
            this.txtNoOfAttend = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rbLessMonDues = new System.Windows.Forms.RadioButton();
            this.rbMoreMonDues = new System.Windows.Forms.RadioButton();
            this.rbEqualMonDues = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rbLessAttend = new System.Windows.Forms.RadioButton();
            this.rbMoreAttend = new System.Windows.Forms.RadioButton();
            this.rbEqualAttend = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commentPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearComments = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchComments = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbGenderComments = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameComments = new System.Windows.Forms.TextBox();
            this.txtSurnameComments = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYearComments = new System.Windows.Forms.TextBox();
            this.cmbMonthComments = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddComments = new System.Windows.Forms.Button();
            this.btnUpdateComments = new System.Windows.Forms.Button();
            this.btnDeleteComments = new System.Windows.Forms.Button();
            this.btnViewComments = new System.Windows.Forms.Button();
            this.labelTotalComments = new System.Windows.Forms.Label();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.penaltyPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.meetingsPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.commentPage.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.meetingsPage);
            this.tabControl1.Controls.Add(this.commentPage);
            this.tabControl1.Controls.Add(this.penaltyPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // meetingsPage
            // 
            this.meetingsPage.Controls.Add(this.tableLayoutPanel1);
            this.meetingsPage.Location = new System.Drawing.Point(4, 30);
            this.meetingsPage.Name = "meetingsPage";
            this.meetingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.meetingsPage.Size = new System.Drawing.Size(949, 566);
            this.meetingsPage.TabIndex = 0;
            this.meetingsPage.Text = "Meetings";
            this.meetingsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 560);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnView, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 9, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAbsentees, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTotalMeetings, 10, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(21, 478);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(899, 79);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepPink;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(146, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DeepPink;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(358, 22);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(83, 33);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepPink;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(252, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepPink;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(660, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAbsentees
            // 
            this.btnAbsentees.BackColor = System.Drawing.Color.DeepPink;
            this.btnAbsentees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbsentees.FlatAppearance.BorderSize = 0;
            this.btnAbsentees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsentees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsentees.Location = new System.Drawing.Point(464, 22);
            this.btnAbsentees.Name = "btnAbsentees";
            this.btnAbsentees.Size = new System.Drawing.Size(173, 33);
            this.btnAbsentees.TabIndex = 2;
            this.btnAbsentees.Text = "View Absentees";
            this.btnAbsentees.UseVisualStyleBackColor = false;
            this.btnAbsentees.Click += new System.EventHandler(this.btnAbsentees_Click);
            // 
            // labelTotalMeetings
            // 
            this.labelTotalMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalMeetings.AutoSize = true;
            this.labelTotalMeetings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMeetings.Location = new System.Drawing.Point(831, 29);
            this.labelTotalMeetings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelTotalMeetings.Name = "labelTotalMeetings";
            this.labelTotalMeetings.Size = new System.Drawing.Size(65, 21);
            this.labelTotalMeetings.TabIndex = 4;
            this.labelTotalMeetings.Text = "Total: 0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMonthlyDues, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNoOfAttend, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbMonth, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtYear, 4, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(899, 78);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Dues";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. of Attendance";
            // 
            // txtMonthlyDues
            // 
            this.txtMonthlyDues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMonthlyDues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyDues.Location = new System.Drawing.Point(198, 3);
            this.txtMonthlyDues.Name = "txtMonthlyDues";
            this.txtMonthlyDues.Size = new System.Drawing.Size(91, 29);
            this.txtMonthlyDues.TabIndex = 1;
            this.txtMonthlyDues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonthlyDues_KeyPress);
            // 
            // txtNoOfAttend
            // 
            this.txtNoOfAttend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoOfAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfAttend.Location = new System.Drawing.Point(198, 42);
            this.txtNoOfAttend.Name = "txtNoOfAttend";
            this.txtNoOfAttend.Size = new System.Drawing.Size(91, 29);
            this.txtNoOfAttend.TabIndex = 1;
            this.txtNoOfAttend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoOfAttend_KeyPress);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.rbLessMonDues, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rbMoreMonDues, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.rbEqualMonDues, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(295, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 32);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // rbLessMonDues
            // 
            this.rbLessMonDues.AutoSize = true;
            this.rbLessMonDues.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLessMonDues.Location = new System.Drawing.Point(3, 3);
            this.rbLessMonDues.Name = "rbLessMonDues";
            this.rbLessMonDues.Size = new System.Drawing.Size(52, 21);
            this.rbLessMonDues.TabIndex = 0;
            this.rbLessMonDues.TabStop = true;
            this.rbLessMonDues.Text = "Less";
            this.rbLessMonDues.UseVisualStyleBackColor = true;
            // 
            // rbMoreMonDues
            // 
            this.rbMoreMonDues.AutoSize = true;
            this.rbMoreMonDues.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMoreMonDues.Location = new System.Drawing.Point(87, 3);
            this.rbMoreMonDues.Name = "rbMoreMonDues";
            this.rbMoreMonDues.Size = new System.Drawing.Size(58, 21);
            this.rbMoreMonDues.TabIndex = 0;
            this.rbMoreMonDues.TabStop = true;
            this.rbMoreMonDues.Text = "More";
            this.rbMoreMonDues.UseVisualStyleBackColor = true;
            // 
            // rbEqualMonDues
            // 
            this.rbEqualMonDues.AutoSize = true;
            this.rbEqualMonDues.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEqualMonDues.Location = new System.Drawing.Point(171, 3);
            this.rbEqualMonDues.Name = "rbEqualMonDues";
            this.rbEqualMonDues.Size = new System.Drawing.Size(60, 21);
            this.rbEqualMonDues.TabIndex = 0;
            this.rbEqualMonDues.TabStop = true;
            this.rbEqualMonDues.Text = "Equal";
            this.rbEqualMonDues.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(655, 3);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(140, 29);
            this.cmbMonth.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.rbLessAttend, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbMoreAttend, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.rbEqualAttend, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(295, 42);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(254, 33);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // rbLessAttend
            // 
            this.rbLessAttend.AutoSize = true;
            this.rbLessAttend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLessAttend.Location = new System.Drawing.Point(3, 3);
            this.rbLessAttend.Name = "rbLessAttend";
            this.rbLessAttend.Size = new System.Drawing.Size(52, 21);
            this.rbLessAttend.TabIndex = 0;
            this.rbLessAttend.TabStop = true;
            this.rbLessAttend.Text = "Less";
            this.rbLessAttend.UseVisualStyleBackColor = true;
            // 
            // rbMoreAttend
            // 
            this.rbMoreAttend.AutoSize = true;
            this.rbMoreAttend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMoreAttend.Location = new System.Drawing.Point(87, 3);
            this.rbMoreAttend.Name = "rbMoreAttend";
            this.rbMoreAttend.Size = new System.Drawing.Size(58, 21);
            this.rbMoreAttend.TabIndex = 0;
            this.rbMoreAttend.TabStop = true;
            this.rbMoreAttend.Text = "More";
            this.rbMoreAttend.UseVisualStyleBackColor = true;
            // 
            // rbEqualAttend
            // 
            this.rbEqualAttend.AutoSize = true;
            this.rbEqualAttend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEqualAttend.Location = new System.Drawing.Point(171, 3);
            this.rbEqualAttend.Name = "rbEqualAttend";
            this.rbEqualAttend.Size = new System.Drawing.Size(60, 21);
            this.rbEqualAttend.TabIndex = 0;
            this.rbEqualAttend.TabStop = true;
            this.rbEqualAttend.Text = "Equal";
            this.rbEqualAttend.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(801, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(801, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(655, 42);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(140, 29);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(21, 98);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(899, 374);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // commentPage
            // 
            this.commentPage.Controls.Add(this.tableLayoutPanel6);
            this.commentPage.Location = new System.Drawing.Point(4, 30);
            this.commentPage.Name = "commentPage";
            this.commentPage.Padding = new System.Windows.Forms.Padding(3);
            this.commentPage.Size = new System.Drawing.Size(949, 566);
            this.commentPage.TabIndex = 1;
            this.commentPage.Text = "Comments";
            this.commentPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.panelDataGridView, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(943, 560);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel7.Controls.Add(this.btnClearComments, 6, 2);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnSearchComments, 6, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtComment, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.cmbGenderComments, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtNameComments, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtSurnameComments, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.txtYearComments, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.cmbMonthComments, 5, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(21, 8);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(899, 77);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // btnClearComments
            // 
            this.btnClearComments.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearComments.FlatAppearance.BorderSize = 0;
            this.btnClearComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearComments.Location = new System.Drawing.Point(797, 41);
            this.btnClearComments.Name = "btnClearComments";
            this.btnClearComments.Size = new System.Drawing.Size(99, 33);
            this.btnClearComments.TabIndex = 0;
            this.btnClearComments.Text = "Clear";
            this.btnClearComments.UseVisualStyleBackColor = false;
            this.btnClearComments.Click += new System.EventHandler(this.btnClearComments_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Surname";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comment";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            // 
            // btnSearchComments
            // 
            this.btnSearchComments.BackColor = System.Drawing.Color.Plum;
            this.btnSearchComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchComments.FlatAppearance.BorderSize = 0;
            this.btnSearchComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchComments.Location = new System.Drawing.Point(797, 3);
            this.btnSearchComments.Name = "btnSearchComments";
            this.btnSearchComments.Size = new System.Drawing.Size(99, 31);
            this.btnSearchComments.TabIndex = 0;
            this.btnSearchComments.Text = "Search";
            this.btnSearchComments.UseVisualStyleBackColor = false;
            this.btnSearchComments.Click += new System.EventHandler(this.btnSearchComments_Click);
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(103, 41);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(172, 33);
            this.txtComment.TabIndex = 1;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // cmbGenderComments
            // 
            this.cmbGenderComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGenderComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenderComments.FormattingEnabled = true;
            this.cmbGenderComments.Location = new System.Drawing.Point(361, 41);
            this.cmbGenderComments.Name = "cmbGenderComments";
            this.cmbGenderComments.Size = new System.Drawing.Size(172, 29);
            this.cmbGenderComments.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // txtNameComments
            // 
            this.txtNameComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameComments.Location = new System.Drawing.Point(361, 3);
            this.txtNameComments.Name = "txtNameComments";
            this.txtNameComments.Size = new System.Drawing.Size(172, 29);
            this.txtNameComments.TabIndex = 1;
            this.txtNameComments.TextChanged += new System.EventHandler(this.txtNameComments_TextChanged);
            // 
            // txtSurnameComments
            // 
            this.txtSurnameComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSurnameComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurnameComments.Location = new System.Drawing.Point(103, 3);
            this.txtSurnameComments.Name = "txtSurnameComments";
            this.txtSurnameComments.Size = new System.Drawing.Size(172, 29);
            this.txtSurnameComments.TabIndex = 1;
            this.txtSurnameComments.TextChanged += new System.EventHandler(this.txtSurnameComments_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 10);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Month";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(570, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Year";
            // 
            // txtYearComments
            // 
            this.txtYearComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYearComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearComments.Location = new System.Drawing.Point(619, 41);
            this.txtYearComments.Name = "txtYearComments";
            this.txtYearComments.Size = new System.Drawing.Size(172, 29);
            this.txtYearComments.TabIndex = 1;
            this.txtYearComments.TextChanged += new System.EventHandler(this.txtYearComments_TextChanged);
            // 
            // cmbMonthComments
            // 
            this.cmbMonthComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMonthComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonthComments.FormattingEnabled = true;
            this.cmbMonthComments.Location = new System.Drawing.Point(619, 3);
            this.cmbMonthComments.Name = "cmbMonthComments";
            this.cmbMonthComments.Size = new System.Drawing.Size(172, 29);
            this.cmbMonthComments.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 9;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel8.Controls.Add(this.btnAddComments, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnUpdateComments, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnDeleteComments, 7, 1);
            this.tableLayoutPanel8.Controls.Add(this.btnViewComments, 5, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelTotalComments, 8, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(21, 479);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(899, 78);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // btnAddComments
            // 
            this.btnAddComments.BackColor = System.Drawing.Color.Plum;
            this.btnAddComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddComments.FlatAppearance.BorderSize = 0;
            this.btnAddComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComments.Location = new System.Drawing.Point(191, 22);
            this.btnAddComments.Name = "btnAddComments";
            this.btnAddComments.Size = new System.Drawing.Size(110, 33);
            this.btnAddComments.TabIndex = 0;
            this.btnAddComments.Text = "Add";
            this.btnAddComments.UseVisualStyleBackColor = false;
            this.btnAddComments.Click += new System.EventHandler(this.btnAddComments_Click);
            // 
            // btnUpdateComments
            // 
            this.btnUpdateComments.BackColor = System.Drawing.Color.Plum;
            this.btnUpdateComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateComments.FlatAppearance.BorderSize = 0;
            this.btnUpdateComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateComments.Location = new System.Drawing.Point(324, 22);
            this.btnUpdateComments.Name = "btnUpdateComments";
            this.btnUpdateComments.Size = new System.Drawing.Size(110, 33);
            this.btnUpdateComments.TabIndex = 1;
            this.btnUpdateComments.Text = "Edit";
            this.btnUpdateComments.UseVisualStyleBackColor = false;
            this.btnUpdateComments.Click += new System.EventHandler(this.btnUpdateComments_Click);
            // 
            // btnDeleteComments
            // 
            this.btnDeleteComments.BackColor = System.Drawing.Color.Plum;
            this.btnDeleteComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteComments.FlatAppearance.BorderSize = 0;
            this.btnDeleteComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteComments.Location = new System.Drawing.Point(590, 22);
            this.btnDeleteComments.Name = "btnDeleteComments";
            this.btnDeleteComments.Size = new System.Drawing.Size(110, 33);
            this.btnDeleteComments.TabIndex = 2;
            this.btnDeleteComments.Text = "Delete";
            this.btnDeleteComments.UseVisualStyleBackColor = false;
            // 
            // btnViewComments
            // 
            this.btnViewComments.BackColor = System.Drawing.Color.Plum;
            this.btnViewComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewComments.FlatAppearance.BorderSize = 0;
            this.btnViewComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewComments.Location = new System.Drawing.Point(457, 22);
            this.btnViewComments.Name = "btnViewComments";
            this.btnViewComments.Size = new System.Drawing.Size(110, 33);
            this.btnViewComments.TabIndex = 3;
            this.btnViewComments.Text = "View";
            this.btnViewComments.UseVisualStyleBackColor = false;
            this.btnViewComments.Click += new System.EventHandler(this.btnViewComments_Click);
            // 
            // labelTotalComments
            // 
            this.labelTotalComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalComments.AutoSize = true;
            this.labelTotalComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalComments.Location = new System.Drawing.Point(831, 29);
            this.labelTotalComments.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelTotalComments.Name = "labelTotalComments";
            this.labelTotalComments.Size = new System.Drawing.Size(65, 21);
            this.labelTotalComments.TabIndex = 5;
            this.labelTotalComments.Text = "Total: 0";
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewComments);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDataGridView.Location = new System.Drawing.Point(21, 91);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(899, 382);
            this.panelDataGridView.TabIndex = 5;
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewComments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewComments.Name = "dataGridViewComments";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComments.RowTemplate.Height = 30;
            this.dataGridViewComments.Size = new System.Drawing.Size(899, 382);
            this.dataGridViewComments.TabIndex = 0;
            this.dataGridViewComments.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComments_RowEnter);
            // 
            // penaltyPage
            // 
            this.penaltyPage.Location = new System.Drawing.Point(4, 30);
            this.penaltyPage.Name = "penaltyPage";
            this.penaltyPage.Size = new System.Drawing.Size(949, 566);
            this.penaltyPage.TabIndex = 2;
            this.penaltyPage.Text = "Penalties";
            this.penaltyPage.UseVisualStyleBackColor = true;
            // 
            // FormMeetingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 600);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMeetingBoard";
            this.Text = "Meetings and Comments";
            this.Load += new System.EventHandler(this.FormMeetingBoard_Load);
            this.tabControl1.ResumeLayout(false);
            this.meetingsPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.commentPage.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage meetingsPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAbsentees;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonthlyDues;
        private System.Windows.Forms.TextBox txtNoOfAttend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton rbLessMonDues;
        private System.Windows.Forms.RadioButton rbMoreMonDues;
        private System.Windows.Forms.RadioButton rbEqualMonDues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rbLessAttend;
        private System.Windows.Forms.RadioButton rbMoreAttend;
        private System.Windows.Forms.RadioButton rbEqualAttend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage commentPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnClearComments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearchComments;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbGenderComments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameComments;
        private System.Windows.Forms.TextBox txtSurnameComments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYearComments;
        private System.Windows.Forms.ComboBox cmbMonthComments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnAddComments;
        private System.Windows.Forms.Button btnUpdateComments;
        private System.Windows.Forms.Button btnDeleteComments;
        private System.Windows.Forms.Button btnViewComments;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.Label labelTotalMeetings;
        private System.Windows.Forms.Label labelTotalComments;
        private System.Windows.Forms.TabPage penaltyPage;
    }
}