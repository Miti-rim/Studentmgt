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
    public partial class OptionalCourseForm : Form
    {
        CourseClass regcourse = new CourseClass();
        public OptionalCourseForm()
        {
            InitializeComponent();
        }

        private void RegCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            //to show course list on datagridview
            DataGridView_RegCourse.DataSource = regcourse.getRegCourse(new MySqlCommand("SELECT * FROM `regcourse`"));
        }

        private void button_ClearR_Click(object sender, EventArgs e)
        {
            textBox_CourseName.Clear();
            textBox_CourseCode.Clear();
            textBox_CourseCredit.Clear();
            textBox_CourseHour.Clear();
           // TextBox_semester.Clear();
            textBox_CourseHour.Clear();
        }
        private void button_addR_Click(object sender, EventArgs e)
        {
            if (textBox_CourseName.Text == "" || textBox_CourseCode.Text == "" ||  textBox_CourseCredit.Text == "" || textBox_CourseHour.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cName = textBox_CourseName.Text;
                string cCode = textBox_CourseCode.Text;
                int cCredit = Convert.ToInt32(textBox_CourseCredit.Text);
                int chr = Convert.ToInt32(textBox_CourseHour.Text);
                string sm = comboBox_semester.Text;
                string op = textBox_option.Text;
                



                if (regcourse.insertRegCourse(cCode, cName, cCredit, chr, sm, op))
                {
                    showData();
                    button_ClearR.PerformClick();
                    MessageBox.Show("New optional course insert", "Add optional Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Optional Course not insert", "Add Optional Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_RegCourse_Click(object sender, EventArgs e)
        {
            
        }

        private void button_UpdateR_Click(object sender, EventArgs e)
        {
            if (textBox_CourseName.Text == "" || textBox_CourseCode.Text == "" || textBox_CourseCredit.Text == "" || textBox_CourseHour.Text.Equals(""))
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cCode = textBox_CourseCode.Text;
                string cName = textBox_CourseName.Text;
                int cCredit = Convert.ToInt32(textBox_CourseCredit.Text);
                int chr = Convert.ToInt32(textBox_CourseHour.Text);
                string sm = comboBox_semester.Text;
                string op = textBox_option.Text;


                if (regcourse.updateRegCourse(cCode, cName, cCredit, chr, sm, op))
                {
                    showData();
                    button_ClearR.PerformClick();
                    MessageBox.Show("course update successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error-Course not Edit", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridView_RegCourse_Click_1(object sender, EventArgs e)
        {
            textBox_CourseCode.Text = DataGridView_RegCourse.CurrentRow.Cells[0].Value.ToString();
            textBox_CourseName.Text = DataGridView_RegCourse.CurrentRow.Cells[1].Value.ToString();
            textBox_CourseCredit.Text = DataGridView_RegCourse.CurrentRow.Cells[2].Value.ToString();
            textBox_CourseHour.Text = DataGridView_RegCourse.CurrentRow.Cells[3].Value.ToString();
            comboBox_semester.Text = DataGridView_RegCourse.CurrentRow.Cells[4].Value.ToString();
            textBox_option.Text = DataGridView_RegCourse.CurrentRow.Cells[5].Value.ToString();


        }

        private void button_UpdateR_Click_1(object sender, EventArgs e)
        {

        }

        private void DataGridView_RegCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
