using System;

namespace Week1_Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for user input
            string strFirst, strOperand, strNum1, strNum2;
            int intNum1 = 0, intNum2 = 0, intResult = 0;
            double dblResult;

            // Prompt the user for their first name
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();
            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            // Prompt the user for the first number
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            // Prompt the user for a math operation (PLUS, MINUS, MULTIPLY, DIVIDE)
            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine();

            // Prompt the user for the second number
            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            // Convert string versions of numbers to integers
            intNum1 = Int32.Parse(strNum1);
            intNum2 = Convert.ToInt32(strNum2);

            // Perform the math based on the operand
            switch (strOperand)
            {
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
            }

            // Convert the result to a double and display it
            dblResult = (double)intResult;

            if (strOperand == "PLUS")
            {
                Console.WriteLine("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }
            else if (strOperand == "MINUS")
            {
                Console.WriteLine($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else if (strOperand == "DIVIDE")
            {
                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            }

            // Pause the program before it closes
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
