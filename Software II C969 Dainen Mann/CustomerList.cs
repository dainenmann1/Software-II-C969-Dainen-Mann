using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_II_C969_Dainen_Mann
{
    public class CustomerList
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public CustomerList(int customerId, string customerName)
        {
            CustomerID = customerId;
            CustomerName = customerName;
        }
    }
}
