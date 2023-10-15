using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Fall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            string strFirst, hours, wage, strResults;

            int intCounter = 0;
    
            float floatTaxes = 0, floatHours = 0, floatWage = 0, floatGross = 0, floatNet = 0, averageIncome = 0, averageNetpayResult = 0;

            
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

                //
                Console.WriteLine("Alright, " + strFirst + "! Let's calculate your payroll!");
                

                //
                Console.Write("Please enter the amount of hours worked: ");
                while (true)
                {
                    hours = Console.ReadLine();

                    if (float.TryParse(hours, out floatHours))
                    {
                        lHours.Add(floatHours);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for hours worked.");
                        
                    }
                }
                //hours = Console.ReadLine();
                //floatHours = float.Parse(hours);
                //lHours.Add(floatHours);


                //
                Console.Write("Please enter the wage: ");
                while (true)
                {
                    wage = Console.ReadLine();

                    if (float.TryParse(wage, out floatWage))
                    {
                        lWage.Add(floatWage);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for wage.");

                    }
                }
                //wage = Console.ReadLine();
                //floatWage = float.Parse(wage);
                //lWage.Add(floatWage);

                //
                floatGross = floatHours * floatWage;
                lGrossPay.Add(floatGross);

                //
                if (floatGross >= 1000)
                {
                    floatTaxes = 50;
                }

                else if (floatGross >= 500)
                {
                    floatTaxes = 30;
                }

                else if (floatGross >= 100)
                {
                    floatTaxes = 20;
                }

                else
                {
                    floatTaxes = 0; 
                }

                //
                floatNet = floatGross - (floatTaxes / 100) * floatGross;
               
                lTaxes.Add(floatTaxes);
                lNet.Add(floatNet);
                averageIncome += floatNet;

                // Ask if they want to add more employees to check wages and what not. If not  exit do loop
                Console.WriteLine("Would you like add more employees? Y/N");
                strResults = Console.ReadLine().ToUpper();





            } while (strResults == "Y");




            
            //
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
                Console.WriteLine("Taxes: " + lTaxes[i  ] + "%");
                Console.WriteLine("Net pay: $" + lNet[i]);
                Console.WriteLine("===============");


            }
            // Calculate and display the average income and display it.
            if(intCounter > 1)
            {
                Console.WriteLine("\nTotal number of employees: " + intCounter);
                averageNetpayResult = (averageIncome / intCounter);
                Console.WriteLine("Average Income: $" + averageNetpayResult);
            }
            

            Console.WriteLine("\n\nPress any Key to end program");
            Console.ReadKey();
        }
    }
}
