using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    [Serializable()]
    public class Salaried : Employee
    {
        String ID;

        public Salaried(String arg_ID)
        {
            ID = arg_ID;
        }
        public Salaried()
        {

        }
    }
}
