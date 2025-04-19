using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Student_Management_System
{
    /*
     * In this class create the connection between application and mysql database
     * we need to install xampp and mysql connector to this project
     * we need to create the student database
     */
    internal class DBconnect
    {
        //to create connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studentdb");

        //go get connection
        public MySqlConnection getConnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to open connection
        public void openConnect()
        {
            if(connect.State == System.Data.ConnectionState.Closed) 
                connect.Open();
        }

        //create a function to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }


    }
}
