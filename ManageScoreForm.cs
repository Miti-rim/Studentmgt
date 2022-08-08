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
    public partial class ManageScoreForm : Form
    {
        //CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        private string _filename = "";

        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //populate the combobox with courses name
            //to show score data in datagridview
            showScore();
        }
        public void showScore()
        {
            DataGridView_Score.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, student.`Semester`, score.`CourseName`, score.`_filename`, score.`Session` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId`"));

        }
        private void DataGridView_Score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string loadedFileName = "";
            if (e.RowIndex > -1)
            {
                int StdId = Int32.Parse(DataGridView_Score.Rows[e.RowIndex].Cells[0].Value.ToString());
                var dt = score.getScore(StdId);

                if (dt.Rows.Count > -1)
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


                private void button_Update_Click(object sender, EventArgs e)
                {
                     if (textBox_StdId.Text == "" || ManageScoreUploadButton.Text == "")
                     {
                         MessageBox.Show("Need Score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                //studentId, result, desc, filename

                //int StdId = Convert.ToInt32(textBox_StdId.Text);


                     //if (!score.checkScore(StdId)) { 
                        string sess = ComboBox_session.Text;

                        _filename = textBox_Result.Text;

                        int StdId = Convert.ToInt32(textBox_StdId.Text);
                        string sm = ComboBox_Semester.Text;
                         string cName = ComboBox_Course.Text;

                if (!score.checkScore(StdId))
                {
                    FileStream fStream = File.OpenRead(_filename);
                    byte[] contents = new byte[fStream.Length];
                    fStream.Read(contents, 0, (int)fStream.Length);
                    fStream.Close();

                    _filename = Path.GetFileName(_filename);
                    _filename = textBox_Result.Text;


                    //string desc = textBox_Destription.Text;
                    //if (!score.checkScore(stdId))
                    //{

                    if (score.updateScore(StdId, sm, cName, _filename, contents, sess))
                    {

                        showScore();
                        button_Clear.PerformClick();
                        MessageBox.Show("Score Edited", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Score not edited", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //}
                //else
                //{
                //    MessageBox.Show("The score for this course already exits", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

        }

       /* private void button_upload_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                _filename = opf.FileName;

                textBox_Result.Text = _filename;

                //UploadFIleinSQL(_filename);
            }
        }*/



        private void button_Delete_Click(object sender, EventArgs e)
        {
            
            if(textBox_StdId.Text == "")
            {
                MessageBox.Show("Field Error = we need student id", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int StdId = Convert.ToInt32(textBox_StdId.Text);
                if (MessageBox.Show("Are you sure you want to remove the score", "Delete the Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(StdId))
                    {
                        showScore();
                        MessageBox.Show("Score Removed", "Delete score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_Clear.PerformClick();
                    }
                }

            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_StdId.Clear();
            textBox_Result.Clear();
            //ComboBox_session.Clear();
            textBox_Search.Clear();
        }

        private void DataGridView_Score_Click(object sender, EventArgs e)
        {
            textBox_StdId.Text = DataGridView_Score.CurrentRow.Cells[0].Value.ToString();
            textBox_Result.Text = DataGridView_Score.CurrentRow.Cells[4].Value.ToString();
            ComboBox_session.Text = DataGridView_Score.CurrentRow.Cells[5].Value.ToString();

        }

        private void comboBox_SCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DataGridView_Score.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, student.`Semester`,  score.`CourseName`, score.`Result`, score.`Session` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId` WHERE CONCAT(student.`StdFirstName`, student.`StdLastName`, score.`CourseName`)LIKE '%" + textBox_Search.Text+"%'"));
            //SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`CourseName`, score.`Score`, score.`Description` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId` WHERE CONCAT(student.`StdFirstName`, student.`StdLastName`, score.`CourseName`)LIKE "%Nay%"
        }

       /* private void DataGridView_Score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void ManageScoreUploadButton_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                _filename = opf.FileName;

                textBox_Result.Text = _filename;

                //UploadFIleinSQL(_filename);

            }
        }
    }
}
