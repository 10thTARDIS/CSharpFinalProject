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
        public override void displayEmployee()
        {
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Rate: " + rate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
            using (System.IO.StreamWriter sw = File.CreateText(@"C:\Users\Public\TestFolder\HourlyData.txt"))
            {
                sw.WriteLine("Hours: " + hours);
                sw.WriteLine("Rate: " + taxrate);
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
            }
            Console.WriteLine("Successfully wrote Hourly paystub to file.");

        }

        //public void hourlyExport()
        //{
        //    Payroll py = new Payroll();
        //    using (System.IO.StreamWriter sw = File.CreateText(@"C:\Users\Public\TestFolder\HourlyData.txt"))
        //    {
        //        sw.WriteLine("Hours: " + py.empArray[0].hours);
        //        sw.WriteLine("Rate: " + taxrate);
        //        sw.WriteLine("Gross: " + py.empArray[0].gross);
        //        sw.WriteLine("Net: " + py.empArray[0].net);
        //    }
        //    Console.WriteLine("Successfully wrote Hourly paystub to file.");
        //}
    }
}
