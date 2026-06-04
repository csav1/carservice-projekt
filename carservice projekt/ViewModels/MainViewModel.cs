using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MainViewModel()
        {
            Titel = "CarService Manager";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
