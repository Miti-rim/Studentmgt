using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Studentmgt
{
    class StudentClass
    {
        DBConnect connect = new DBConnect();
        //create a function to add a new students to the database

        public bool insertStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string sm, string sess, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `Student` (`StdId`, `StdFirstName`, `StdLastName`, `Birthdate`, `Gender`, `Phone`, `Semester`, `Session`, `Address`, `Photo`) VALUES(@id, @fn, @ln, @bd, @gd,  @ph, @sm, @sess, @adr, @img)", connect.getconnection);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@sess", MySqlDbType.VarChar).Value = sess;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;


            connect.openConnect();

            if(command.ExecuteNonQuery() == 1)
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

       // internal object getCourse(MySqlCommand mySqlCommand)
        //{
           // throw new NotImplementedException();
       // }

        public DataTable getStudent(MySqlCommand command)
         {
             command.Connection = connect.getconnection;
             MySqlDataAdapter adapter = new MySqlDataAdapter(command);
             DataTable table = new DataTable();
             adapter.Fill(table);
             return table;
         }

        /*internal object getStudent(MySqlCommand mySqlCommand)
        {
            throw new NotImplementedException();
        }*/

    

        //to get student table
        public DataTable getStudentList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Create a function to execute the count query
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;

        }

        //to get to



        //to get the total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }
        //to get the male student count
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender`= 'Male'");
        }
        //to get the female student count
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender`= 'Female'");
        }
        //create a function search for student (first name, last name, address)
        public DataTable searchStudentList(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`StdFirstName`,`StdLastName`, `Address`) LIKE '%"+ searchdata +"%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function edit for student
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string sm, string sess, string address, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `StdFirstName`=@fn, `StdLastName`=@ln, `Birthdate`=@bd, `Gender`=@gd, `Phone`= @ph, `Semester`=@sm, `Session`=@sess, `Address`=@adr, `Photo`=@img WHERE `StdId`=@id", connect.getconnection);

            //@id, @fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@sess", MySqlDbType.VarChar).Value = sess;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;


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
        //Create a fuction to delete a course*****************
        //we only need course id
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `StdId`=@id", connect.getconnection);

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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
        //create a function for any command in studentDb
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
