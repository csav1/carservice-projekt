using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt.Models
{
    internal class Wartung
    {
        public string Serviceart { get; set; }

        public DateTime Datum { get; set; }

        public decimal Kosten { get; set; }

        public string Status { get; set; }

        public decimal BerechneKostenMitSteuer()
        {
            return Kosten * 1.2m;
        }
    }
}
