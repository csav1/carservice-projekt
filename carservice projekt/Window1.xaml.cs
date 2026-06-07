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

namespace carservice_projekt
{
    
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            List<Fahrzeug> fahrzeuge = new List<Fahrzeug>()
    {
        new Fahrzeug { Marke="Mercedes-Benz", Modell="C220" },
        new Fahrzeug { Marke="BMW", Modell="3er" },
        new Fahrzeug { Marke="Audi", Modell="A4" },
        new Fahrzeug { Marke="Volkswagen", Modell="Passat" }
    };

            dgFahrzeuge.ItemsSource = fahrzeuge;
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            wartungseinträge fahrzeugview = new wartungseinträge();
            fahrzeugview.Show();
            this.Close();
            
        }
    }
}
