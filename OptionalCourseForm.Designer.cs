
namespace Studentmgt
{
    partial class OptionalCourseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_RegisteredCourse = new System.Windows.Forms.Label();
            this.DataGridView_RegCourse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_ClearR = new System.Windows.Forms.Button();
            this.textBox_CourseCredit = new System.Windows.Forms.TextBox();
            this.label_CourseCredit = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_UpdateR = new System.Windows.Forms.Button();
            this.textBox_CourseHour = new System.Windows.Forms.TextBox();
            this.label_CourseHour = new System.Windows.Forms.Label();
            this.label_CourseCode = new System.Windows.Forms.Label();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.label_CourseName = new System.Windows.Forms.Label();
            this.button_addR = new System.Windows.Forms.Button();
            this.label_hr = new System.Windows.Forms.Label();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_option = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RegCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(613, 74);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(156, 20);
            this.textBox_Search.TabIndex = 80;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.Orange;
            this.button_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(779, 59);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(156, 44);
            this.button_Search.TabIndex = 79;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label_RegisteredCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 53);
            this.panel1.TabIndex = 66;
            // 
            // label_RegisteredCourse
            // 
            this.label_RegisteredCourse.AutoSize = true;
            this.label_RegisteredCourse.Location = new System.Drawing.Point(363, 19);
            this.label_RegisteredCourse.Name = "label_RegisteredCourse";
            this.label_RegisteredCourse.Size = new System.Drawing.Size(133, 19);
            this.label_RegisteredCourse.TabIndex = 0;
            this.label_RegisteredCourse.Text = "Optional Course";
            // 
            // DataGridView_RegCourse
            // 
            this.DataGridView_RegCourse.AllowUserToAddRows = false;
            this.DataGridView_RegCourse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_RegCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_RegCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_RegCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_RegCourse.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_RegCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_RegCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_RegCourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_RegCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_RegCourse.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_RegCourse.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_RegCourse.EnableHeadersVisualStyles = false;
            this.DataGridView_RegCourse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_RegCourse.Location = new System.Drawing.Point(3, 109);
            this.DataGridView_RegCourse.Name = "DataGridView_RegCourse";
            this.DataGridView_RegCourse.RowHeadersVisible = false;
            this.DataGridView_RegCourse.RowTemplate.Height = 80;
            this.DataGridView_RegCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_RegCourse.Size = new System.Drawing.Size(931, 191);
            this.DataGridView_RegCourse.TabIndex = 68;
            this.DataGridView_RegCourse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_RegCourse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_RegCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_RegCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_RegCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_RegCourse.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_RegCourse.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_RegCourse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_RegCourse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_RegCourse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_RegCourse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_RegCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_RegCourse.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_RegCourse.ThemeStyle.ReadOnly = false;
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_RegCourse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_RegCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RegCourse_CellContentClick);
            this.DataGridView_RegCourse.Click += new System.EventHandler(this.DataGridView_RegCourse_Click_1);
            // 
            // button_ClearR
            // 
            this.button_ClearR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearR.BackColor = System.Drawing.Color.Orange;
            this.button_ClearR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearR.ForeColor = System.Drawing.Color.White;
            this.button_ClearR.Location = new System.Drawing.Point(772, 504);
            this.button_ClearR.Name = "button_ClearR";
            this.button_ClearR.Size = new System.Drawing.Size(156, 44);
            this.button_ClearR.TabIndex = 78;
            this.button_ClearR.Text = "Clear";
            this.button_ClearR.UseVisualStyleBackColor = false;
            this.button_ClearR.Click += new System.EventHandler(this.button_ClearR_Click);
            // 
            // textBox_CourseCredit
            // 
            this.textBox_CourseCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseCredit.Location = new System.Drawing.Point(7, 480);
            this.textBox_CourseCredit.Name = "textBox_CourseCredit";
            this.textBox_CourseCredit.Size = new System.Drawing.Size(243, 27);
            this.textBox_CourseCredit.TabIndex = 77;
            // 
            // label_CourseCredit
            // 
            this.label_CourseCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CourseCredit.AutoSize = true;
            this.label_CourseCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CourseCredit.Location = new System.Drawing.Point(3, 458);
            this.label_CourseCredit.Name = "label_CourseCredit";
            this.label_CourseCredit.Size = new System.Drawing.Size(112, 19);
            this.label_CourseCredit.TabIndex = 76;
            this.label_CourseCredit.Text = "Course Credit";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(3, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 15);
            this.panel3.TabIndex = 75;
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(772, 567);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(156, 44);
            this.button_Delete.TabIndex = 74;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_UpdateR
            // 
            this.button_UpdateR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UpdateR.BackColor = System.Drawing.Color.OrangeRed;
            this.button_UpdateR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateR.ForeColor = System.Drawing.Color.White;
            this.button_UpdateR.Location = new System.Drawing.Point(610, 567);
            this.button_UpdateR.Name = "button_UpdateR";
            this.button_UpdateR.Size = new System.Drawing.Size(156, 44);
            this.button_UpdateR.TabIndex = 73;
            this.button_UpdateR.Text = "Update";
            this.button_UpdateR.UseVisualStyleBackColor = false;
            this.button_UpdateR.Click += new System.EventHandler(this.button_UpdateR_Click_1);
            // 
            // textBox_CourseHour
            // 
            this.textBox_CourseHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseHour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseHour.Location = new System.Drawing.Point(7, 539);
            this.textBox_CourseHour.Multiline = true;
            this.textBox_CourseHour.Name = "textBox_CourseHour";
            this.textBox_CourseHour.Size = new System.Drawing.Size(243, 27);
            this.textBox_CourseHour.TabIndex = 72;
            // 
            // label_CourseHour
            // 
            this.label_CourseHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CourseHour.AutoSize = true;
            this.label_CourseHour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CourseHour.Location = new System.Drawing.Point(9, 517);
            this.label_CourseHour.Name = "label_CourseHour";
            this.label_CourseHour.Size = new System.Drawing.Size(151, 19);
            this.label_CourseHour.TabIndex = 71;
            this.label_CourseHour.Text = "Credit Hours/Week";
            // 
            // label_CourseCode
            // 
            this.label_CourseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CourseCode.AutoSize = true;
            this.label_CourseCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CourseCode.Location = new System.Drawing.Point(12, 324);
            this.label_CourseCode.Name = "label_CourseCode";
            this.label_CourseCode.Size = new System.Drawing.Size(121, 19);
            this.label_CourseCode.TabIndex = 70;
            this.label_CourseCode.Text = "Course Code : ";
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseCode.Location = new System.Drawing.Point(10, 346);
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(523, 27);
            this.textBox_CourseCode.TabIndex = 67;
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseName.Location = new System.Drawing.Point(10, 407);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(523, 27);
            this.textBox_CourseName.TabIndex = 69;
            // 
            // label_CourseName
            // 
            this.label_CourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CourseName.AutoSize = true;
            this.label_CourseName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CourseName.Location = new System.Drawing.Point(12, 385);
            this.label_CourseName.Name = "label_CourseName";
            this.label_CourseName.Size = new System.Drawing.Size(127, 19);
            this.label_CourseName.TabIndex = 65;
            this.label_CourseName.Text = "Course Name : ";
            // 
            // button_addR
            // 
            this.button_addR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_addR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_addR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addR.ForeColor = System.Drawing.Color.White;
            this.button_addR.Location = new System.Drawing.Point(610, 504);
            this.button_addR.Name = "button_addR";
            this.button_addR.Size = new System.Drawing.Size(156, 44);
            this.button_addR.TabIndex = 81;
            this.button_addR.Text = "Add";
            this.button_addR.UseVisualStyleBackColor = false;
            this.button_addR.Click += new System.EventHandler(this.button_addR_Click);
            // 
            // label_hr
            // 
            this.label_hr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_hr.AutoSize = true;
            this.label_hr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_hr.Location = new System.Drawing.Point(315, 458);
            this.label_hr.Name = "label_hr";
            this.label_hr.Size = new System.Drawing.Size(78, 19);
            this.label_hr.TabIndex = 82;
            this.label_hr.Text = "Semester";
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Location = new System.Drawing.Point(310, 484);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(243, 21);
            this.comboBox_semester.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(315, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 84;
            this.label1.Text = "Option";
            // 
            // textBox_option
            // 
            this.textBox_option.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_option.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_option.Location = new System.Drawing.Point(310, 539);
            this.textBox_option.Multiline = true;
            this.textBox_option.Name = "textBox_option";
            this.textBox_option.Size = new System.Drawing.Size(243, 27);
            this.textBox_option.TabIndex = 85;
            // 
            // RegCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 615);
            this.Controls.Add(this.textBox_option);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_semester);
            this.Controls.Add(this.label_hr);
            this.Controls.Add(this.button_addR);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView_RegCourse);
            this.Controls.Add(this.button_ClearR);
            this.Controls.Add(this.textBox_CourseCredit);
            this.Controls.Add(this.label_CourseCredit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_UpdateR);
            this.Controls.Add(this.textBox_CourseHour);
            this.Controls.Add(this.label_CourseHour);
            this.Controls.Add(this.label_CourseCode);
            this.Controls.Add(this.textBox_CourseCode);
            this.Controls.Add(this.textBox_CourseName);
            this.Controls.Add(this.label_CourseName);
            this.Name = "RegCourseForm";
            this.Text = "RegCourseForm";
            this.Load += new System.EventHandler(this.RegCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_RegCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_RegisteredCourse;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_RegCourse;
        private System.Windows.Forms.Button button_ClearR;
        private System.Windows.Forms.TextBox textBox_CourseCredit;
        private System.Windows.Forms.Label label_CourseCredit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_UpdateR;
        private System.Windows.Forms.TextBox textBox_CourseHour;
        private System.Windows.Forms.Label label_CourseHour;
        private System.Windows.Forms.Label label_CourseCode;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.Label label_CourseName;
        private System.Windows.Forms.Button button_addR;
        private System.Windows.Forms.Label label_hr;
        private System.Windows.Forms.ComboBox comboBox_semester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_option;
    }
}