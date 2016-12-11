using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    [Serializable()]
    public class Commissioned : Employee
    {
        String ID;

        public Commissioned(String arg_ID)
        {
            ID = arg_ID;
        }
        public Commissioned()
        {

        }
        public void commissionedExport()
        {
            using (System.IO.StreamWriter sw = File.CreateText(@"C:\Users\Public\TestFolder\CommissionedData.txt"))
            {
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
                sw.WriteLine("Net%: " + net_percent + "%");
            }
            Console.WriteLine("Successfully wrote Commissioned paystub to file.");
        }
    }
}
