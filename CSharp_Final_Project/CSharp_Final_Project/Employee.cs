using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    //[Serializable()]
    [Serializable]

    public class Employee
    {
        /*********************
             Attributes
        *********************/
        public float rate = 30.0f;
        public float ovtrate = 45f;
        protected float taxrate = 0.2f;
        public int hours;
        public float gross;
        protected float tax = 0.0f;
        protected float net = 0.0f;
        protected float net_percent = 0.0f;
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
                Console.WriteLine("1) Calculate Gross Pay, Tax, Net Pay, and Net Percent");
                //Console.WriteLine("2) Calculate Tax");
                //Console.WriteLine("3) Calculate Net Pay");
                //Console.WriteLine("4) Calculate Net Percent");
                Console.WriteLine("3) Display Employee ");
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
                //else if (input == 2)
                //{
                //    computeTax();
                //}
                //else if (input == 3)
                //{
                //    computeNet();
                //}
                //else if (input == 4)
                //{
                //    computeNetperc();
                //}
                else if (input == 3)
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
                    gross = (hours - 40) * ovtrate + rate * 40;
                }
                else
                {
                    gross = rate * hours;
                }
            }
            else
            {
<<<<<<< HEAD
                Console.WriteLine("For hourly employees only, please choose another option \n");
            }

            
=======

            } 
>>>>>>> origin/WorkingBranch
        }

        public void computeTax() //For all employees
        {
            tax = gross * taxrate;

        }

        public void computeNet() //all employees
        {
            net = gross - tax;
        }

        public void computeNetperc() //all employees
        {
            net_percent = (net / gross) * 100;
        }

        public void displayEmployee()
        {
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Rate: " + rate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
            using (System.IO.StreamWriter sw = File.CreateText("HourlyData.txt"))
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
