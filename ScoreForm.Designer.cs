
using System;

namespace Studentmgt
{
    partial class ScoreForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Crs = new System.Windows.Forms.ComboBox();
            this.comboBox_Btc = new System.Windows.Forms.ComboBox();
            this.comboBox_Smst = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.button_sScore = new System.Windows.Forms.Button();
            this.button_sStudent = new System.Windows.Forms.Button();
            this.panel_NewCourse = new System.Windows.Forms.Panel();
            this.ComboBox_Session = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox_Semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_CName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_CName = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.textBox_StdId = new System.Windows.Forms.TextBox();
            this.label_StdId = new System.Windows.Forms.Label();
            this.DataGridView_Student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel_NewCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_Crs);
            this.panel1.Controls.Add(this.comboBox_Btc);
            this.panel1.Controls.Add(this.comboBox_Smst);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Semester);
            this.panel1.Controls.Add(this.button_sScore);
            this.panel1.Controls.Add(this.button_sStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 53);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Session";
            // 
            // comboBox_Crs
            // 
            this.comboBox_Crs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Crs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Crs.FormattingEnabled = true;
            this.comboBox_Crs.Items.AddRange(new object[] {
            "Computer Programming and Algorithm",
            "Advanced Web Tecnologies",
            "Database Architecture and Administration",
            "E-Governance",
            "Machine Learning",
            "Computer Networking and Internetworking",
            "Option 01",
            "Project 01",
            "Information and Cyber Security",
            "Software Engineering and Management",
            "Option 02",
            "Project 02"});
            this.comboBox_Crs.Location = new System.Drawing.Point(573, 21);
            this.comboBox_Crs.Name = "comboBox_Crs";
            this.comboBox_Crs.Size = new System.Drawing.Size(172, 25);
            this.comboBox_Crs.TabIndex = 8;
            // 
            // comboBox_Btc
            // 
            this.comboBox_Btc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Btc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Btc.FormattingEnabled = true;
            this.comboBox_Btc.Items.AddRange(new object[] {
            "2018-19",
            "2019-20",
            "2020-21"});
            this.comboBox_Btc.Location = new System.Drawing.Point(380, 22);
            this.comboBox_Btc.Name = "comboBox_Btc";
            this.comboBox_Btc.Size = new System.Drawing.Size(74, 25);
            this.comboBox_Btc.TabIndex = 7;
            // 
            // comboBox_Smst
            // 
            this.comboBox_Smst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Smst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Smst.FormattingEnabled = true;
            this.comboBox_Smst.Items.AddRange(new object[] {
            "M3",
            "M2",
            "M1"});
            this.comboBox_Smst.Location = new System.Drawing.Point(470, 22);
            this.comboBox_Smst.Name = "comboBox_Smst";
            this.comboBox_Smst.Size = new System.Drawing.Size(85, 25);
            this.comboBox_Smst.TabIndex = 6;
            this.comboBox_Smst.SelectedIndexChanged += new System.EventHandler(this.comboBox_Smst_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course";
            // 
            // Semester
            // 
            this.Semester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(474, 0);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(78, 19);
            this.Semester.TabIndex = 4;
            this.Semester.Text = "Semester";
            // 
            // button_sScore
            // 
            this.button_sScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sScore.BackColor = System.Drawing.Color.White;
            this.button_sScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_sScore.Location = new System.Drawing.Point(785, 17);
            this.button_sScore.Name = "button_sScore";
            this.button_sScore.Size = new System.Drawing.Size(137, 32);
            this.button_sScore.TabIndex = 1;
            this.button_sScore.Text = "Show Result";
            this.button_sScore.UseVisualStyleBackColor = false;
            this.button_sScore.Click += new System.EventHandler(this.button_sScore_Click);
            // 
            // button_sStudent
            // 
            this.button_sStudent.BackColor = System.Drawing.Color.White;
            this.button_sStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_sStudent.Location = new System.Drawing.Point(20, 12);
            this.button_sStudent.Name = "button_sStudent";
            this.button_sStudent.Size = new System.Drawing.Size(137, 32);
            this.button_sStudent.TabIndex = 0;
            this.button_sStudent.Text = "Show Student";
            this.button_sStudent.UseVisualStyleBackColor = false;
            this.button_sStudent.Click += new System.EventHandler(this.button_sStudent_Click);
            // 
            // panel_NewCourse
            // 
            this.panel_NewCourse.Controls.Add(this.ComboBox_Session);
            this.panel_NewCourse.Controls.Add(this.ComboBox_Semester);
            this.panel_NewCourse.Controls.Add(this.label1);
            this.panel_NewCourse.Controls.Add(this.ComboBox_CName);
            this.panel_NewCourse.Controls.Add(this.label_CName);
            this.panel_NewCourse.Controls.Add(this.textBox_Result);
            this.panel_NewCourse.Controls.Add(this.button_upload);
            this.panel_NewCourse.Controls.Add(this.panel3);
            this.panel_NewCourse.Controls.Add(this.button_add);
            this.panel_NewCourse.Controls.Add(this.button_clear);
            this.panel_NewCourse.Controls.Add(this.label4);
            this.panel_NewCourse.Controls.Add(this.label_Score);
            this.panel_NewCourse.Controls.Add(this.textBox_StdId);
            this.panel_NewCourse.Controls.Add(this.label_StdId);
            this.panel_NewCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_NewCourse.Location = new System.Drawing.Point(0, 284);
            this.panel_NewCourse.Name = "panel_NewCourse";
            this.panel_NewCourse.Size = new System.Drawing.Size(934, 327);
            this.panel_NewCourse.TabIndex = 24;
            this.panel_NewCourse.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_NewCourse_Paint);
            // 
            // ComboBox_Session
            // 
            this.ComboBox_Session.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Session.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Session.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Session.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Session.FocusedState.Parent = this.ComboBox_Session;
            this.ComboBox_Session.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboBox_Session.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Session.HoverState.Parent = this.ComboBox_Session;
            this.ComboBox_Session.ItemHeight = 30;
            this.ComboBox_Session.Items.AddRange(new object[] {
            "2018-19",
            "2019-20",
            "2020-21"});
            this.ComboBox_Session.ItemsAppearance.Parent = this.ComboBox_Session;
            this.ComboBox_Session.Location = new System.Drawing.Point(149, 262);
            this.ComboBox_Session.Name = "ComboBox_Session";
            this.ComboBox_Session.ShadowDecoration.Parent = this.ComboBox_Session;
            this.ComboBox_Session.Size = new System.Drawing.Size(403, 36);
            this.ComboBox_Session.TabIndex = 52;
            // 
            // ComboBox_Semester
            // 
            this.ComboBox_Semester.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Semester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Semester.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Semester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Semester.FocusedState.Parent = this.ComboBox_Semester;
            this.ComboBox_Semester.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboBox_Semester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Semester.HoverState.Parent = this.ComboBox_Semester;
            this.ComboBox_Semester.ItemHeight = 30;
            this.ComboBox_Semester.Items.AddRange(new object[] {
            "M1",
            "M2",
            "M3"});
            this.ComboBox_Semester.ItemsAppearance.Parent = this.ComboBox_Semester;
            this.ComboBox_Semester.Location = new System.Drawing.Point(149, 79);
            this.ComboBox_Semester.Name = "ComboBox_Semester";
            this.ComboBox_Semester.ShadowDecoration.Parent = this.ComboBox_Semester;
            this.ComboBox_Semester.Size = new System.Drawing.Size(403, 36);
            this.ComboBox_Semester.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(45, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Semester : ";
            // 
            // ComboBox_CName
            // 
            this.ComboBox_CName.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_CName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_CName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_CName.FocusedState.Parent = this.ComboBox_CName;
            this.ComboBox_CName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboBox_CName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_CName.HoverState.Parent = this.ComboBox_CName;
            this.ComboBox_CName.ItemHeight = 30;
            this.ComboBox_CName.Items.AddRange(new object[] {
            "Computer Programming and Algorithm",
            "Advanced Web Tecnologies",
            "Database Architecture and Administration",
            "E-Governance",
            "Computer Networking and Internetworking",
            "Machine Learning",
            "Option 01",
            "Project 01",
            "Information and Cyber Sequrity",
            "Software Engineering and Management",
            "Option 02",
            "Project 02"});
            this.ComboBox_CName.ItemsAppearance.Parent = this.ComboBox_CName;
            this.ComboBox_CName.Location = new System.Drawing.Point(149, 139);
            this.ComboBox_CName.Name = "ComboBox_CName";
            this.ComboBox_CName.ShadowDecoration.Parent = this.ComboBox_CName;
            this.ComboBox_CName.Size = new System.Drawing.Size(403, 36);
            this.ComboBox_CName.TabIndex = 49;
            this.ComboBox_CName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Course_SelectedIndexChanged);
            // 
            // label_CName
            // 
            this.label_CName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CName.AutoSize = true;
            this.label_CName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CName.Location = new System.Drawing.Point(20, 139);
            this.label_CName.Name = "label_CName";
            this.label_CName.Size = new System.Drawing.Size(123, 19);
            this.label_CName.TabIndex = 42;
            this.label_CName.Text = "CourseName : ";
            this.label_CName.Click += new System.EventHandler(this.label_CName_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(311, 203);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(241, 27);
            this.textBox_Result.TabIndex = 41;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(149, 194);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(156, 44);
            this.button_upload.TabIndex = 40;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(1, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 15);
            this.panel3.TabIndex = 37;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.Color.OrangeRed;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(766, 277);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(156, 44);
            this.button_add.TabIndex = 36;
            this.button_add.Text = "Add Result";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.Orange;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(604, 277);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(156, 44);
            this.button_clear.TabIndex = 35;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(61, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Session : \r\n";
            // 
            // label_Score
            // 
            this.label_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Score.Location = new System.Drawing.Point(79, 211);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(64, 19);
            this.label_Score.TabIndex = 28;
            this.label_Score.Text = "Result : ";
            // 
            // textBox_StdId
            // 
            this.textBox_StdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_StdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StdId.Location = new System.Drawing.Point(149, 38);
            this.textBox_StdId.Name = "textBox_StdId";
            this.textBox_StdId.Size = new System.Drawing.Size(403, 27);
            this.textBox_StdId.TabIndex = 23;
            this.textBox_StdId.TextChanged += new System.EventHandler(this.textBox_StdId_TextChanged);
            // 
            // label_StdId
            // 
            this.label_StdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_StdId.AutoSize = true;
            this.label_StdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_StdId.Location = new System.Drawing.Point(38, 42);
            this.label_StdId.Name = "label_StdId";
            this.label_StdId.Size = new System.Drawing.Size(97, 19);
            this.label_StdId.TabIndex = 20;
            this.label_StdId.Text = "Student Id : ";
            this.label_StdId.Click += new System.EventHandler(this.label_StdId_Click);
            // 
            // DataGridView_Student
            // 
            this.DataGridView_Student.AllowUserToAddRows = false;
            this.DataGridView_Student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Student.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Student.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Student.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Student.EnableHeadersVisualStyles = false;
            this.DataGridView_Student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Student.Location = new System.Drawing.Point(0, 59);
            this.DataGridView_Student.Name = "DataGridView_Student";
            this.DataGridView_Student.RowHeadersVisible = false;
            this.DataGridView_Student.RowTemplate.Height = 80;
            this.DataGridView_Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Student.Size = new System.Drawing.Size(931, 225);
            this.DataGridView_Student.TabIndex = 23;
            this.DataGridView_Student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Student.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Student.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Student.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_Student.ThemeStyle.ReadOnly = false;
            this.DataGridView_Student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Student.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_Student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Student_CellContentClick);
            this.DataGridView_Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Student_CellContentClick_1);
            this.DataGridView_Student.Click += new System.EventHandler(this.DataGridView_Student_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_NewCourse);
            this.Controls.Add(this.DataGridView_Student);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScoreForm";
            this.Text = "SecureForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_NewCourse.ResumeLayout(false);
            this.panel_NewCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Student)).EndInit();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_NewCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.TextBox textBox_StdId;
        private System.Windows.Forms.Label label_StdId;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Student;
        private System.Windows.Forms.Button button_sStudent;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_sScore;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_CName;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_CName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Semester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.ComboBox comboBox_Crs;
        private System.Windows.Forms.ComboBox comboBox_Btc;
        private System.Windows.Forms.ComboBox comboBox_Smst;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Session;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}