
namespace Studentmgt
{
    partial class ManageCourseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_NewCourse = new System.Windows.Forms.Label();
            this.panel_NewCourse = new System.Windows.Forms.Panel();
            this.comboBox_semester = new System.Windows.Forms.ComboBox();
            this.label_hr = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.label_CourseCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_CourseCredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Hour = new System.Windows.Forms.Label();
            this.textBox_Hour = new System.Windows.Forms.TextBox();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.label_CourseName = new System.Windows.Forms.Label();
            this.DataGridView_Course = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_NewCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label_NewCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 53);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_NewCourse
            // 
            this.label_NewCourse.AutoSize = true;
            this.label_NewCourse.Location = new System.Drawing.Point(363, 19);
            this.label_NewCourse.Name = "label_NewCourse";
            this.label_NewCourse.Size = new System.Drawing.Size(133, 19);
            this.label_NewCourse.TabIndex = 0;
            this.label_NewCourse.Text = "Manage Course";
            this.label_NewCourse.Click += new System.EventHandler(this.label_NewCourse_Click);
            // 
            // panel_NewCourse
            // 
            this.panel_NewCourse.Controls.Add(this.comboBox_semester);
            this.panel_NewCourse.Controls.Add(this.label_hr);
            this.panel_NewCourse.Controls.Add(this.button_Clear);
            this.panel_NewCourse.Controls.Add(this.textBox_CourseCode);
            this.panel_NewCourse.Controls.Add(this.label_CourseCode);
            this.panel_NewCourse.Controls.Add(this.panel3);
            this.panel_NewCourse.Controls.Add(this.button_Delete);
            this.panel_NewCourse.Controls.Add(this.button_Update);
            this.panel_NewCourse.Controls.Add(this.textBox_CourseCredit);
            this.panel_NewCourse.Controls.Add(this.label4);
            this.panel_NewCourse.Controls.Add(this.label_Hour);
            this.panel_NewCourse.Controls.Add(this.textBox_Hour);
            this.panel_NewCourse.Controls.Add(this.textBox_CourseName);
            this.panel_NewCourse.Controls.Add(this.label_CourseName);
            this.panel_NewCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_NewCourse.Location = new System.Drawing.Point(0, 326);
            this.panel_NewCourse.Name = "panel_NewCourse";
            this.panel_NewCourse.Size = new System.Drawing.Size(934, 285);
            this.panel_NewCourse.TabIndex = 24;
            // 
            // comboBox_semester
            // 
            this.comboBox_semester.FormattingEnabled = true;
            this.comboBox_semester.Location = new System.Drawing.Point(10, 250);
            this.comboBox_semester.Name = "comboBox_semester";
            this.comboBox_semester.Size = new System.Drawing.Size(243, 29);
            this.comboBox_semester.TabIndex = 85;
            // 
            // label_hr
            // 
            this.label_hr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_hr.AutoSize = true;
            this.label_hr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_hr.Location = new System.Drawing.Point(12, 232);
            this.label_hr.Name = "label_hr";
            this.label_hr.Size = new System.Drawing.Size(78, 19);
            this.label_hr.TabIndex = 84;
            this.label_hr.Text = "Semester";
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.BackColor = System.Drawing.Color.Orange;
            this.button_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(451, 235);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(156, 44);
            this.button_Clear.TabIndex = 40;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseCode.Location = new System.Drawing.Point(10, 92);
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(527, 27);
            this.textBox_CourseCode.TabIndex = 39;
            this.textBox_CourseCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_CourseCode
            // 
            this.label_CourseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CourseCode.AutoSize = true;
            this.label_CourseCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CourseCode.Location = new System.Drawing.Point(12, 70);
            this.label_CourseCode.Name = "label_CourseCode";
            this.label_CourseCode.Size = new System.Drawing.Size(121, 19);
            this.label_CourseCode.TabIndex = 38;
            this.label_CourseCode.Text = "Course Code : ";
            this.label_CourseCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 15);
            this.panel3.TabIndex = 37;
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(775, 235);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(156, 44);
            this.button_Delete.TabIndex = 36;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(613, 235);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(156, 44);
            this.button_Update.TabIndex = 35;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_CourseCredit
            // 
            this.textBox_CourseCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseCredit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseCredit.Location = new System.Drawing.Point(10, 144);
            this.textBox_CourseCredit.Multiline = true;
            this.textBox_CourseCredit.Name = "textBox_CourseCredit";
            this.textBox_CourseCredit.Size = new System.Drawing.Size(243, 33);
            this.textBox_CourseCredit.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Course Credit\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_Hour
            // 
            this.label_Hour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Hour.AutoSize = true;
            this.label_Hour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Hour.Location = new System.Drawing.Point(12, 180);
            this.label_Hour.Name = "label_Hour";
            this.label_Hour.Size = new System.Drawing.Size(166, 19);
            this.label_Hour.TabIndex = 28;
            this.label_Hour.Text = "CourseHours/Week : ";
            this.label_Hour.Click += new System.EventHandler(this.label_Hour_Click);
            // 
            // textBox_Hour
            // 
            this.textBox_Hour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Hour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Hour.Location = new System.Drawing.Point(10, 202);
            this.textBox_Hour.Name = "textBox_Hour";
            this.textBox_Hour.Size = new System.Drawing.Size(243, 27);
            this.textBox_Hour.TabIndex = 22;
            this.textBox_Hour.TextChanged += new System.EventHandler(this.textBox_Hour_TextChanged);
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CourseName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CourseName.Location = new System.Drawing.Point(10, 40);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(527, 27);
            this.textBox_CourseName.TabIndex = 23;
            this.textBox_CourseName.TextChanged += new System.EventHandler(this.textBox_CourseName_TextChanged);
            // 
            // label_CourseName
            // 
            this.label_CourseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CourseName.AutoSize = true;
            this.label_CourseName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CourseName.Location = new System.Drawing.Point(12, 18);
            this.label_CourseName.Name = "label_CourseName";
            this.label_CourseName.Size = new System.Drawing.Size(127, 19);
            this.label_CourseName.TabIndex = 20;
            this.label_CourseName.Text = "Course Name : ";
            this.label_CourseName.Click += new System.EventHandler(this.label_CourseName_Click);
            // 
            // DataGridView_Course
            // 
            this.DataGridView_Course.AllowUserToAddRows = false;
            this.DataGridView_Course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Course.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Course.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Course.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Course.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Course.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Course.EnableHeadersVisualStyles = false;
            this.DataGridView_Course.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Course.Location = new System.Drawing.Point(0, 109);
            this.DataGridView_Course.Name = "DataGridView_Course";
            this.DataGridView_Course.RowHeadersVisible = false;
            this.DataGridView_Course.RowTemplate.Height = 80;
            this.DataGridView_Course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Course.Size = new System.Drawing.Size(933, 203);
            this.DataGridView_Course.TabIndex = 23;
            this.DataGridView_Course.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Course.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Course.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Course.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Course.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Course.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Course.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Course.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Course.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Course.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Course.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_Course.ThemeStyle.ReadOnly = false;
            this.DataGridView_Course.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Course.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Course.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Course.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Course.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_Course.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Course.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Course_CellContentClick);
            this.DataGridView_Course.Click += new System.EventHandler(this.DataGridView_Course_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(616, 62);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(156, 27);
            this.textBox_Search.TabIndex = 64;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.Orange;
            this.button_Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(778, 59);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(156, 44);
            this.button_Search.TabIndex = 63;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_NewCourse);
            this.Controls.Add(this.DataGridView_Course);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_NewCourse.ResumeLayout(false);
            this.panel_NewCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_NewCourse;
        private System.Windows.Forms.Panel panel_NewCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_CourseCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Hour;
        private System.Windows.Forms.TextBox textBox_Hour;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.Label label_CourseName;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Course;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.Label label_CourseCode;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_semester;
        private System.Windows.Forms.Label label_hr;
    }
}