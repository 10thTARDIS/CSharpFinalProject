using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    [Serializable()]
    public class Employee
    {
        /*********************
             Attributes
        *********************/
        public float rate;
        public float ovtrate = 45f;
        float taxrate = 0.2f;
        public int hours;
        public float gross;
        float tax = 0.0f;
        float net = 0.0f;
        float net_percent = 0.0f;
        String ID;
        public int employeeID;
        //End Attributes

        /********************
	     Constructors
	    ********************/
        public Employee(String arg_ID)
        {
            ID = arg_ID;
        }
        public Employee()
        {

        }

        /********************
             Methods
        ********************/
        public void menu()
        {
            int input;
            do
            {
                Console.WriteLine("\nWhat would you like to do?\n");
                Console.WriteLine("1) Calculate Gross Pay");
                Console.WriteLine("2) Calculate Tax");
                Console.WriteLine("3) Calculate Net Pay");
                Console.WriteLine("4) Calculate Net Percent");
                Console.WriteLine("5) Display Employee ");
                Console.WriteLine("6) Exit");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    computeGross();
                    computeTax();
                    computeNet();
                    computeNetperc();
                    displayEmployee();
                }
                else if (input == 2)
                {
                    computeTax();
                }
                else if (input == 3)
                {
                    computeNet();
                }
                else if (input == 4)
                {
                    computeNetperc();
                }
                else if (input == 5)
                {
                    displayEmployee();
                }

            } while (input != 6);
        }

        public void computeGross()  //hourly employees only
        {
            Payroll py = new Payroll();
            if (employeeID == 0)
            {
                if (hours > 40)
                {
                    gross = (hours - 40) * ovtrate + rate * 40;
                    Console.WriteLine("Hours: " + hours);
                    Console.WriteLine("Rate: " + rate);
                    Console.WriteLine("Over Time Rate: " + ovtrate);
                    Console.WriteLine("Gross: " + gross);
                }
                else
                {
                    gross = rate * hours;
                    Console.WriteLine("Hours: " + hours);
                    Console.WriteLine("Rate: " + rate);
                    Console.WriteLine("Gross: " + gross);
                }
            } else
            {

            }

            
        }

        public void computeTax() //For all employees
        {
            tax = gross * taxrate;
            Console.WriteLine("Tax: " + tax);

        }

        public void computeNet() //all employees
        {
            net = gross - tax;
            Console.WriteLine("Net: " + net);
        }

        public void computeNetperc() //all employees
        {
            net_percent = (net / gross) * 100;
            Console.WriteLine("Net%: " + net_percent + "%");
        }

        public void displayEmployee()
        {
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Rate: " + rate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
        }
    }

}
