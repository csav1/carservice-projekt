using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt
{
    public class Wartungseintrag
    {
        public string txtmarke { get; set; }
        public string cmbServicearten { get; set; }
        public DateTime dpDatum { get; set; }
        public decimal txtKosten { get; set; }
        public string Status { get; set; }
    }
}

