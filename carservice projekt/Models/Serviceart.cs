using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt.Models
{
    internal class Serviceart
    {
        public string Name { get; set; }

        public string Beschreibung { get; set; }

        public string GetBeschreibung()
        {
            return Name + " - " + Beschreibung;
        }
    }
}
