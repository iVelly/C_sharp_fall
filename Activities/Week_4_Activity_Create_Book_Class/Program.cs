using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Creating_Book_Class
{
     class Program
    {
        struct Book
        {
            private string nameOfBook;
            private string authorFirst;
            private string authorLast;
            private string email;
            private DateTime datePublished;
            private decimal price;
            private int pages;

            public string NameOfBook
            {
                get
                {
                    return nameOfBook;
                }
                set
                {
                    nameOfBook = value;
                }
            }

            public string AuthorFirst
            {
                get
                {
                    return authorFirst;
                }
                set
                {
                    authorFirst = value;
                }
            }

            public string AuthorLast
            {
                get
                {
                    return authorLast;
                }
                set
                {
                    authorLast = value;
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
            public DateTime DatePublished
            {
                get
                {
                    return datePublished;
                }
                set
                {
                    datePublished = value;
                }
            }
            public decimal Price
            {
                get
                {
                    return price;
                }
                set
                {
                    price = value;
                }
            }
            public int Pages
            {
                get
                {
                    return pages;
                }
                set
                {
                    pages = value;
                }
            }


        }

        // datetime Validation
        static bool isDateValid(string dateInput)
        {
            bool blnResults = DateTime.TryParse(dateInput, out DateTime datePublished);

            return blnResults;

        }
        // price Validation
        static bool isPriceValid(string priceInput)
        {
            bool blnResults = decimal.TryParse(priceInput, out decimal price);

            return blnResults;
        }
        // page validation
        static bool isPageValid(string pageInput)
        {
            bool blnPageResults = int.TryParse(pageInput, out int page);

            return blnPageResults;
        }

        // Create a static method named "StoreBookInformation" to collect and return a "Book" object:
        static Book StoreBookInformation()
        {
            Book temp = new Book();

            Console.Write("Enter the name of the book: ");
            temp.NameOfBook = Console.ReadLine();

            Console.Write("Enter the first name of the author: ");
            temp.AuthorFirst = Console.ReadLine();

            Console.Write("Enter the last name of the author: ");
            temp.AuthorLast = Console.ReadLine();

            Console.Write("Enter the email: ");
            temp.Email = Console.ReadLine();

            // Collect date from user
            string dateInput;
            bool blnDateResult = false;
            DateTime datePublished;

            do
            {
                Console.Write("Enter the date published (MM/dd/yyyy): ");
                dateInput = Console.ReadLine();

                blnDateResult = isDateValid(dateInput);

                if (blnDateResult == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for hours.");

                }
                else
                {
                    DateTime.TryParse(dateInput, out datePublished);
                    temp.DatePublished = datePublished;

                }

            } while (blnDateResult == false);

            //Collect price from user 
            string priceInput;
            bool blnPriceResult = false;
            decimal price;

            do
            {
                Console.Write("Enter the price: ");
                priceInput = Console.ReadLine();

                blnPriceResult = isPriceValid(priceInput);

                if (blnPriceResult == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for price.");

                }
                else
                {
                    decimal.TryParse(priceInput, out price);
                    temp.Price = price;

                }

            } while (blnPriceResult == false);
           
            // Collect number of pages
            string pageInput;
            bool blnPageResult = false;
            int pages;

            do
            {
                Console.Write("Enter the number of pages: ");
                pageInput = Console.ReadLine();

                blnPageResult = isPageValid(pageInput);

                if (blnPageResult == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for pages.");

                }
                else
                {
                    int.TryParse(pageInput, out pages);
                    temp.Pages = pages;

                }

            } while (blnPageResult == false);

            return temp;

            


        }
        // Create a static method named "DisplayBookInformation" to display the "Book" object:
        static void DisplayBookInformation(Book temp)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Book Information:");
            Console.WriteLine($"Name of Book: {temp.NameOfBook}");
            Console.WriteLine($"Author: {temp.AuthorFirst} {temp.AuthorLast}");
            Console.WriteLine($"Email: {temp.Email}");
            Console.WriteLine($"Date Published: {temp.DatePublished:MM/dd/yyyy}");
            Console.WriteLine($"Price: {temp.Price:C}");
            Console.WriteLine($"Pages: {temp.Pages}");
            Console.WriteLine("=================================================");
        }
        static void Main(string[] args)
        {
            //   - Call "StoreBookInformation" to get book information and store it in a "book" object
            Book temp = StoreBookInformation();
            //   - Call "DisplayBookInformation" to display the book information
            DisplayBookInformation(temp);
            // Pause the program before it closes
            Console.WriteLine("===================");
            Console.WriteLine("Press Enter to Exit");
            Console.WriteLine("===================");
            Console.ReadLine();

        }
    }
}
