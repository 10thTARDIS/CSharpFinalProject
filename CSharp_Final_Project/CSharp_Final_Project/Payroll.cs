﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Final_Project
{
    class Payroll
    {
        Employee[] empArray = new Employee[3];
        int input;
        bool employeesExist = false;
        public static void Main(string[] args)
        {
            Payroll pay = new Payroll();
            Console.WriteLine("Welcome to the system.");
            Console.WriteLine("One moment, logging on...");
            pay.menu();
        }

        public void menu()
        {
            input = -99;
            do
            {
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
                    selectEmployee();
                }
                else if (input == 3 && employeesExist == true)
                {
                    saveEmployee();
                }
                else if (input == 4 && employeesExist == false)
                {
                    loadEmployee();
                }
                else if (input == 4 && employeesExist == true)
                {
                    Console.WriteLine("You have already created employees.  Would you like to overwrite them? 1=no, 9=yes");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input == 9)
                    {
                        loadEmployee();
                    }
                    else if (input != 1)
                    {
                        Console.WriteLine("Invalid input.  Please enter either 1 to not overwrite, or 9 to overwrite.");
                    } while (input != 1) ;

                    Console.WriteLine("Returning to the main menu.  One moment...");

                }
            } while (input != 5);
            //else if (input == 5)
            //{

            //}

        }

        public void populateEmployees()
        {
            employeesExist = true;
            Console.WriteLine("Please fill out the attributes for the employees you wish to add\n");
            Console.WriteLine("Hourly employee:\nHow many hours?");
            Console.WriteLine("Pay rate:");
            Console.WriteLine("Salary employee:\nStaff or executive? (1 or 9)");
            Console.WriteLine("Comission employee:\nNumber of items sold?");
            Console.WriteLine("Unit price of items sold?");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void selectEmployee()
        {
            string sinput = null;
            int input;
            input = -1;
            while (input != -99)
            {
                Console.WriteLine("Please Select an employee: \nEnter 0 for an Hourly Employee \nEnter 1 for a Salary Employee \nEnter 2 for a Comission Employee \nEnter -99 to Exit");
                //Console.WriteLine("\n 0, 1, or 2).  -99 to exit.");
                sinput = Console.ReadLine();
                input = Convert.ToInt32(sinput);
                if (input != -99)
                {
                    empArray[input].menu();
                }
                else Console.WriteLine("Goodbye.");
            }
        }

        public void saveEmployee()
        {
            Stream FileStream = File.Create("test.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Employee[]));
            serializer.Serialize(FileStream, empArray);
            FileStream.Close();
            Console.WriteLine("\nYour changes have been saved.  Goodbye.");
        }

        public void loadEmployee()
        {
            Stream FileStream = File.OpenRead("test.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(Employee[]));
            empArray = (Employee[])deserializer.Deserialize(FileStream);
            FileStream.Close();
            employeesExist = true;
        }
    }
}
