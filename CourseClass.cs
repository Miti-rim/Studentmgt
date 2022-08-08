using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Studentmgt
{
    //: CourseClassBase
    class CourseClass 
    {
        DBConnect connect = new DBConnect();
        //create a function to insert course
        public bool insertCourse(string cCode, string cName, int cCredit, int chr, string sm)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course` (`StdId`, `CourseCode`, `CourseName`, `CourseCredit`, `CreditHours_Week`, `Semester`, `Option`) VALUES (@StdId, @cCode, @cName, @cCredit, @chr, @sm, @op)", connect.getconnection);
            //@cCode, @cName, @cCredit, @hr
            //command.Parameters.Add("@StdId", MySqlDbType.VarChar).Value = StdId;
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cCredit", MySqlDbType.Int32).Value = cCredit;
            command.Parameters.Add("@chr", MySqlDbType.Int32).Value = chr;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;



            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }
        //create a function to get course list
        public DataTable getCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function to add course which are already registered //override
        public bool insertRegCourse(string cCode, string cName, int cCredit, int chr, string sm, string op)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `regcourse` (`CourseCode`, `CourseName`, `CourseCredit`, `CreditHours_Week`, `Semester`, `Option`) VALUES (@cCode,@cName,@cCredit,@chr,@sm,@op)", connect.getconnection);
            //@cn, @ch, @desc
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cCredit", MySqlDbType.Int32).Value = cCredit;
            command.Parameters.Add("@chr", MySqlDbType.Int32).Value = chr;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@op", MySqlDbType.VarChar).Value = op;


            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;  
             }
        }
        //create a function to get course list
        public DataTable getRegCourse(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //
        public bool updateRegCourse(string cCode, string cName, int cCredit, int chr, string sm, string op)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `regcourse` SET `CourseName`=@cName, `CourseCode`=@cCode, `CourseCredit`=@cCredit, `CreditHours_Week`= @chr, `Semester`= @sm, `Option`=@op WHERE `Option`= @op", connect.getconnection);
            //@id @cn, @ch, @desc
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cCredit", MySqlDbType.Int32).Value = cCredit;
            command.Parameters.Add("@chr", MySqlDbType.Int32).Value = chr;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@op", MySqlDbType.VarChar).Value = op;


            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }
        //create a update function for course edit
        public bool updateCourse(string cCode, string cName, int cCredit, int chr, string sm)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `CourseName`=@cName, `CourseCredit`=@cCredit, `CreditHours_Week`=@chr, `Semester`=@sm WHERE `CourseCode`=@cCode", connect.getconnection);
            //@id @cn, @ch, @desc
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@cCredit", MySqlDbType.Int32).Value = cCredit;
            command.Parameters.Add("@chr", MySqlDbType.Int32).Value = chr;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;


            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }

        //create a update function  for optional course

        
   

        //Create a fuction to delete a course*****************
        //we only need course id
        public bool deleteCourse(int cCode)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `CourseCode`=@cCode", connect.getconnection);
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        //create a function for search a course
        //public DataTable searchCourse(string searchdata)
        //{
        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%" + searchdata + "%'", connect.getconnection));
        //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    return table;
        //}
    }
}
