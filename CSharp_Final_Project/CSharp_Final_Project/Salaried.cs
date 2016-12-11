using System;
using System.Collections.Generic;
using System.IO;
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
        public override void displayEmployee()
        {
            //Console.WriteLine("Hours: " + hours);
            //Console.WriteLine("Rate: " + rate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
            using (System.IO.StreamWriter sw = File.CreateText(@"C:\Users\Public\TestFolder\SalariedData.txt"))
            {
                //sw.WriteLine("Hours: " + hours);
                //sw.WriteLine("Rate: " + taxrate);
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
                sw.WriteLine("Net%: " + net_percent + "%");
            }
            Console.WriteLine("Successfully wrote Salaried paystub to file.");

        }
        //public void salaryExport()
        //{
        //    using (System.IO.StreamWriter sw = File.CreateText(@"C:\Users\Public\TestFolder\SalaryData.txt"))
        //    {
        //        sw.WriteLine("Gross: " + gross);
        //        sw.WriteLine("Net: " + net);
        //        sw.WriteLine("Net%: " + net_percent + "%");
        //    }
        //    Console.WriteLine("Successfully wrote Salary paystub to file.");
        //}
    }
}
