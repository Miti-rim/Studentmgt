using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentmgt
{
    public partial class StdCourse_Registration : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        StdCRegClass stdcoursereg = new StdCRegClass();

        public StdCourse_Registration()
        {
            InitializeComponent();
        }

       
       
        //create a function to show data on stdCourseReg
        private void stdCourseReg()
        {
            //DataGridView_Student.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT * FROM stdcoursereg.StdId, student.StdFirstname, student.StdLastName, stdcoursereg.CourseCode, stdcoursereg.Semester, stdcoursereg.Session FROM student INNER JOIN stdcoursereg ON stdcoursereg.StdtId=student.StdId"));
            DataGridView_Student.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT * FROM `stdcoursereg`"));

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

       private void StdCourse_Registration_Load(object sender, EventArgs e)
        {
            ComboBox_CourseCode.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            ComboBox_CourseCode.DisplayMember = "CourseCode";
            ComboBox_CourseCode.ValueMember = "CourseCode";
            //showstudent();
            comboBox_semester.DataSource = course.getCourse(new MySqlCommand("SELECT DISTINCT Semester  FROM `course`"));
            comboBox_semester.DisplayMember = "Semester";
            comboBox_semester.ValueMember = "Semester";

            ComboBox_Sess.DataSource = student.getStudent(new MySqlCommand("SELECT * FROM `student`"));
            ComboBox_Sess.DisplayMember = "Session";
            ComboBox_Sess.ValueMember = "Session";

            // to show data on stdcoursereg
            stdCourseReg();
            //to display std
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));

            ShowStdCourseReg();
        }

        public void ShowStdCourseReg()
        {
            DataGridView_Student.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT * FROM `stdcoursereg`"));

        }

        private void DataGridView_Student_Click(object sender, EventArgs e)
        {
            textBox_StdId.Text = DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
            ComboBox_CourseCode.DisplayMember = DataGridView_Student.CurrentRow.Cells[1].ToString();
            comboBox_semester.DisplayMember = DataGridView_Student.CurrentRow.Cells[2].ToString();
            ComboBox_Sess.DisplayMember = DataGridView_Student.CurrentRow.Cells[3].ToString();


        }

        /*private void showCourse()
        {
            DataGridView_CourseReg.DataSource = student.getList(new MySqlCommand("SELECT student.`StdId`, student.`StdFirstName`, student.`StdLastName`, course.`CourseCode`, student.`Semester`, student.`Batch` FROM student INNER JOIN course ON student.`Semester`=course.`Semester`"));
        }
        */
        /* private void DataGridView_CourseReg_Click(object sender, EventArgs e)
         {
             textBox_StdId.Text = DataGridView_CourseReg.CurrentRow.Cells[0].Value.ToString();
             textBox_Fname.Text = DataGridView_CourseReg.CurrentRow.Cells[1].Value.ToString();
             textBox_Lname.Text = DataGridView_CourseReg.CurrentRow.Cells[2].Value.ToString();
             checkedListBox_Course.Text = DataGridView_CourseReg.CurrentRow.Cells[3].ToString();
             ComboBox_Semester.Text = DataGridView_CourseReg.CurrentRow.Cells[4].ToString();
             ComboBox_Batch.Text = DataGridView_CourseReg.CurrentRow.Cells[5].ToString();

         }*/

        private void DataGridView_CourseReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        /*private void StdCourse_Registration_Click(object sender, EventArgs e)
        {
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));

        }*/

        private void StdCourse_Registration_Load_1(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_StdId.Clear();
           
            ComboBox_CourseCode.SelectedIndex = 0;
            comboBox_semester.SelectedIndex = 0;
            ComboBox_Sess.SelectedIndex = 0;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "" || ComboBox_CourseCode.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int StdId = Convert.ToInt32(textBox_StdId.Text);
                string cCode = ComboBox_CourseCode.Text;
                string sm = comboBox_semester.Text;
                string sess = ComboBox_Sess.Text;
                
                if(!stdcoursereg.checkStdcoursereg(StdId, cCode))
                { 

                        if (stdcoursereg.insertStdcoursereg(StdId, cCode, sm, sess))
                        {
                            showData();
                            //stdCourseReg();
                            button_Clear.PerformClick();
                            MessageBox.Show("New course added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Course not inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
               else
                {
                    MessageBox.Show("The course is already exists", "Add course",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_stdcoursereg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_sStudent_Click(object sender, EventArgs e)
        {
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));

        }

        private void button_sCourse_Click(object sender, EventArgs e)
        {
            stdCourseReg();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "" || ComboBox_CourseCode.Text == "" || comboBox_semester.Text == "" || ComboBox_Sess.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int StdId = Convert.ToInt32(textBox_StdId.Text);
                string cCode = ComboBox_CourseCode.Text;
                string sm = comboBox_semester.Text;
                string sess = ComboBox_Sess.Text;
                //if(!stdcoursereg.checkStdcoursereg(StdId, cCode))
                //{

                    if (stdcoursereg.updateStdcoursereg(StdId, cCode, sm, sess))
                    {
                        ShowStdCourseReg();
                        //stdCourseReg();
                        button_Clear.PerformClick();
                        MessageBox.Show("Course edited complete", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Course not edited", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               // }

            }
        }
        private void showData()
        {
            //to show course list on datagridview
            DataGridView_Student.DataSource = stdcoursereg.getStdcoursereg(new MySqlCommand("SELECT * FROM `stdcoursereg`"));
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_StdId.Text == "")
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //try
                //{
                    int StdId = Convert.ToInt32(textBox_StdId.Text);
                    if(MessageBox.Show("Are you want to remove this course", "Remove Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (stdcoursereg.deleteStdcoursereg(StdId))
                        {
                            DataGridView_Student.DataSource = null;
                            showData();
                            button_Clear.PerformClick();
                            MessageBox.Show("course Deleted", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

               // }
                //catch (Exception ex)
                //{
                   // MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
        }

        /*private void cuctomizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }*/
        private void button_AdmitCard_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintAdmitCardForm());
           // hideSubmenu();
        }

        //private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            /*if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            button_AdmitCard.Controls.Add(ChildForm);
            button_AdmitCard.Tag = ChildForm;
            ChildForm.BringToFront();*/
            ChildForm.Show();


        }

        /*private void openChildForm(PrintAdmitCardForm printAdmitCardForm)
        {
            throw new NotImplementedException();
        }*/
    }
}
