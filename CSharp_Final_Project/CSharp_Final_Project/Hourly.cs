using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    public class Hourly : Employee
    {
        public new float rate = 30.0f;
        public new int hours = 45;

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
