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
        public float rate = 30.0f;
        public float ovtrate = 45.0f;
        float taxrate = 0.2f;
        public int hours = 45;
        public float gross = 0.0f;
        float tax = 0.0f;
        public float net = 0.0f;
        float net_percent = 0.0f;
        String ID;
        public int employeeID;
        Payroll py = new Payroll();

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
                Console.WriteLine("4) Display Employee ");
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
            if (employeeID == 0)
            {
                if (hours > 40)
                {
                    py.empArray[employeeID].gross = (py.empArray[employeeID].hours - 40) * py.empArray[employeeID].ovtrate + py.empArray[employeeID].rate * 40;
                    Console.WriteLine("Hours: " + py.empArray[employeeID].hours);
                    Console.WriteLine("Rate: " + py.empArray[employeeID].rate);
                    Console.WriteLine("Over Time Rate: " + py.empArray[employeeID].ovtrate);
                    Console.WriteLine("Gross: " + py.empArray[employeeID].gross);
                }
                else
                {
                    py.empArray[employeeID].gross = py.empArray[employeeID].rate * py.empArray[employeeID].hours;
                    Console.WriteLine("Hours: " + py.empArray[employeeID].hours);
                    Console.WriteLine("Rate: " + py.empArray[employeeID].rate);
                    Console.WriteLine("Gross: " + py.empArray[employeeID].gross);
                }
            }

            
        }

        public void computeTax() //For all employees
        {
            py.empArray[employeeID].tax = py.empArray[employeeID].gross * py.empArray[employeeID].taxrate;
            Console.WriteLine("Tax: " + py.empArray[employeeID].tax);

        }

        public void computeNet() //all employees
        {
            py.empArray[employeeID].net = py.empArray[employeeID].gross - py.empArray[employeeID].tax;
            Console.WriteLine("Net: " + py.empArray[employeeID].net);
        }

        public void computeNetperc() //all employees
        {
            py.empArray[employeeID].net_percent = (py.empArray[employeeID].net / py.empArray[employeeID].gross) * 100;
            Console.WriteLine("Net%: " + py.empArray[employeeID].net_percent + "%");
        }

        public void displayEmployee()
        {
            Console.WriteLine("Hours: " + py.empArray[employeeID].hours);
            Console.WriteLine("Rate: " + py.empArray[employeeID].rate);
            Console.WriteLine("Gross: " + py.empArray[employeeID].gross);
            Console.WriteLine("Net: " + py.empArray[employeeID].net);
            Console.WriteLine("Net%: " + py.empArray[employeeID].net_percent + "%");
        }
    }

}
