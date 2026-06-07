using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using static carservice_projekt.wartungseinträge;

namespace carservice_projekt
{
    
    public partial class wartungseinträge : Window
    {
       

        public wartungseinträge()
        {
            InitializeComponent();
        }

        private void Speichern1(object sender, RoutedEventArgs e)
        {
            string marke = txtMarke.Text;

            string modell = txtModell.Text;

            string baujahr = txtBaujahr.Text;

            string kennzeichen = txtKennzeichen.Text;


            if (string.IsNullOrWhiteSpace(marke) || string.IsNullOrWhiteSpace(modell) ||

                string.IsNullOrWhiteSpace(baujahr) || string.IsNullOrWhiteSpace(kennzeichen))
            {
                MessageBox.Show("Bitte alle Felder korrekt ausfüllen!");
                return;
            }


            lblStatus.Content = "Fahrzeug erfolgreich gespeichert!";

            txtMarke.Clear();

            txtModell.Clear();

            txtBaujahr.Clear();

            txtKennzeichen.Clear();
        }

        private void BtnWeiter_Click(object sender, RoutedEventArgs e)
        {
            
            wartungseinträge_off nextWindow = new wartungseinträge_off();
            nextWindow.Show();
            this.Close();
        }

    }

}
