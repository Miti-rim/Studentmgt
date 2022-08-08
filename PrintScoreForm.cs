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
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        DGVPrinter Printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DataGridView_Score.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`CourseName`, score.`Result`,score.`LastResult`, score.`Session` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId` WHERE CONCAT(student.`StdFirstName`, student.`StdLastName`, score.`CourseName`)LIKE '%" + textBox_Search.Text + "%'"));

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper forprint pdf file
            Printer.Title = "IICT Students Result List";
            Printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "IICT";
            Printer.FooterSpacing = 15;
            Printer.printDocument.DefaultPageSettings.Landscape = true;
            Printer.PrintDataGridView(DataGridView_Score);
        }

        private void DataGridView_Score_Click(object sender, EventArgs e)
        {
            showScore();
        }
        //to  show score list
        public void showScore()
        {
            DataGridView_Score.DataSource = score.getList(new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, score.`_filename`, score.`Session` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId`"));

        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScore();
        }

        private void DataGridView_Score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
