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
    public partial class PrintAdmitCardForm : Form
    {
        StdCRegClass stdcoursereg = new StdCRegClass();
        DGVPrinter Printer = new DGVPrinter();
        ScoreClass score = new ScoreClass();

        public PrintAdmitCardForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //To Search course and show on datagridview
            //DataGridView_AdmitCard.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseCode`)LIKE '%" + textBox_Search.Text + "%'"));
            DataGridView_AdmitCard.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT * FROM `stdcoursereg`"));

            textBox_Search.Clear();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper forprint pdf file
            Printer.Title = "IICT Student Course Registration List";
            Printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "IICT";
            Printer.FooterSpacing = 15;
            Printer.printDocument.DefaultPageSettings.Landscape = true;
            Printer.PrintDataGridView(DataGridView_AdmitCard);
        }

        private void DataGridView_AdmitCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowStdCourseReg();
        }

        public void ShowStdCourseReg()
        {
            //DataGridView_AdmitCard.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT * FROM `stdcoursereg`"));
            DataGridView_AdmitCard.DataSource = stdcoursereg.getList(new MySqlCommand("SELECT stdcoursereg.`StdId`, stdcoursereg.`CourseCode`, stdcoursereg.`Semester`, stdcoursereg.`Session` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId`"));


        }


    }
}
