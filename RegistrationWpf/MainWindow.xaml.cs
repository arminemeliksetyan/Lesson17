using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.MaxLength = 50;
            login.MaxLength = 50;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginUser = login.Text;
            var passwordUser = password.Text;
            dataBase.OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string queryString = $"select id, login, password from first_db where login = '{loginUser}' and password = '{passwordUser}'";            
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());            
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if(dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Sucsess", " wow", MessageBoxButton.OK);
                Window1 window1 = new Window1();
                this.Hide();
                window1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Return", " ups", MessageBoxButton.OK);
            }
            dataBase.CloseConnection();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Sign_up sign_Up = new Sign_up();
            sign_Up.Show();
            this.Hide();
        }
    }
}
