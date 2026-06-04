using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt.Models
{
    public class Mechaniker : Person
    {
        public string Abteilung { get; set; }

        public override string Info()
        {
            return Name + " - " + Abteilung;
        }
    }
}
