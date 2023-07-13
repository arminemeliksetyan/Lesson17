using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWpf
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Server=DESKTOP-QCOA7R0\SQLEXPRESS;Database=first_db;Trusted_Connection=True;");
        public void OpenConnection() 
        { 
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection() 
        {
            return sqlConnection;
        }
    }
}
