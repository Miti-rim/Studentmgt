
namespace Studentmgt
{
    partial class ManageScoreForm
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
            this.DataGridView_Score = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_Clear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_NewCourse = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_NewCourse = new System.Windows.Forms.Panel();
            this.ComboBox_session = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox_Course = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_CName = new System.Windows.Forms.Label();
            this.ComboBox_Semester = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.textBox_StdId = new System.Windows.Forms.TextBox();
            this.label_StdId = new System.Windows.Forms.Label();
            this.ManageScoreUploadButton = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_NewCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Location = new System.Drawing.Point(616, 62);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(156, 27);
            this.textBox_Search.TabIndex = 69;
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
            this.button_Search.TabIndex = 68;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // DataGridView_Score
            // 
            this.DataGridView_Score.AllowUserToAddRows = false;
            this.DataGridView_Score.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Score.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Score.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Score.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Score.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Score.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Score.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Score.EnableHeadersVisualStyles = false;
            this.DataGridView_Score.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Score.Location = new System.Drawing.Point(3, 109);
            this.DataGridView_Score.Name = "DataGridView_Score";
            this.DataGridView_Score.RowHeadersVisible = false;
            this.DataGridView_Score.RowTemplate.Height = 80;
            this.DataGridView_Score.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Score.Size = new System.Drawing.Size(928, 211);
            this.DataGridView_Score.TabIndex = 66;
            this.DataGridView_Score.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Score.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Score.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Score.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Score.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Score.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Score.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Score.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Score.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Score.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Score.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Score.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Score.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_Score.ThemeStyle.ReadOnly = false;
            this.DataGridView_Score.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Score.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Score.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Score.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Score.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_Score.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Score.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Score.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Score_CellContentClick);
            this.DataGridView_Score.Click += new System.EventHandler(this.DataGridView_Score_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.BackColor = System.Drawing.Color.Orange;
            this.button_Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.Location = new System.Drawing.Point(698, 185);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(156, 44);
            this.button_Clear.TabIndex = 40;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(3, 5);
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
            // label_NewCourse
            // 
            this.label_NewCourse.AutoSize = true;
            this.label_NewCourse.Location = new System.Drawing.Point(363, 19);
            this.label_NewCourse.Name = "label_NewCourse";
            this.label_NewCourse.Size = new System.Drawing.Size(123, 19);
            this.label_NewCourse.TabIndex = 0;
            this.label_NewCourse.Text = "Manage Result";
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
            this.panel1.TabIndex = 65;
            // 
            // panel_NewCourse
            // 
            this.panel_NewCourse.Controls.Add(this.ComboBox_session);
            this.panel_NewCourse.Controls.Add(this.ComboBox_Course);
            this.panel_NewCourse.Controls.Add(this.label_CName);
            this.panel_NewCourse.Controls.Add(this.ComboBox_Semester);
            this.panel_NewCourse.Controls.Add(this.label1);
            this.panel_NewCourse.Controls.Add(this.label4);
            this.panel_NewCourse.Controls.Add(this.label_Score);
            this.panel_NewCourse.Controls.Add(this.textBox_StdId);
            this.panel_NewCourse.Controls.Add(this.label_StdId);
            this.panel_NewCourse.Controls.Add(this.button_Clear);
            this.panel_NewCourse.Controls.Add(this.panel3);
            this.panel_NewCourse.Controls.Add(this.button_Delete);
            this.panel_NewCourse.Controls.Add(this.button_Update);
            this.panel_NewCourse.Controls.Add(this.ManageScoreUploadButton);
            this.panel_NewCourse.Controls.Add(this.textBox_Result);
            this.panel_NewCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_NewCourse.Location = new System.Drawing.Point(0, 326);
            this.panel_NewCourse.Name = "panel_NewCourse";
            this.panel_NewCourse.Size = new System.Drawing.Size(934, 285);
            this.panel_NewCourse.TabIndex = 67;
            // 
            // ComboBox_session
            // 
            this.ComboBox_session.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_session.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_session.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_session.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_session.FocusedState.Parent = this.ComboBox_session;
            this.ComboBox_session.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboBox_session.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_session.HoverState.Parent = this.ComboBox_session;
            this.ComboBox_session.ItemHeight = 30;
            this.ComboBox_session.Items.AddRange(new object[] {
            "2018-19",
            "2019-20",
            "2020-21"});
            this.ComboBox_session.ItemsAppearance.Parent = this.ComboBox_session;
            this.ComboBox_session.Location = new System.Drawing.Point(140, 218);
            this.ComboBox_session.Name = "ComboBox_session";
            this.ComboBox_session.ShadowDecoration.Parent = this.ComboBox_session;
            this.ComboBox_session.Size = new System.Drawing.Size(426, 36);
            this.ComboBox_session.TabIndex = 56;
            // 
            // ComboBox_Course
            // 
            this.ComboBox_Course.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Course.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Course.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Course.FocusedState.Parent = this.ComboBox_Course;
            this.ComboBox_Course.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ComboBox_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Course.HoverState.Parent = this.ComboBox_Course;
            this.ComboBox_Course.ItemHeight = 30;
            this.ComboBox_Course.Items.AddRange(new object[] {
            "Computer Programming and Algorithm",
            "Advanced Web Tecnologies",
            "Database Architecture and Administration",
            "E-Governance",
            "Computer Network and Internetworking",
            "Machine Learning",
            "Option 01",
            "Project 01",
            "Information and Cyber Security",
            "Software Engineering and Management",
            "Option 02",
            "Project 02"});
            this.ComboBox_Course.ItemsAppearance.Parent = this.ComboBox_Course;
            this.ComboBox_Course.Location = new System.Drawing.Point(140, 110);
            this.ComboBox_Course.Name = "ComboBox_Course";
            this.ComboBox_Course.ShadowDecoration.Parent = this.ComboBox_Course;
            this.ComboBox_Course.Size = new System.Drawing.Size(426, 36);
            this.ComboBox_Course.TabIndex = 55;
            // 
            // label_CName
            // 
            this.label_CName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_CName.AutoSize = true;
            this.label_CName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_CName.Location = new System.Drawing.Point(11, 114);
            this.label_CName.Name = "label_CName";
            this.label_CName.Size = new System.Drawing.Size(123, 19);
            this.label_CName.TabIndex = 54;
            this.label_CName.Text = "CourseName : ";
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
            this.ComboBox_Semester.Location = new System.Drawing.Point(140, 68);
            this.ComboBox_Semester.Name = "ComboBox_Semester";
            this.ComboBox_Semester.ShadowDecoration.Parent = this.ComboBox_Semester;
            this.ComboBox_Semester.Size = new System.Drawing.Size(426, 36);
            this.ComboBox_Semester.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Semester : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(17, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Session : \r\n";
            // 
            // label_Score
            // 
            this.label_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Score.Location = new System.Drawing.Point(28, 165);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(64, 19);
            this.label_Score.TabIndex = 44;
            this.label_Score.Text = "Result : ";
            // 
            // textBox_StdId
            // 
            this.textBox_StdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_StdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StdId.Location = new System.Drawing.Point(140, 35);
            this.textBox_StdId.Name = "textBox_StdId";
            this.textBox_StdId.Size = new System.Drawing.Size(426, 27);
            this.textBox_StdId.TabIndex = 43;
            // 
            // label_StdId
            // 
            this.label_StdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_StdId.AutoSize = true;
            this.label_StdId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_StdId.Location = new System.Drawing.Point(17, 39);
            this.label_StdId.Name = "label_StdId";
            this.label_StdId.Size = new System.Drawing.Size(97, 19);
            this.label_StdId.TabIndex = 41;
            this.label_StdId.Text = "Student Id : ";
            // 
            // ManageScoreUploadButton
            // 
            this.ManageScoreUploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ManageScoreUploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ManageScoreUploadButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageScoreUploadButton.ForeColor = System.Drawing.Color.White;
            this.ManageScoreUploadButton.Location = new System.Drawing.Point(140, 156);
            this.ManageScoreUploadButton.Name = "ManageScoreUploadButton";
            this.ManageScoreUploadButton.Size = new System.Drawing.Size(144, 44);
            this.ManageScoreUploadButton.TabIndex = 49;
            this.ManageScoreUploadButton.Text = "Upload";
            this.ManageScoreUploadButton.UseVisualStyleBackColor = false;
            this.ManageScoreUploadButton.Click += new System.EventHandler(this.ManageScoreUploadButton_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Result.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(290, 165);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(276, 27);
            this.textBox_Result.TabIndex = 42;
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.DataGridView_Score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_NewCourse);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Score)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_NewCourse.ResumeLayout(false);
            this.panel_NewCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Score;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_NewCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_NewCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_StdId;
        private System.Windows.Forms.Label label_StdId;
        private System.Windows.Forms.Button ManageScoreUploadButton;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Semester;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Course;
        private System.Windows.Forms.Label label_CName;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_session;
    }
}