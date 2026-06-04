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

namespace carservice_projekt
{
    
        public partial class einträge_anzeige : Window
        {


        public einträge_anzeige(List<string[]> gespeicherteEinträge)
        {
            InitializeComponent();

            foreach (var eintrag in gespeicherteEinträge)
            {
                lstWartungen.Items.Add(new
                {
                    txtmarke = eintrag[0],

                    cmbServicearten = eintrag[1],

                    dpDatum = eintrag[2],

                    txtKosten = eintrag[3],

                    Status = eintrag[4]
                });
            }
        }


        private void Hauptmenü_Click(object sender, RoutedEventArgs e)
        {

            MainWindow hauptmenü = new MainWindow();  
            hauptmenü.Show();

            
            this.Close();
        }
    }
}
