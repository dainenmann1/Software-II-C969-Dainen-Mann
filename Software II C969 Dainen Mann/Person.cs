using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_II_C969_Dainen_Mann
{
    public abstract class Person
    {
        public int active { get; set; }
        public DateTime dateCreated { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }
    }
}
