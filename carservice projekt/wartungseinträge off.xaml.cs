using System;
using System.Collections.Generic;
using System.Windows;

namespace carservice_projekt
{
    
    public partial class wartungseinträge_off : Window
    {

        public List<string[]> gespeicherteEinträge = new List<string[]>();


        public wartungseinträge_off()
        {
            InitializeComponent();

            LadeMarke();

            LadeServicearten();
        }


        private void LadeMarke()
        {
            
            txtmarke.Items.Clear();

            txtmarke.Items.Add("Mercedes-Benz");

            txtmarke.Items.Add("BMW");

            txtmarke.Items.Add("Audi");

            txtmarke.Items.Add("Volkswagen");

            txtmarke.Items.Add("Opel");

            txtmarke.Items.Add("Ford");

            txtmarke.Items.Add("Tesla");

            txtmarke.Items.Add("Renault");

            txtmarke.Items.Add("Skoda");

            txtmarke.Items.Add("Hyundai");
        }

        private void LadeServicearten()
        {
            
            cmbServicearten.Items.Clear();

            cmbServicearten.Items.Add("Ölwechsel");

            cmbServicearten.Items.Add("TÜV");

            cmbServicearten.Items.Add("Inspektion");

            cmbServicearten.Items.Add("Bremsenwechsel");

            cmbServicearten.Items.Add("Reifenwechsel");

            cmbServicearten.Items.Add("Klimaservice");

            cmbServicearten.Items.Add("Batteriaustausch");

            cmbServicearten.Items.Add("Motorcheck");
        }

        private void BtnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtmarke.SelectedItem == null ||

                cmbServicearten.SelectedItem == null ||

                !dpDatum.SelectedDate.HasValue ||

                !decimal.TryParse(txtKosten.Text, out decimal kosten))
            {
                MessageBox.Show("Bitte alle Felder korrekt ausfüllen!");
                return;
            }


            string marke = txtmarke.SelectedItem.ToString();

            string serviceart = cmbServicearten.SelectedItem.ToString();

            string datum = dpDatum.SelectedDate.Value.ToShortDateString();

            string kostenStr = kosten.ToString("0.00");

            string status = (checkboxStatus.IsChecked == true) ? "Erledigt" : "Offen";

            string[] wartung = { marke, serviceart, datum, kostenStr, status };
            gespeicherteEinträge.Add(wartung);


            MessageBox.Show(
            "Die Wartungsdaten wurden erfolgreich gespeichert und stehen nun zur Verfügung.",
            "Vorgang abgeschlossen",
                MessageBoxButton.OK,
            MessageBoxImage.Information);


            txtmarke.SelectedIndex = -1;

            cmbServicearten.SelectedIndex = -1;

            dpDatum.SelectedDate = null;
            txtKosten.Clear();
            checkboxStatus.IsChecked = false;
        }

        private void Weiter_Click(object sender, RoutedEventArgs e)
        {
            
            einträge_anzeige fenster = new einträge_anzeige(gespeicherteEinträge);
            fenster.Show();
            this.Close();
        }
    }
}
