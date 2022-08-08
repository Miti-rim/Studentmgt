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
    public partial class LogoForm : Form
    {
        StudentClass student = new StudentClass();
        public LogoForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
             if(textBox_Username.Text==""|| textBox_Password.Text=="")
            {
                MessageBox.Show("Need Login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_Username.Text;
                string pass = textBox_Password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password`= '" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    var value = table.Rows[0][3].ToString();

                    if (value == "Student")
                    {
                        mGlobal.isStudent = true;
                    }
                    else
                    {
                        mGlobal.isStudent = false;
                    }
                    MainForm main = new MainForm();
                    
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void LogoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
