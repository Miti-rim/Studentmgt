using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Studentmgt
{
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            //to show course list on datagridview
            DataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void DataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(textBox_CourseName.Text == "" || textBox_Hour.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //int StdId;
                string cCode = textBox_CourseCode.Text;
                string cName = textBox_CourseName.Text;
                int cCredit = Convert.ToInt32(textBox_CourseCredit.Text);
                int chr = Convert.ToInt32(textBox_Hour.Text);
                string sm = comboBox_semester.Text;
                

                if(course.insertCourse(cCode, cName, cCredit, chr, sm))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("New course insert", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Course not insert", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
            textBox_Hour.Clear();
            textBox_CourseCredit.Clear();
        }

        private void panel_NewCourse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
