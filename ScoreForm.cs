using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentmgt
{
    public partial class ScoreForm : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        private string _filename = "";
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
            //loadDataInGrid();
        }

        //create a fuction to show data on datagridview score
        private void showScore()
        {
            //DataGridView_Student.DataSource = score.getList(tBoxSemester.Text, tBoxCourse.Text);
            DataGridView_Student.DataSource = score.getList(comboBox_Btc.Text, comboBox_Smst.Text, comboBox_Crs.Text);


            //try
            //{
            //    if (!String.IsNullOrEmpty(tBoxSemester.Text) && !String.IsNullOrEmpty(tBoxCourse.Text))
            //    {
            //        DataGridView_Student.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`CourseName`, score.`_filename`, score.`Description` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId` WHERE score.Semester like " + tBoxSemester.Text + "AND score.CourseName like " + tBoxCourse.Text));

            //    }


            //    else if (String.IsNullOrEmpty(tBoxSemester.Text) && String.IsNullOrEmpty(tBoxCourse.Text))
            //    {

            //        DataGridView_Student.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`CourseName`, score.`_filename`, score.`Description` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId`"));

            //    }

            //    else if (!String.IsNullOrEmpty(tBoxSemester.Text))
            //    {
            //        DataGridView_Student.DataSource = score.getList(tBoxSemester.Text, tBoxCourse.Text);

            //    }

            //    else if (!String.IsNullOrEmpty(tBoxCourse.Text))
            //    {
            //        DataGridView_Student.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`CourseName`, score.`_filename`, score.`Description` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId` WHERE score.CourseName like " + tBoxCourse.Text));

            //    }
            //}
            //catch (Exception ex)
            //{

            //    ;
            //}


            //DataGridView_Student.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`CourseName`, score.`_filename`, score.`Description` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId`"));
            //Prepare SQL query      
            //string SearchData = textBox_search.Text;

            //string Query = "SELECT *FROM score WHERE"
        }

        private void label_StdId_Click(object sender, EventArgs e)
        {
            
        }

        private void loadDataInGrid()
        {
            using (MySqlConnection cn = new MySqlConnection("Data Source=localhost;Initial Catalog=studentdb;Integrated Security=True"))
            //using (MySqlConnection cn = new MySqlConnection("Server = localhost; port = 3306; Database = studentdb; Integrated Security=True"))

            {

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    //
                    cmd.CommandText = "SELECT [stdId],[StdFirstName],[StdLastName],[Semester],[CourseName],[_filename],[Description] AS score,[Result] FROM score";
                    cmd.Connection = cn;
                    cn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)

                    {

                        DataTable dt = new DataTable();

                        dt.Load(reader);

                        DataGridView_Student.DataSource = dt;

                    }
                }

            }
        }

            private void ScoreForm_Load(object sender, EventArgs e)
            {
            //populate the combobox with courses name
            //checkedListBox_Course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            //checkedListBox_Course.DisplayMember = "CourseName";
            //checkedListBox_Course.ValueMember = "CourseName";

            ComboBox_CName.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            ComboBox_CName.DisplayMember = "CourseName";
            ComboBox_CName.ValueMember = "CourseName";

            ComboBox_Semester.DataSource = course.getCourse(new MySqlCommand("SELECT DISTINCT Semester  FROM `course`"));
            //ComboBox_Semester.DataSource = course.getCourse(new MySqlCommand("SELECT *  FROM `course`"));

            ComboBox_Semester.DisplayMember = "Semester";
            ComboBox_Semester.ValueMember = "Semester";

            ComboBox_Session.DataSource = student.getStudent(new MySqlCommand("SELECT * FROM `student`"));
            ComboBox_Session.DisplayMember = "Session";
            ComboBox_Session.ValueMember = "Session";


            //to show data on score datagridview
            //showScore();
            //To Display the student list on Datagridview
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));
            }

        private void DataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string loadedFileName = "";
            if (e.RowIndex > -1)
            {
                int stdId = Int32.Parse(DataGridView_Student.Rows[e.RowIndex].Cells[0].Value.ToString());

                //(OpenFileDialog opf= new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF|*.pdf"})
                //{
                    //if(opf.ShowDialog() == DialogResult.OK)
                   // {
                        //axAcroPDF.src = opf.FileName;
                        //textBox_StdId.Text = opf.FileName;
                        //DataGridView_Student_Click() = opf.FileName;

                        //DataTable dt = new DataTable();

                        //dt.Load(reader);

                        //Retrieve the PDF file from the data table
                        //byte[] buffer = (byte[])dt.Rows[0]["Data"];
                        //loadedFileName = dt.Rows[0]["Name"].ToString();

                        //int stdId = Int32.Parse(DataGridView_Student.Rows[e.RowIndex].Cells[0].Value.ToString());

                    //}
                //}

                //using (MySqlConnection cn = new MySqlConnection("Data Source=localhost;Initial Catalog=studentdb;Integrated Security=True"))
                //using (MySqlConnection cn = new MySqlConnection("Server = localhost; port = 3306; Database = studentdb; Integrated Security=True"))

                //{

                    //using (MySqlCommand cmd = new MySqlCommand())
                    //{
                        //cmd.CommandText = "SELECT Name,Data FROM score where stdId=@stdId";
                        //cmd.Parameters.AddWithValue("@stdId", stdId);
                        //cmd.Connection = cn;
                        //cn.Open();

                        //MySqlDataReader reader = cmd.ExecuteReader();

                        //if (reader.HasRows)

                        //{

                            //DataTable dt = new DataTable();

                            //dt.Load(reader);

                            //Retrieve the PDF file from the data table
                            //byte[] buffer = (byte[])dt.Rows[0]["Data"];
                            //loadedFileName = dt.Rows[0]["Name"].ToString();
                            //Save the PDF file
                            //using (FileStream fstream = new FileStream(loadedFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                            //{
                                //fstream.Write(buffer, 0, buffer.Length);
                            //}
                            //System.Diagnostics.Process.Start(loadedFileName);

                       //}
                    //}

                //}
            
            }


        }


        private void button_add_Click(object sender, EventArgs e)
        {
            showScore();
            if (textBox_StdId.Text == "" || button_upload.Text == "")
            {
                MessageBox.Show("Need Score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int StdId = Convert.ToInt32(textBox_StdId.Text);
                //string cName = checkedListBox_Course.Text;
                string cName = ComboBox_CName.Text;
                string sm = ComboBox_Semester.Text;
                // int scor = Convert.ToInt32(textBox_Score.Text);
                string sess = ComboBox_Session.Text;

                string _filename = "pdf";
                _filename = textBox_Result.Text;
                

                if (!score.checkScore(StdId))
                {
                    //cn.Open();
                    //FileStream fStream = File.OpenRead(filename);
                    

                    FileStream fStream = File.OpenRead(_filename);
                   
                    byte[] contents = new byte[fStream.Length];
                    fStream.Read(contents, 0, (int)fStream.Length);
                    fStream.Close();

                    _filename = Path.GetFileName(_filename);
                    if (score.insertScore(StdId, sm, cName,  _filename, contents, sess))
                    {

                        showScore();
                        button_clear.PerformClick();
                        MessageBox.Show("New Result added", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Result not added", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The Result for this course already exits", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_StdId.Clear();
            textBox_Result.Clear();
            ComboBox_CName.SelectedIndex = 0;
            ComboBox_Semester.SelectedIndex = 0;
            // ComboBox_Batch.SelectIndex = 0;
            ComboBox_Session.SelectedIndex = 0;
            //listBoxItems.

        }

        private void DataGridView_Student_Click(object sender, EventArgs e)
        {
            textBox_StdId.Text = DataGridView_Student.CurrentRow.Cells[0].Value.ToString();


        }

        private void button_sStudent_Click(object sender, EventArgs e)
        {
            DataGridView_Student.DataSource = student.getList(new MySqlCommand("SELECT `StdId`, `StdFirstName`, `StdLastName` FROM `student`"));

        }

        private void button_sScore_Click(object sender, EventArgs e)
        {
            showScore();
            /*var data = _unitOfWork.CourseForm.GetDataTable(button_sScore.Text, ComboBox_Course.SelectedItem.ToString());
            //c_Service.GetDataTable(tBoxSearch.Text);

            if (data.Rows.Count > 0)
            {
                //setStatus(data.Rows.Count + " record found", Color.Blue);
                dViewClientDetails.DataSource = data;
            }
            else
            {
                DataGridView_Student.DataSource = null;
                //setStatus("No record found", Color.Red);
            }*/
        }

        private void textBox_StdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            //string _filename = "pdf";
            //opf.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            //opf.Filter = "PDF (*.pdf|*.pdf)";
            //opf.FileName = "_filename";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                _filename = opf.FileName;
                
                

                textBox_Result.Text = _filename;

                //UploadFIleinSQL(_filename);
            }
        }



        private void DataGridView_Student_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //this.scoreTableAdapter.Fill(this.studentdb.score);
            //ComboBox_Course.SelectedIndex = 1;
            
            string loadedFileName = "";

            if (e.RowIndex > -1)
            {
                //DataGridViewRow row = this.DataGridView_Student.Rows[e.RowIndex];


                int stdId = Int32.Parse(DataGridView_Student.Rows[e.RowIndex].Cells[0].Value.ToString());
                var dt = score.getScore(stdId);

                if(dt.Rows.Count > -1)
                {
                    byte[] buffer = (byte[])dt.Rows[0]["Result"];
                    loadedFileName = dt.Rows[0]["_filename"].ToString();
                    //Save the PDF file
                    using (FileStream fstream = new FileStream(loadedFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        fstream.Write(buffer, 0, buffer.Length);
                    }
                    System.Diagnostics.Process.Start(loadedFileName);
                }

            }
        }

        private void checkedListBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_CName_Click(object sender, EventArgs e)
        {

        }

        private void panel_NewCourse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Smst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox_search.Text))
                    scoreBindingSource.Filter = string.Empty;
                else
                    scoreBindingSource.Filter = string.Format("{0} = '{3}'", ComboBox_Course.Text,textBox_search.Text);
            }
        }*/

        /* private void DataGridView_Student_DoubleClick(object sender, EventArgs e)
         {
             if (e.RowIndex >= 0)
             {

                 DataGridViewRow row = this.DataGridView_Student.Rows[e.RowIndex];

                 //string[] addresssplit = row.Cells["Path"].Value.ToString().Split(',');
                 SelectedFilePath = row.Cells["Path"].Value.ToString();
                 System.Diagnostics.Process.Start(row.Cells["Path"].Value.ToString());

                 btnDownload.Enabled = true;
             }

         }*/
    }
}
