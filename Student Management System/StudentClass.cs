using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Student_Management_System
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();
        //create a function to add a new students to the database

        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] image)
        {
            MySqlCommand command = new MySqlCommand(
        "INSERT INTO `student` (`StdFirstName`, `StdLastName`, `Birthdate`, `Gender`, `Phone`, `Adress`, `Photo`) VALUES (@fn,@ln,@bd,@gd,@ph,@adr,@img)",
        connect.getConnection
    );


            //@fn,@ln,@db,@gd,@ph,@adr,@img
            command.Parameters.Add("@fn",MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln",MySqlDbType.VarChar).Value=lname;
            command.Parameters.Add("@bd",MySqlDbType.Date).Value=bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = image ?? (object)DBNull.Value;

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

        //to get student table
        public DataTable getStudentlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
        //create a function to excute the count query
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getConnection);
            connect.openConnect() ;
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        //to get the total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }

        //to get the male student count
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender` = 'Male'");
        }

        //to get the male student count
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE `Gender` = 'Female'");
        }

        //create a function search for student (first name, last name, address)
        public DataTable SearchStudentlist(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`StdFirstName`,`StdLastName`,`Adress`) LIKE '%"+ searchData +"%'", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create function for update student
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] image)
        {
            MySqlCommand command = new MySqlCommand(
        "UPDATE `student` SET `StdFirstName`=@fn,`StdLastName`=@ln,`Birthdate`=@db,`Phone`=@ph,`Gender`=@gd,`Adress`=@adr,`Photo`=@img WHERE `StdId`= @id",
        connect.getConnection
    );

            //@id,@fn,@ln,@db,@gd,@ph,@adr,@img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = image ?? (object)DBNull.Value;

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
