using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegistrationWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase dataBase = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.MaxLength = 50;
            login.MaxLength = 50;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginUser = login.Text.Trim();
            var passwordUser = password.Text.Trim();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryString = $"select id, login_user, password_user from first_db login_user = '{loginUser}' and password_user = '{passwordUser}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Sucsess", " wow", MessageBoxButton.OK);
            }
        }
    }
}
