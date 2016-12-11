using System;
using System.Collections.Generic;
using System.IO;
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

        public void hourlyExport()
        {
            using (System.IO.StreamWriter sw = File.CreateText("C:/Users/Public/TestFolder/HourlyData.txt"))
            {
                sw.WriteLine("Hours: " + hours);
                sw.WriteLine("Rate: " + taxrate);
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
                sw.WriteLine("Net%: " + net_percent + "%");
            }
        }
    }
}
