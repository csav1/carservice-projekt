using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt.Models
{
    public class Fahrzeug
    {
        public int FahrzeugID { get; set; }
        public string Marke { get; set; }

        public string Modell { get; set; }

        public int Baujahr { get; set; }

        public string Kennzeichen { get; set; }

        public string GetInfo()
        {
            return Marke + " " + Modell;
        }
    }
}
