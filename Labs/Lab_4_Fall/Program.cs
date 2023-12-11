using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Fall
{
     class Program
    {
        // Define a structure or class named "Person" with private fields for personal information
        class Person
        {
            private string firstName;
            private string middleName;
            private string lastName;
            private string street1;
            private string expression;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            // Inside the structure, create properties to get and set each piece of personal information
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }

            public string MiddleName
            {
                get
                {
                    return middleName;
                }
                set
                {
                    middleName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }

            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }

            public string Expression
            {
                get
                {
                    return expression;
                }
                set
                {
                    expression = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }

            public string Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    zip = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }

            

            

        }
        // Create a static method named "GetPersonInformation" to collect and return a "Person" object
        static Person GetPersonInformation()
        {
            Person temp = new Person();



            Console.Write("What is your first name? ");
            temp.FirstName = Console.ReadLine();
            temp.FirstName = "Poopy--" + temp.FirstName;

            Console.Write("What is your middle name? ");
            temp.MiddleName = Console.ReadLine();

            Console.Write("What is your last name? ");
            temp.LastName = Console.ReadLine();

            Console.Write("Please enter your primary street address: ");
            temp.Street1 = Console.ReadLine();

            Console.Write("Do you have a secondary address? [y/n]: ");
            string expression = Console.ReadLine();

            if (expression == "y")
            {
                Console.Write("Please enter your secondary street address: ");
                temp.Street2 = Console.ReadLine();
            }

            Console.Write("Please enter your state: ");
            temp.State = Console.ReadLine();

            Console.Write("Please enter your city: ");
            temp.City = Console.ReadLine();

            Console.Write("Enter your zip code: ");
            temp.Zip = Console.ReadLine();

            Console.Write("Enter your email: ");
            temp.Email = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            temp.Phone = Console.ReadLine();

            return temp;
        }

        // Create a static method named "PrintPersonInformation" to display the "Person" object
        static void PrintPersonInformation(Person temp)
        {
            Console.WriteLine("===============");
            Console.Write("User Information");
            Console.Write($"\nName: {temp.FirstName}");
            Console.Write($"\nMiddle Name: {temp.MiddleName}");
            Console.Write($"\nLast Name: {temp.LastName}");
            Console.Write($"\nStreet1: {temp.Street1}");
            Console.Write($"\nStreet2: {temp.Street2}");
            Console.Write($"\nState: {temp.State}");
            Console.Write($"\nCity: {temp.City}");
            Console.Write($"\nEmail: {temp.Email}");
            Console.Write($"\nZip Code: {temp.Zip}");
            Console.Write($"\nPhone Number: {temp.Phone}");
            Console.WriteLine("");

            Console.WriteLine("===============");


           
        }
        static void Main(string[] args)
        {
            Person temp = GetPersonInformation(); // Call the method to get user information
            PrintPersonInformation(temp); // Call the method to print user information

            // Pause the program before it closes
            Console.WriteLine("===================");
            Console.WriteLine("Press Enter to Exit");
            Console.WriteLine("===================");
            Console.ReadLine();
        }
    }
}
