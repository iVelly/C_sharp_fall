using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    
                }
                else
                {
                    Feedback += "Error: Invalid bookmark page (must be non-negative).\n";
                }
            }
        }

        public string AddARecord()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";

            // SQL INSERT statement for the EBooks table
            string strSQL = "INSERT INTO EBooks (Title, AuthorFirst, AuthorLast, Email, DatePublished, Price, Pages, RentalDueDate, BookmarkPage) " +
                            "VALUES (@Title, @AuthorFirst, @AuthorLast, @Email, @DatePublished, @Price, @Pages, @RentalDueDate, @BookmarkPage)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            // Add the parameters for the SQL INSERT statement
            comm.Parameters.AddWithValue("@Title", this.Title);
            comm.Parameters.AddWithValue("@AuthorFirst", this.AuthorFirst);
            comm.Parameters.AddWithValue("@AuthorLast", this.AuthorLast);
            comm.Parameters.AddWithValue("@Email", this.Email);
            comm.Parameters.AddWithValue("@DatePublished", this.DatePublished);
            comm.Parameters.AddWithValue("@Price", this.Price);
            comm.Parameters.AddWithValue("@Pages", this.Pages);
            comm.Parameters.AddWithValue("@RentalDueDate", this.RentalDueDate);
            comm.Parameters.AddWithValue("@BookmarkPage", this.BookmarkPage);

            try
            {
                conn.Open(); // Open the connection
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Inserted {intRecs} records."; // Report success
                conn.Close(); // Close the connection
            }
            catch (Exception err)
            {
                Feedback = "Error: " + err.Message; // Report error
            }

            return Feedback;
        }

    }
}
