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
    public partial class MainForm : Form
    {
        StudentClass student = new StudentClass();
       

        public MainForm()
        {

            InitializeComponent();
            customizeDesign();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        //create a function to display student count
        private void studentCount()
        {
            //Display the  values
            label_totalstd.Text = "Total Students : " + student.totalStudent();
            label_Malestd.Text = "Male : " + student.maleStudent();
            label_Femalestd.Text = "Female : " + student.femaleStudent();


            //Display the semester
            //label_semester.Text = "Select Semester:";
            //label_Malestd.Text = "Male:";
        }

        private void customizeDesign()
        {
            if(mGlobal.isStudent)
            {
             
                button_std.Visible = true;
                
                button_course.Visible = false;
                button_newCourse.Visible = false;
                button_manageCourse.Visible = false;
                button_courseRegistered.Visible = false;
                button_courseprint.Visible = false;

                button_score.Visible = false;
                button_newResult.Visible = false;
                button_manageScore.Visible = false;
                button_scoreprint.Visible = false;

            }
            else
            {
                button_std.Visible = true;
                button_score.Visible = true;
                button_course.Visible = true;
            }

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
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
        }

        
        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        #region stdsubmenu

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    //  your code
        //    hideSubmenu();
        //}

        private void button_admissionStd_Click(object sender, EventArgs e)
        {

            openChildForm(new RegistrationForm());

            //  your code
            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            //  your code
            hideSubmenu();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            openChildForm(new StdCourse_Registration());
            //  your code
            hideSubmenu();
        }

        private void button_stdprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            //  your code
            hideSubmenu();
        }

        #endregion Stdsubmenu

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        #region Coursesubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            //  your code
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            //  your code
            hideSubmenu();
        }
        

        private void button_courseprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            //  your code
            hideSubmenu();
        }

        #endregion CourseSubmenu
        private void button_result_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        #region ScoreSubmenu
        private void button_newResult_Click(object sender, EventArgs e)
        {

            openChildForm(new ScoreForm());
                //  your code
            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScoreForm());
            //  your code
            hideSubmenu();
        }

        private void button_scoreprint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            //  your code
            hideSubmenu();
        }

        #endregion ScoreSubmenu


        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ChildForm);
            panel_main.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }
        private void panel1_Paint_Click(object sender, EventArgs e)
        {

        }

        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();

            //activeForm.MainForm();
            //if (!Utils.FormIsOpen("MainForm"))
            //{
            //    var mainForm = new MainForm();
            //    mainForm.MdiParent = this;
            //    mainForm.Show();
            //}

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            LogoForm login = new LogoForm();
            this.Hide();
            login.Show();
            //if (activeForm != null)
            //    activeForm.Close();
            //panel_main.Controls.Add(panel_cover);
            //studentCount();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_CourseRegistered(object sender, EventArgs e)
        {
            openChildForm(new OptionalCourseForm());

            hideSubmenu();
        }

        private void label_totalstd_Click(object sender, EventArgs e)
        {

        }

        /*private void button_courseRegistered_Click(object sender, EventArgs e)
        {
            openChildForm(new RegCourseForm());
            // your code
            hideSubmenu();
        }*/
    }
}
