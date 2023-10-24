using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_fall
{
    internal class Program
    {
        //Void Method
        // I could use the void method to display information to users 
        //
        static void displayIncome()
        {
            Console.WriteLine("\n\nPress any Key to display income");
            Console.ReadKey();

        }

        static void Pause()
        {
            Console.WriteLine("\n\nPress any Key to end program");
            Console.ReadKey();

        }
        //Return Method
        //I could use the return method to return the user's name
        static string Greeting(string strFirst)
        {
           string statement = Console.WriteLine("Alright, " + strFirst + "! Let's calculate your payroll!");
            return statement;
        }
        //By Ref
        // I could pass the use the "By Ref" method to keep up with the average income considering the number is always changing
        static void Main(string[] args)
        {
            // Declaring variables
            string strFirst, hours, wage, strResults;

            int intCounter = 0;

            float floatTaxes = 0, floatTaxesDeductions = 0, floatHours = 0, floatWage = 0, floatGross = 0, floatNet = 0, averageIncome = 0, averageNetpayResult = 0;

            bool blnHours = true, blnWage = true;

            


            // Establishing my lists
            List<string> lNames = new List<string>();
            List<float> lHours = new List<float>();
            List<float> lWage = new List<float>();
            List<float> lTaxes = new List<float>();
            List<float> lGrossPay = new List<float>();
            List<float> lNet = new List<float>();

            do

            {
                // Collecting info
                Console.WriteLine("Hello There!");
                Console.Write("Please enter the first name: ");
                strFirst = Console.ReadLine();
                lNames.Add(strFirst);
                intCounter++;

                // Greet User
                Console.WriteLine("Alright, " + strFirst + "! Let's calculate your payroll!");

                // Collect amount of hours worked from user
                do
                {
                    Console.Write("Please enter the amount of hours worked: ");
                    hours = Console.ReadLine();
                    floatHours = float.Parse(hours);
                    lHours.Add(floatHours);

                    if (blnHours == false)
                        Console.WriteLine("Invalid input. Please enter a valid number for hours.");

                } while (blnHours == false);



                // Collect Wage information from user
                do
                {
                    Console.Write("Please enter the wage: ");
                    wage = Console.ReadLine();
                    floatWage = float.Parse(wage);
                    lWage.Add(floatWage);


                    if (blnWage == false)
                        Console.WriteLine("Invalid input. Please enter a valid number for wages.");

                } while (blnWage == false);


                // Calculate Gross Pay
                floatGross = floatHours * floatWage;
                lGrossPay.Add(floatGross);

                // Calculate taxes being deducted based on gross pay
                if (floatGross >= 1000)
                {
                    floatTaxes = 50;
                    floatTaxesDeductions = (floatTaxes / 100) * floatGross;

                }

                else if (floatGross >= 500)
                {
                    floatTaxes = 30;
                    floatTaxesDeductions = (floatTaxes / 100) * floatGross;

                }

                else if (floatGross >= 100)
                {
                    floatTaxes = 20;
                    floatTaxesDeductions = (floatTaxes / 100) * floatGross;

                }

                else
                {
                    floatTaxes = 0;
                    floatTaxesDeductions = (floatTaxes / 100) * floatGross;

                }

                // Calculate Netpay
                floatNet = floatGross - (floatTaxes / 100) * floatGross;


                // add to list
                lTaxes.Add(floatTaxesDeductions);
                lNet.Add(floatNet);
                averageIncome += floatNet;

                // Ask if they want to add more employees to check wages and what not. If not  exit do loop
                Console.WriteLine("Would you like add more employees? Y/N");
                strResults = Console.ReadLine().ToUpper();





            } while (strResults == "Y");





            // Display Income
            Console.WriteLine("\n\nPress any Key to display income");
            Console.ReadKey();

            //iterating thru the index to display each employees information

            for (int i = 0; i < lNames.Count; i++)
            {
                Console.WriteLine("===============");
                Console.WriteLine("Name" + ":" + lNames[i]);
                Console.WriteLine("Hours worked: " + lHours[i]);
                Console.WriteLine("Wage: $" + lWage[i]);
                Console.WriteLine("Gross pay: $" + lGrossPay[i]);
                Console.WriteLine("Taxes: " + "$" + lTaxes[i]);
                Console.WriteLine("Net pay: $" + lNet[i]);
                Console.WriteLine("===============");


            }
            // Calculate and display the average income and display it.
            if (intCounter > 1)
            {
                Console.WriteLine("\nTotal number of employees: " + intCounter);
                averageNetpayResult = (averageIncome / intCounter);
                Console.WriteLine("Average Income: $" + averageNetpayResult);
            }

            // Pause program before it closes
            Console.WriteLine("\n\nPress any Key to end program");
            Console.ReadKey();
        }
    }
}

