using System;
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
        public Employee[] empArray = { new Employee("123"), new Employee("456"), new Employee("789") };
        int input;
        int numberItems;
        bool employeesExist = false;
        //int temp;
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
            //else if (input == 5)
            //{

            //}

        }

        public void populateEmployees()
        {
            Employee em = new Employee();
            Console.WriteLine("Please fill out the attributes for the employees you wish to add\n");
            
            //Hourly employee
            Console.WriteLine("Hourly employee:\nHow many hours?");
            input = Convert.ToInt32(Console.ReadLine());
            empArray[0].hours = input;
            Console.WriteLine("Pay rate:");
            input = Convert.ToInt32(Console.ReadLine());
            empArray[0].rate = input;

            //Salaried employees
            Console.WriteLine("\nSalary employee:\nStaff or executive? (1 or 9)");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                empArray[1].gross = 50000;
            }
            else if(input == 9)
            {
                empArray[1].gross = 100000;
            }


            //Commissioned employee
            Console.WriteLine("\nCommissioned employee:\nNumber of items sold?");
            input = Convert.ToInt32(Console.ReadLine());
            numberItems = input;
            Console.WriteLine("Unit price of items sold?");
            input = Convert.ToInt32(Console.ReadLine());
            //set net to .5(input*numberItems)
            empArray[2].gross = 0.5f * (input * numberItems);  //You've gotta be kidding. To fix the error I just needed to add "f" after 0.5, to signify "float".

        //Testing commits

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
                //Console.WriteLine("\n 0, 1, or 2).  -99 to exit.");
                sinput = Console.ReadLine();
                input = Convert.ToInt32(sinput);
                if (input != -99)
                {
                    if (input == 0 || input == 1 || input == 2)
                    {
                        em.employeeID = input;
                        empArray[input].menu();
                    }
                    else Console.WriteLine("Invalid input. Please enter  0 for an Hourly Employee, 1 for a Salary Employee, 2 for a Comission Employee, or -99 to Exit");

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
