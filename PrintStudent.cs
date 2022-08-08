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
using DGVPrinterHelper;

namespace Studentmgt
{
    public partial class PrintStudent : Form
    {
        StudentClass student = new StudentClass();
        DGVPrinter Printer = new DGVPrinter();

        public PrintStudent()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `student`"));
        }
        //create a function to show the student list an datagirdview
        public void showData(MySqlCommand command)
        {
            DataGridView_Student.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //DataGridView_Student.Height = 80;
            DataGridView_Student.DataSource = student.getList(command);
            //column7 is image column index
            imageColumn = (DataGridViewImageColumn)DataGridView_Student.Columns[9];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            //check the radio button
            String selectQuery;
            if (radioButton_All.Checked)
            {
                selectQuery = "SELECT* FROM `STUDENT`";
            }
            else if (radioButton_Male.Checked)
            {
                selectQuery = "SELECT * FROM `student` WHERE `Gender` = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `student` WHERE `Gender` = 'Female'";
            }
            showData(new MySqlCommand(selectQuery));
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
            Printer.PrintDataGridView(DataGridView_Student);


        }
    }
}
