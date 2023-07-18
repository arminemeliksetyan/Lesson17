using System.Data.SqlClient;

namespace RegistrationWpf
{
    internal class DataBase
    {        
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=fitst_db;Integrated Security=True");
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
