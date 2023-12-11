using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Book
{
    // EBook inherits from Book
    class EBook : Book
    {
        private DateTime rentalDueDate;
        private int bookmarkPage;

        public DateTime RentalDueDate
        {
            get { return rentalDueDate; }
            set
            {
                if (ValidOrBuggin.IsAFutureDate(value))
                {
                    
                    Feedback += "Rental due date set successfully.\n";
                }
                else
                {
                    Feedback += "Error: Invalid rental due date (can't be in the past).\n";
                }
            }
        }

        public int BookmarkPage
        {
            get { return bookmarkPage; }
            set
            {
                if (value >= 0)
                {
                    bookmarkPage = value;
                    Feedback += "Bookmark page set successfully.\n";
                }
                else
                {
                    Feedback += "Error: Invalid bookmark page (must be non-negative).\n";
                }
            }
        }

    }
}
