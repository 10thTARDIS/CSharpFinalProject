using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    [Serializable()]
    public class Hourly : Employee
    {
        String ID;

        public Hourly(String arg_ID)
        {
            ID = arg_ID;
        }
        public Hourly()
        {

        }
    }
}
