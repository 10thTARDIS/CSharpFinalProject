﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final_Project
{
    class Payroll
    {
        int input;
        bool employeesExist = false;
        public static void Main(string[] args)
        {

        }

        public void menu()
        {
            input = -99;
            Console.WriteLine("Welcome to the system.");
            Console.WriteLine("\nWhat would you like to do?\n");
            Console.WriteLine("1) Populate Employees");
            Console.WriteLine("2) Select Employee");
            Console.WriteLine("3) Save Employees");
            Console.WriteLine("4) Load Employees");
            Console.WriteLine("5) Exit");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1 && employeesExist == false)
            {
                populateEmployees();
            }
            else if (input == 2 && employeesExist == true)
            {

            }
            else if (input == 3 && employeesExist == true)
            {

            }
            else if (input == 3 && employeesExist == true)
            {

            }
            else if (input == 4 && employeesExist == false)
            {

            }

        }

        public void populateEmployees()
        {
            employeesExist = true;
        }

        public void selectEmployee()
        {

        }

        public void saveEmployee()
        {

        }

        public void loadEmployee()
        {

        }
    }
}
