using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt.Models
{
    internal class Fahrzeug
    {
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
