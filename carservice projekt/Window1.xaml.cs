using carservice_projekt.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace carservice_projekt
{
    
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            LadeFahrzeuge();

           
        }

        private void LadeFahrzeuge()
        {
            List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();

            string connectionString =
                @"Server=.\SQLEXPRESS;Database=CarServiceDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT Marke, Modell FROM Fahrzeuge";

                    SqlCommand command = new SqlCommand(sql, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        fahrzeuge.Add(new Fahrzeug
                        {
                            Marke = reader["Marke"].ToString(),

                            Modell = reader["Modell"].ToString()
                        });
                    }
                }

                dgFahrzeuge.ItemsSource = fahrzeuge;

                DateiSpeicher speicher = new DateiSpeicher();
                speicher.Speichern(fahrzeuge);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Fahrzeuge:\n" + ex.Message);
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wartungseinträge fahrzeugview = new wartungseinträge();

            fahrzeugview.Show();
            this.Close();
            
        }

       
    }
}
