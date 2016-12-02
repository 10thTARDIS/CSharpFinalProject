﻿using System;
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
        float net = 0.0f;
        float net_percent = 0.0f;

        //End Attributes

        /********************
	     Constructors
	    ********************/
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
