namespace APC
{
    partial class FormGeneralAttendanceList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAbsentees = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(22, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 398);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(907, 83);
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
            this.label4.Location = new System.Drawing.Point(3, 51);
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
            this.txtMonthlyDues.Location = new System.Drawing.Point(163, 3);
            this.txtMonthlyDues.Name = "txtMonthlyDues";
            this.txtMonthlyDues.Size = new System.Drawing.Size(161, 29);
            this.txtMonthlyDues.TabIndex = 1;
            this.txtMonthlyDues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonthlyDues_KeyPress);
            // 
            // txtNoOfAttend
            // 
            this.txtNoOfAttend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoOfAttend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfAttend.Location = new System.Drawing.Point(163, 44);
            this.txtNoOfAttend.Name = "txtNoOfAttend";
            this.txtNoOfAttend.Size = new System.Drawing.Size(161, 29);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(330, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 34);
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
            this.rbMoreMonDues.Location = new System.Drawing.Point(67, 3);
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
            this.rbEqualMonDues.Location = new System.Drawing.Point(131, 3);
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
            this.label2.Location = new System.Drawing.Point(563, 10);
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
            this.cmbMonth.Location = new System.Drawing.Point(630, 3);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(161, 29);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(330, 44);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 36);
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
            this.rbMoreAttend.Location = new System.Drawing.Point(67, 3);
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
            this.rbEqualAttend.Location = new System.Drawing.Point(131, 3);
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
            this.btnClear.Location = new System.Drawing.Point(797, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 36);
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
            this.btnSearch.Location = new System.Drawing.Point(797, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 34);
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
            this.label3.Location = new System.Drawing.Point(581, 51);
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
            this.txtYear.Location = new System.Drawing.Point(630, 44);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(161, 29);
            this.txtYear.TabIndex = 1;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 507);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(907, 85);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepPink;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(148, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DeepPink;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(364, 24);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(84, 36);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepPink;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(256, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 36);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepPink;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(671, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 36);
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
            this.btnAbsentees.Location = new System.Drawing.Point(472, 24);
            this.btnAbsentees.Name = "btnAbsentees";
            this.btnAbsentees.Size = new System.Drawing.Size(175, 36);
            this.btnAbsentees.TabIndex = 2;
            this.btnAbsentees.Text = "View Absentees";
            this.btnAbsentees.UseVisualStyleBackColor = false;
            this.btnAbsentees.Click += new System.EventHandler(this.btnAbsentees_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(952, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormGeneralAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormGeneralAttendanceList";
            this.Text = "Meetings";
            this.Load += new System.EventHandler(this.FormAttendanceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAbsentees;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}