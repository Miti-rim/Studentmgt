using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmgt
{
    class StdCRegClass
    {
        DBConnect connect = new DBConnect();
        //create a function to add stdcoursereg
        public bool insertStdcoursereg(int StdId, string cCode, string sm, string sess)
        {
            
            //Create function to add course
            MySqlCommand command = new MySqlCommand("INSERT INTO `stdcoursereg` (`StdId`, `CourseCode`, `Semester`, `Session`, `Approved`) VALUES (@StdId, @cCode, @sm, @sess, @isApproved)", connect.getconnection);
            //@cCode, @cName, @cCredit, @hr
            command.Parameters.Add("@StdId", MySqlDbType.Int32).Value = StdId;
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@sess", MySqlDbType.VarChar).Value = sess;
            command.Parameters.Add("@isApproved", MySqlDbType.VarChar).Value = false;


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
        //create a function to get list
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //update
        public DataTable getStdcoursereg(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //to create a function to check already course
        public bool checkStdcoursereg(int StdId, string cCode)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `stdcoursereg` WHERE `StdId`='" + StdId +"' AND `CourseCode`= '"+ cCode +"'"));
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //create a function to edit course data
        public bool updateStdcoursereg(int StdId, string cCode, string sm, string sess)
        {
            //Create function to add course
            // MySqlCommand command = new MySqlCommand("INSERT INTO `stdcoursereg` (`StdId`, `CourseCode`, `Semester`, `Session`) VALUES (@StdId, @cCode, @sm, @sess)", connect.getconnection);
            MySqlCommand command = new MySqlCommand("UPDATE `stdcoursereg` SET `Semester`=@sm, `Session`=@sess WHERE `StdId`=@StdId AND `CourseCode`=@cCode", connect.getconnection);

            //@cCode, @cName, @cCredit, @hr
            command.Parameters.Add("@StdId", MySqlDbType.Int32).Value = StdId;
            command.Parameters.Add("@cCode", MySqlDbType.VarChar).Value = cCode;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@sess", MySqlDbType.VarChar).Value = sess;

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

        /*internal bool updateStdcoursereg(int stdId, string cCode, string sm, string sess)
        {
            throw new NotImplementedException();
        }*/

        //create a function to delete a course data
        public bool deleteStdcoursereg(int StdId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `stdcoursereg` WHERE `StdId`=@StdId", connect.getconnection);

            //StdId
            command.Parameters.Add("@StdId", MySqlDbType.Int32).Value = StdId;

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
    }
}
