using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmgt
{
    class ScoreClass
    {
        DBConnect connect = new DBConnect();
        //create a function add score
        public bool insertScore(int stdid, string sm, string cName,  string _filename, byte[] contents, string sess)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`,`Semester`, `CourseName`, `Result`, `_filename`, `Session`) VALUES (@stdid, @sm, @cName, @contents, @_filename, @sess)", connect.getconnection);
            //@sid,@cn,@sco,@desc
            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@contents", MySqlDbType.Blob).Value = contents;
            command.Parameters.Add("@_filename", MySqlDbType.VarChar).Value = _filename;
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
        //create a function to get list
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getList(string sess, string  sm , string course)
        {
            var cmd = new MySqlCommand("SELECT score.`StudentId`, student.`StdFirstName`, student.`StdLastName`, student.`Semester`, score.`CourseName`, score.`_filename`, score.`Session` FROM student INNER JOIN score ON score.`StudentId`=student.`StdId` WHERE score.`Semester` LIKE  @sm AND score.`CourseName` LIKE @course AND score.`Session` LIKE @sess");
            
            cmd.Parameters.AddWithValue("@sess", "%" + sess + "%");
            cmd.Parameters.AddWithValue("@sm", "%" + sm + "%");
            cmd.Parameters.AddWithValue("@course", "%" + course + "%");

            cmd.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

           /* if (string.IsNullOrEmpty(Extension) && string.IsNullOrEmpty(CourseName))
            {
                sql = @"select * from FileDetails where FileName like CONCAT('%',@FileName,'%')";
                datas = Connection.Query<FileDetails>(
                    sql,
                    param: new { FileName = FileName },
                    transaction: Transaction
                ).ToList();
            }
            else if (string.IsNullOrEmpty(Extension) || Extension == "Type")
            {
                sql = @"select * from FileDetails where FileName like CONCAT('%',@FileName,'%') AND CourseName = @CourseName";
                datas = Connection.Query<FileDetails>(
                    sql,
                    param: new { FileName = FileName, CourseName = CourseName },
                    transaction: Transaction
                ).ToList();
            }
            else if (string.IsNullOrEmpty(CourseName) || CourseName == "Select...")
            {
                sql = @"select * from FileDetails where FileName like CONCAT('%',@FileName,'%') AND Extension = @Extension";
                datas = Connection.Query<FileDetails>(
                    sql,
                    param: new { FileName = FileName, Extension = Extension },
                    transaction: Transaction
                ).ToList();
            }
            else
            {
                sql = @"select * from FileDetails where FileName like CONCAT('%',@FileName,'%') AND Extension = @Extension AND CourseName = @CourseName";
                datas = Connection.Query<FileDetails>(
                    sql,
                    param: new { FileName = FileName, Extension = Extension, CourseName = CourseName },
                    transaction: Transaction
                ).ToList();
            }*/

        }

        //create a function to check alraedy course score
        public bool checkScore(int StdId)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `score` WHERE `StudentId`= "+  StdId));
            if(table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public DataTable getScore(int StdId)
        {
            DataTable table = getList(new MySqlCommand("SELECT `_filename`,`Result` FROM `score` WHERE `StudentId`= " + StdId));

            return table;
        }

        /*internal bool updateScore(int stdId, byte[] contents, string _filename, string desc)
        {
            throw new NotImplementedException();
        }*/

        //Create  a function to edit a score

        //int StdId = Convert.ToInt32(textBox_StdId.Text);

        public bool updateScore(int StdId, string sm, string cName, string _filename, byte[] contents,  string sess)
        {
            //AND `CourseName`=@scn
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Semester`=@sm, `CourseName`=@cName, `Result`=@contents, `_filename`=@_filename, `Session`=@sess WHERE `StudentId`=@StdId ", connect.getconnection);

            command.Parameters.Add("@StdId", MySqlDbType.Int32).Value = StdId;
            command.Parameters.Add("@sm", MySqlDbType.VarChar).Value = sm;
            command.Parameters.Add("@cName", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@_filename", MySqlDbType.VarChar).Value = _filename;

            command.Parameters.Add("@contents", MySqlDbType.Blob).Value = contents;
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
        //create a function to delete a score data
        public bool deleteScore(int StdId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentId`=@StdId", connect.getconnection);

            //@id
            command.Parameters.Add("@StdId", MySqlDbType.Int32).Value = StdId;

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
    }
}
