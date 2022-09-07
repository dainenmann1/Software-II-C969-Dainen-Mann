using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_II_C969_Dainen_Mann
{
    class apptException : ApplicationException
    {
        public void conflictAppTime()
        {
            MessageBox.Show("The selected time is conflicting with an existing appointment");
        }
        public void outsideBusHours()
        {
            MessageBox.Show("The selected time can not be made outside business hours");
        }

    }
}
