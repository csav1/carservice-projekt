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
using carservice_projekt.ViewModels;

namespace carservice_projekt
{
    
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void LadeFahrzeuge()
        {
            try
            {
                using (var context = new CarServiceContext())
                {
                    var fahrzeuge = context.Fahrzeuge.ToList();

                    dgFahrzeuge.ItemsSource = fahrzeuge;

                    DateiSpeicher speicher = new DateiSpeicher();
                    speicher.Speichern(fahrzeuge);
                }
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
