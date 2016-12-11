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
        public void salaryExport()
        {
            using (System.IO.StreamWriter sw = File.CreateText(@"C:\Users\Public\TestFolder\SalaryData.txt"))
            {
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
                sw.WriteLine("Net%: " + net_percent + "%");
            }
            Console.WriteLine("Successfully wrote Salary paystub to file.");
        }
    }
}
