using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Studentmgt
{
    public partial class RegistrationForm : Form
    {
        StudentClass student = new StudentClass();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        //To show student list in DatagirdView
        public void showTable()
        {
            DataGridView_Student.DataSource = student.getStudentList(new MySqlCommand("SELECT * FROM `student`"));
           // DataGridView_Student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_Student.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_upload_Click(object sender, EventArgs e)
        {

            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_Student.Image = Image.FromFile(opf.FileName);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //add new student
            int id = Convert.ToInt32(textBox_stdId.Text);
            string fname = textBox_Fname.Text;
            string lname = textBox_Lname.Text;
            DateTime bdate = dateTimePicker.Value;
            string phone = textBox_Phone.Text;
            string sm = comboBox_semester.Text;
            string sess = comboBox_session.Text;
            string address = textBox_Address.Text;
            string gender = radioButton_Male.Checked ? "Male" : "Female";


            // need to check student age between 10 and 100

            int born_Year = dateTimePicker.Value.Year;
            int this_Year = DateTime.Now.Year;
            if ((this_Year - born_Year) < 10 || (this_Year - born_Year) > 100)
            {
                MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    //to get photo from picture box
                    MemoryStream ms = new MemoryStream();
                    pictureBox_Student.Image.Save(ms, pictureBox_Student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, sm, sess, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //create a function to verify
        bool verify()
        {
            if ((textBox_stdId.Text == "") ||
                (textBox_Fname.Text == "") || (textBox_Lname.Text == "") ||
                (textBox_Phone.Text == "") || (textBox_Address.Text == "") ||
                (comboBox_semester.Text == "") || (comboBox_session.Text == "") ||
                (pictureBox_Student.Image == null))
            {
                return false;
            }
            else
                return true;
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdId.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_Phone.Clear();
            textBox_Address.Clear();

            radioButton_Male.Checked = true;
            dateTimePicker.Value = DateTime.Now;
            pictureBox_Student.Image = null;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_Registration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_Student_Click(object sender, EventArgs e)
        {
            //textBox_Id.Text = DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_Student.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView_Student.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker.Value = (DateTime)DataGridView_Student.CurrentRow.Cells[3].Value;
            if (DataGridView_Student.CurrentRow.Cells[4].Value.ToString() == "Male")
                radioButton_Male.Checked = true;

            textBox_Phone.Text = DataGridView_Student.CurrentRow.Cells[5].Value.ToString();
            comboBox_semester.Text = DataGridView_Student.CurrentRow.Cells[7].Value.ToString();
            comboBox_session.Text = DataGridView_Student.CurrentRow.Cells[8].Value.ToString();

            textBox_Address.Text = DataGridView_Student.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_Student.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_Student.Image = Image.FromStream(ms);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Student_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_semester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    //internal class MemoryStream
    //{
    //}
}
