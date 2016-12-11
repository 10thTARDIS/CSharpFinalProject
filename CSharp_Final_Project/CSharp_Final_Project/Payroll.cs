using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Final_Project
{
    class Payroll
    {
        public Employee[] empArray = { new Employee("123"), new Employee("456"), new Employee("789") };
        int input;
        public int numberItems;
        public bool employeesExist = false;
        public static void Main(string[] args)
        {
            Payroll pay = new Payroll();
            Console.WriteLine("Welcome to the system.");
            Console.WriteLine("One moment, logging on...");
            Thread.Sleep(1000);
            Console.WriteLine("Successfully authenticated, loading system...");
            Thread.Sleep(1000);
            pay.menu();
        }

        public void menu()
        {
            input = -99;
            Employee em = new Employee();

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
                else if (input == 2 && employeesExist == false)
                {
                    Console.WriteLine("\nERROR! You must first populate employees");
                }
                else if (input == 3 && employeesExist == true)
                {
                    saveEmployee();
                }
                else if (input == 3 && employeesExist == false)
                {
                    Console.WriteLine("\nERROR! You must first populate employees");
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
        }

        public void populateEmployees()
        {
            Employee em = new Employee();
            Console.WriteLine("Please fill out the attributes for the employees you wish to add\n");

            for (int i=0; i<empArray.Length; i++)
            {
                if (i == 0)
                {
                    //Hourly employee
                    empArray[i] = new Hourly();
                    Console.WriteLine("Hourly employee:\nHow many hours?");
                    input = Convert.ToInt32(Console.ReadLine());
                    empArray[0].hours = input;
                    Console.WriteLine("Pay rate:");
                    input = Convert.ToInt32(Console.ReadLine());
                    empArray[0].rate = input;
                }
                else if (i == 1)
                {
                    //Salaried employees
                    empArray[i] = new Salaried();
                    Console.WriteLine("\nSalary employee:\nStaff or executive? (1 or 9)");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input == 1)
                    {
                        empArray[1].gross = 50000;
                    }
                    else if (input == 9)
                    {
                        empArray[1].gross = 100000;
                    }
                }
                else if (i == 2)
                {
                    //Commissioned employee
                    empArray[i] = new Commissioned();
                    Console.WriteLine("\nCommissioned employee:\nNumber of items sold?");
                    input = Convert.ToInt32(Console.ReadLine());
                    numberItems = input;
                    Console.WriteLine("Unit price of items sold?");
                    input = Convert.ToInt32(Console.ReadLine());
                    empArray[2].gross = 0.5f * (input * numberItems);
                }
                else
                {

                }
            }

            employeesExist = true;
        }

        public void selectEmployee()
        {
            string sinput = null;
            int input;
            input = -1;
            while (input != -99)
            {
                Employee em = new Employee();
                Console.WriteLine("\nPlease Select an employee:\n");
                Console.WriteLine("Enter 0 for an Hourly Employee \nEnter 1 for a Salary Employee \nEnter 2 for a Comission Employee \nEnter -99 to Exit");
                sinput = Console.ReadLine();
                input = Convert.ToInt32(sinput);
                if (input != -99)
                {
                    if (input == 0 || input == 1 || input == 2)
                    {
                        empArray[input].employeeID = input;
                        empArray[input].menu();
                    }
                    else Console.WriteLine("Invalid input. Please enter  0 for an Hourly Employee, 1 for a Salary Employee, 2 for a Comission Employee, or -99 to Exit");

                }
                else Console.WriteLine("Goodbye.");
            }
        }

        public void saveEmployee()
        {
            System.IO.Stream FileStream = File.Create(@"C:\Users\Public\TestFolder\WriteLines.xml");
            //XmlSerializer serializer = new XmlSerializer(typeof(Account[]));
            BinaryFormatter serializer = new BinaryFormatter();
            //XmlSerializer serializer = new XmlSerializer(typeof(Account[]));
            serializer.Serialize(FileStream, empArray);
            FileStream.Close();

            //Write array to text file

            Console.WriteLine("\nYour changes have been saved.  Goodbye.");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        public void loadEmployee()
        {
            Stream FileStream = File.OpenRead(@"C:\Users\Public\TestFolder\WriteLines.xml");
            //XmlSerializer deserializer = new XmlSerializer(typeof(Account[]));
            BinaryFormatter deserializer = new BinaryFormatter();
            empArray = (Employee[])deserializer.Deserialize(FileStream);
            FileStream.Close();
            employeesExist = true;
        }
    }
}
