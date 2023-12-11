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
        private int personID;  // Add a field for PersonID

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
        // Public property for PersonID
        public int PersonID
        {
            get 
            {
                return personID; 
            }
            set 
            { 
                personID = value; 
            }
        }
        public string AddARecord()
        {
            //string strResult = "";
            SqlConnection Conn = new SqlConnection();

            // Set the connection string to your database
            Conn.ConnectionString = @GetConnected(); ;

            // SQL INSERT statement for the Persons table
            string strSQL = "INSERT INTO Persons (FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, CellPhone, InstagramURL) " +
                            "VALUES (@FirstName, @MiddleName, @LastName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @CellPhone, @InstagramURL)";

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
            comm.Parameters.AddWithValue("@CellPhone", this.CellPhone);
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

        public DataSet SearchPeople(string firstName, string lastName)
        {
            // Create a dataset to return filled
            DataSet ds = new DataSet();

            // Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();

            // Write a Select Statement to perform Search
            // Adjust the SQL query to match your People table's schema/build but lets keep it simple...unless asked in the future
            String strSQL = "SELECT PersonID, FirstName, MiddleName, LastName, Street1, Street2, City, State, Zip, Phone, Email, CellPhone, InstagramURL FROM Persons WHERE 1=1"; // Using 1=1 to simplify query logic

            // If the First Name is filled in, include it as search criteria
            if (firstName.Length > 0)
            {
                strSQL += " AND FirstName LIKE @FirstName";
                comm.Parameters.AddWithValue("@FirstName", "%" + firstName + "%");
            }

            // If the Last Name is filled in, include it as search criteria
            if (lastName.Length > 0)
            {
                strSQL += " AND LastName LIKE @LastName";
                comm.Parameters.AddWithValue("@LastName", "%" + lastName + "%");
            }

            // Create DB tools and Configure
            SqlConnection conn = new SqlConnection();

            // Use the GetConnected method to simplify the connection string assignment
            conn.ConnectionString = GetConnected();

            // Fill in basic info to command object
            comm.Connection = conn;
            comm.CommandText = strSQL;

            // Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            // Get Data
            conn.Open();
            da.Fill(ds, "People_Temp"); // Fill the dataset with results from the database and call it "People_Temp"
            conn.Close();

            // Return the data
            return ds;
        }

        // Add a new method to find a person by PersonID
        public SqlDataReader FindOnePerson(int personID)
        {
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "SELECT * FROM Persons WHERE PersonID = @PersonID";
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", personID);

            conn.Open();
            return comm.ExecuteReader();
        }


        // Utility function to get the connection string
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";
        }




    }
}
