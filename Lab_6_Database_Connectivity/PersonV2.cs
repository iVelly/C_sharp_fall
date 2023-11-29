using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Midterm
{
    class PersonV2 : People
    {
        private string cellPhone;
        private string instagramURL;

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                if (ValidOrBuggin.ExactLength(value, 10) == false)
                {
                    Feedback += "\nERROR: Cellphone must contain 10 numbers";
                }
                else
                {
                    cellPhone = value;
                }
            }
        }

        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }
            set
            {
                if (ValidOrBuggin.GotProfanity(value))
                {
                    Feedback += "\nYour Instagram URL cannot contain profanity";
                }
                else if (ValidOrBuggin.ValidInstagramURL(value) == false)
                {
                    Feedback += "\nERROR: Invalid URL to instagram";
                }
                else
                {
                    instagramURL = value;
                }

            }
        }
        public string AddARecord()
        {
            //string strResult = "";
            SqlConnection Conn = new SqlConnection();

            // Set the connection string to your database
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";

            // SQL INSERT statement for the Persons table
            string strSQL = "INSERT INTO Persons (FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, InstagramURL) " +
                            "VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @InstagramURL)";

            // Create the command and assign the query and the connection
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            // Add the parameters for the SQL INSERT statement
            comm.Parameters.AddWithValue("@FirstName", this.FirstName);
            comm.Parameters.AddWithValue("@MiddleName", this.MiddleName);
            comm.Parameters.AddWithValue("@LastName", this.LastName);
            comm.Parameters.AddWithValue("@Street1", this.Street1);
            comm.Parameters.AddWithValue("@Street2", this.Street2);
            comm.Parameters.AddWithValue("@City", this.City);
            comm.Parameters.AddWithValue("@State", this.State);
            comm.Parameters.AddWithValue("@Zip", this.Zip);
            comm.Parameters.AddWithValue("@Phone", this.Phone);
            comm.Parameters.AddWithValue("@Email", this.Email);
            comm.Parameters.AddWithValue("@InstagramURL", this.InstagramURL);

            try
            {
                Conn.Open(); // Open the connection
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Inserted {intRecs} records."; // Report success
                Conn.Close(); // Close the connection
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message; // Report error
            }

            return Feedback;
        }


    }
}
