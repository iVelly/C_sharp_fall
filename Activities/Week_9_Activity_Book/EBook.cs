using System;
using System.Collections.Generic;
using System.Data;
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
        public int bookID;

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

        // Public property for bookID
        public int BookID
        {
            get
            {
                return bookID;
            }
            set
            {
                bookID = value;
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

        public DataSet SearchBooks(string title, string authorLast)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();
            String strSQL = "SELECT EBookID, Title, AuthorFirst, AuthorLast, DatePublished, Price, Pages FROM EBooks WHERE 1=1";

            if (!string.IsNullOrEmpty(title))
            {
                strSQL += " AND Title LIKE @Title";
                comm.Parameters.AddWithValue("@Title", "%" + title + "%");
            }

            if (!string.IsNullOrEmpty(authorLast))
            {
                strSQL += " AND AuthorLast LIKE @AuthorLast";
                comm.Parameters.AddWithValue("@AuthorLast", "%" + authorLast + "%");
            }

            SqlConnection conn = new SqlConnection(GetConnected());
            comm.Connection = conn;
            comm.CommandText = strSQL;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "EBooks_Temp");
            conn.Close();

            return ds;
        }

        public SqlDataReader FindOneEBook(int BookID)
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "SELECT * FROM EBooks WHERE EBookID = @EBookID";
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@EBookID", BookID);

            conn.Open();
            return comm.ExecuteReader();
        }

        public string UpdateARecord()
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "UPDATE EBooks SET Title = @Title, AuthorFirst = @AuthorFirst, AuthorLast = @AuthorLast, " +
                               "Email = @Email, DatePublished = @DatePublished, Price = @Price, Pages = @Pages, " +
                               "RentalDueDate = @RentalDueDate, BookmarkPage = @BookmarkPage " +
                               "WHERE EBookID = @EBookID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Title", this.Title);
            comm.Parameters.AddWithValue("@AuthorFirst", this.AuthorFirst);
            comm.Parameters.AddWithValue("@AuthorLast", this.AuthorLast);
            comm.Parameters.AddWithValue("@Email", this.Email);
            comm.Parameters.AddWithValue("@DatePublished", this.DatePublished);
            comm.Parameters.AddWithValue("@Price", this.Price);
            comm.Parameters.AddWithValue("@Pages", this.Pages);
            comm.Parameters.AddWithValue("@RentalDueDate", this.RentalDueDate);
            comm.Parameters.AddWithValue("@BookmarkPage", this.BookmarkPage);
            comm.Parameters.AddWithValue("@EBookID", this.BookID);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Updated {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "Error: " + err.Message;
            }

            return Feedback;
        }

        public string DeleteARecord()
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "DELETE FROM EBooks WHERE EBookID = @EBookID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@EBookID", this.BookID);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Deleted {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "Error: " + err.Message;
            }

            return Feedback;
        }
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";
        }

    }


}
