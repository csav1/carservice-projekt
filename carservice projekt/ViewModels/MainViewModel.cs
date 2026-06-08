using carservice_projekt.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using carservice_projekt.ViewModels;

namespace carservice_projekt.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _titel;

        public string Titel
        {
            get { return _titel; }
            set
            {
                _titel = value;
                OnPropertyChanged(nameof(Titel));
            }
        }

        public ObservableCollection<Fahrzeug> Fahrzeuge { get; set; }

        public MainViewModel()
        {
            Titel = "CarService Manager";

            using (var context = new CarServiceContext())
            {
                Fahrzeuge = new ObservableCollection<Fahrzeug>(
                    context.Fahrzeuge.ToList());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}