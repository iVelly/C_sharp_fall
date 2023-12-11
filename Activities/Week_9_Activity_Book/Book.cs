using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Book
{
    class Book
    {
        private string title;
        private string authorFirst;
        private string authorLast;
        private string email;
        private DateTime datePublished;
        private decimal price;
        private int pages;
        private string feedback;

        public Book()
        {
            feedback = "";
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!ValidOrBuggin.IsItFilledIn(value, 1))
                {
                    feedback += "Error: Title is not filled in.\n";
                }
                else if (!ValidOrBuggin.TooManyLetters(value, 100))
                {
                    feedback += "Error: Title is too long.\n";
                }
                else
                {
                    title = value;
                    
                }
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
                if (!ValidOrBuggin.IsItFilledIn(value, 1))
                {
                    feedback += "Error: Title is not filled in.\n";
                }
                else if (!ValidOrBuggin.ContainsOnlyLetters(value))
                {
                    feedback += "Error: First name contains invalid characters.\n";
                }
                else
                {
                    authorFirst = value;
                    
                }
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
                if (!ValidOrBuggin.ContainsOnlyLetters(value))
                {
                    feedback += "Error: Last name contains invalid characters.\n";
                }
                else if (!ValidOrBuggin.IsItFilledIn(value, 1))
                {
                    feedback += "Error: Last name is not filled in.\n";
                }
                else
                {
                    authorLast = value;
                    
                }
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
                if (!ValidOrBuggin.IsValidEmail(value))
                {
                    feedback += "Error: Invalid email format.\n";
                }
                else
                {
                    email = value;
                    
                }
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
                if (!ValidOrBuggin.IsNotAFutureDate(value))
                {
                    feedback += "Error: Date published can't be in the future.\n";
                }
                else
                {
                    datePublished = value;
                    
                }
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
                
                //
                if (ValidOrBuggin.IsAnInteger(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Price must be an integer";
                }

                else if (ValidOrBuggin.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Price must contain atleast one digit";
                }
                else
                {
                    price = value;
                    
                }
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
                
                
                //
                if (ValidOrBuggin.IsAnInteger(value.ToString()) == false)
                {
                    Feedback += "\nERROR: Pages must be an integer";
                }

                else if (ValidOrBuggin.IsItFilledIn(value.ToString(), 1) == false)
                {
                    Feedback += "\nERROR: Pages must contain atleast one digit";
                }
                else
                {
                    pages = value;
                    feedback += "Page count set successfully.\n";
                }
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }
    }
}
