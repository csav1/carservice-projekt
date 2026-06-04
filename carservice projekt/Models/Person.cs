using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice_projekt.Models
{
    public class Person
    {
        public string Name { get; set; }

        public virtual string Info()
        {
            return Name;
        }
    }
}
