using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace RegistrationWpf
{
    /// <summary>
    /// Interaction logic for Sign_up.xaml
    /// </summary>
    public partial class Sign_up : Window
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        DataBase dataBase = new DataBase();

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.MaxLength = 50;
            login.MaxLength = 50;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginUser = login.Text;
            var passwordUser = password.Text;

            string querystring = $"insert into first_db ( login, password ) values ( '{loginUser}' , '{passwordUser}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            dataBase.OpenConnection();
            if (checkUser() == false)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You are registered", " wow", MessageBoxButton.OK);
                    MainWindow mainWindow = new MainWindow();
                    this.Hide();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Profile is not created.", "ups", MessageBoxButton.OK);
                }
            }
            dataBase.CloseConnection();
        }

        private Boolean checkUser()
        {
            var loginUser = login.Text;
            var passwordUser = password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            dataBase.OpenConnection();

            string queryString = $"Select id, login, password from first_db where login = '{loginUser}' and password = '{passwordUser}'";

            SqlCommand sqlCommand = new SqlCommand(queryString, dataBase.GetConnection());

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("We already registered", "ups", MessageBoxButton.OK);
                return true;
            }
            else
            {
                return false;
            }

            dataBase.CloseConnection();
        }
    }
}
