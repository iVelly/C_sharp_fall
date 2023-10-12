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
    
            float floatTaxes = 0, floatHours = 0, floatWage = 0, floatGross = 0, floatNet = 0;

            
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
                hours = Console.ReadLine();
                floatHours = float.Parse(hours);
                lHours.Add(floatHours);


                //
                Console.Write("Please enter the wage: ");
                wage = Console.ReadLine();
                floatWage = float.Parse(wage);
                lWage.Add(floatWage);

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

                //
                floatNet = floatGross - (floatTaxes / 100) * floatGross;
                lNet.Add(floatNet);

                // Ask if they want to add more employees to check wages and what not. If not  exit do loop
                Console.WriteLine("Would you like add more employees? Y/N");
                strResults = Console.ReadLine();



                

            } while (strResults == "Y");




            
            //
            Console.WriteLine("\n\nPress any Key to display income");
            Console.ReadKey();

            //iterating thru the index to display each employees information
            foreach (var i in lNames)
            {
                Console.WriteLine("===============");
                Console.WriteLine("Name" + ":" + lNames[0]);   //lNames
                Console.WriteLine("Hours worked: " + lHours[0]);
                Console.WriteLine("Wage: $" + lWage[0]);
                Console.WriteLine("Gross pay: $" + lGrossPay[0]);
                //Console.WriteLine("Taxes: " + lTaxes[0] + "%");
                Console.WriteLine("Net pay: $" + lNet[0]);
                Console.WriteLine("===============");


            }
            //
            //floatNet = floatGross - (floatTaxes / 100) * floatGross;
            //
            //Console.WriteLine($"Your amt of taxes is " + floatTaxes + " %");
            //Console.WriteLine($"Your Gross Pay is $ " + floatGross);
            //Console.WriteLine($"Your net Pay is $ " + floatNet);

            Console.WriteLine("\n\nPress any Key to end program");
            Console.ReadKey();
        }
    }
}
