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
using DGVPrinterHelper;

namespace Studentmgt
{
    public partial class PrintCourseForm : Form
    {
        CourseClass Course = new CourseClass();
        DGVPrinter Printer = new DGVPrinter();
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //To Search course and show on datagridview
            DataGridView_Course.DataSource = Course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%" + textBox_Search.Text + "%'"));
            textBox_Search.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper forprint pdf file
            Printer.Title = "IICT Students List";
            Printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "IICT";
            Printer.FooterSpacing = 15;
            Printer.printDocument.DefaultPageSettings.Landscape = true;
            Printer.PrintDataGridView(DataGridView_Course);
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            DataGridView_Course.DataSource = Course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
