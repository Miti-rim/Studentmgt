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
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void label_CourseName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        //Show Data of the course
        private void showData()
        {
            //to show course list on datagridview
            DataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
            textBox_Hour.Clear();
            textBox_CourseCredit.Clear();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_CourseName.Text == "" || textBox_Hour.Text == "" || textBox_CourseCode.Text.Equals(""))
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cCode = textBox_CourseCode.Text;
                string cName = textBox_CourseName.Text;
                int cCredit = Convert.ToInt32(textBox_CourseCredit.Text);
                int chr = Convert.ToInt32(textBox_Hour.Text);
                string sm = comboBox_semester.Text;

                if (course.updateCourse(cCode, cName, cCredit, chr, sm))
                {
                    showData();
                    button_Clear.PerformClick();
                    MessageBox.Show("course update successfuly", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error-Course not Edit", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (textBox_CourseCode.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int cCode = Convert.ToInt32(textBox_CourseCode.Text);
                    if (course.deleteCourse(cCode))
                    {
                        showData();
                        button_Clear.PerformClick();
                        MessageBox.Show("course Deleted", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void DataGridView_Course_Click(object sender, EventArgs e)
        {
            textBox_CourseCode.Text = DataGridView_Course.CurrentRow.Cells[0].Value.ToString();
            textBox_CourseName.Text = DataGridView_Course.CurrentRow.Cells[1].Value.ToString();
            textBox_CourseCredit.Text = DataGridView_Course.CurrentRow.Cells[2].Value.ToString();
            textBox_Hour.Text = DataGridView_Course.CurrentRow.Cells[3].Value.ToString();
            comboBox_semester.Text = DataGridView_Course.CurrentRow.Cells[4].Value.ToString();

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE "%python%"
            //To Search course and show on datagridview
            DataGridView_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%"+textBox_Search.Text+"%'"));
            textBox_Search.Clear();
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //return table;

            //DataGridView_Course.DataSource = course.searchCourse(textBox_Search.Text);
            //// DataGridView_Student.RowTemplate.Height = 80;
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)DataGridView_Course.Columns[7];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void label_NewCourse_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_Course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_CourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Hour_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Hour_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
