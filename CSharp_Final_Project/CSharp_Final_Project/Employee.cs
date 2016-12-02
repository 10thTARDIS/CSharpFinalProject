using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    [Serializable()]
    class Employee
    {
        /*********************
             Attributes
        *********************/
        public float rate = 30.0f;
        float taxrate = 0.2f;
        public int hours = 45;
        public float gross = 0.0f;
        float tax = 0.0f;
        public float net = 0.0f;
        float net_percent = 0.0f;
        String ID;

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

        }

        public void computeGross()
        {
            gross = rate * hours;
        }

        public void computeTax()
        {
            tax = gross * taxrate;
        }

        public void computeNet()
        {
            net = gross - tax;
        }

        public void computeNetperc()
        {
            net_percent = (net / gross) * 100;
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
