using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using carservice_projekt.ViewModels;

namespace carservice_projekt
{
    
    
    public partial class MainWindow : Window

    {

        private string connectionString = @"Server=.\SQLEXPRESS;Database=CarServiceDB;Trusted_Connection=True;";

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT TOP 10 Marke FROM Fahrzeuge";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string marke = reader["Marke"].ToString();
                        
                    }
                }

                Window1 dashboard = new Window1();
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }


    }
}