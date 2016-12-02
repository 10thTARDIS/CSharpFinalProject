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
        int input;
        bool employeesExist = false;
        public static void Main(string[] args)
        {

        }

        public void menu()
        {
            input = -99;
            do
            {
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
                    selectEmployee();
                }
                else if (input == 3 && employeesExist == true)
                {
                    saveEmployee();
                }
                else if (input == 4 && employeesExist == true)
                {
                    loadEmployee();
                }
            } while (input != 5);
            //else if (input == 5)
            //{

            //}

        }

        public void populateEmployees()
        {
            employeesExist = true;
            Console.WriteLine("What type of employee would you like to add?\n");
            Console.WriteLine("1) Salary");
            Console.WriteLine("2) Commission");
            Console.WriteLine("3) Salary");
        }

        public void selectEmployee()
        {

        }

        public void saveEmployee()
        {
            Console.WriteLine("\nYour changes have been saved.  Goodbye.");

            Stream FileStream = File.Create("test.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Account[]));
            serializer.Serialize(FileStream, acctArray);
            FileStream.Close();
        }

        public void loadEmployee()
        {
            Stream FileStream = File.OpenRead("test.xml");
            XmlSerializer deserializer = new XmlSerializer(typeof(Account[]));
            empArray = (Account[])deserializer.Deserialize(FileStream);
            FileStream.Close();
            acctsloaded = true;
        }
    }
}
