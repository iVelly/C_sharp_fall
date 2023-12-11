using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{

    public class Event
    {
        private string nameOfEvent;
        private DateTime date;
        private int numberOfAttendees;
        private string venue;
        private double ticketPrice;
        private int eventID;  // Add a field for eventID
        private string feedback;

        public Event()
        {
            feedback = ""; // Reset feedback to an empty string;
        }
        public string NameOfEvent
        {
            get { return nameOfEvent; }
            set
            {
                if (!ValidOrBuggin.IsItFilledIn(value, 1)) // Assuming name should be at least 1 character
                {
                    feedback += "\nERROR: Event name must be filled in.";
                }
                else if (ValidOrBuggin.GotProfanity(value))
                {
                    feedback += "\nERROR: Event name contains inappropriate language.";
                }
                else
                {
                    nameOfEvent = value;
                }
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                //tweaked this
                if (ValidOrBuggin.IsAFutureDate(value))
                {
                    feedback += "\nERROR: Event date cannot be in the past.";
                }
                else
                {
                    date = value;
                }
            }
        }

        

        public string Venue
        {
            get { return venue; }
            set
            {
                if (!ValidOrBuggin.IsItFilledIn(value, 1)) // venue should be at least 1 character
                {
                    feedback += "\nERROR: Venue must be filled in.";
                }
                
                else
                {
                    venue = value;
                }
            }
        }

        public double TicketPrice
        {
            get { return ticketPrice; }
            set
            {
                if (!ValidOrBuggin.IsValidDouble(value.ToString()))
                {
                    feedback += "\nERROR: Ticket price must be a valid number.(ex: 20.00)";
                }
                else if (value < 0)
                {
                    feedback += "\nERROR: Ticket price cannot be negative.";
                }
                else
                {
                    ticketPrice = value;
                }
            }
        }

        public int NumberOfAttendees
        {
            get { return numberOfAttendees; }
            set
            {
                if (value < 0) // Validation to ensure attendee count isn't negative
                {
                    feedback += "\nERROR: Number of Attendees cannot be negative.";
                }
                else
                {
                    numberOfAttendees = value;
                }
            }
        }

        // Public property for EventID
        public int EventID
        {
            get
            {
                return eventID;
            }
            set
            {
                eventID = value;
            }
        }
        // Property for feedback assuming to collect and display validation feedback
        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";
        }

        public DataSet SearchEvents(string nameOfEvent)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();

            // Adjust the SQL query to match your Events table's schema
            string strSQL = "SELECT EventID, NameOfEvent, Date, NumberOfAttendees, Venue, TicketPrice FROM Events WHERE 1=1";

            // If the Name of Event is filled in, include it as search criteria
            if (!string.IsNullOrEmpty(nameOfEvent))
            {
                strSQL += " AND NameOfEvent LIKE @NameOfEvent";
                comm.Parameters.AddWithValue("@NameOfEvent", "%" + nameOfEvent + "%");
            }

            // Create DB tools and Configure
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnected();

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            // Get Data
            conn.Open();
            da.Fill(ds, "Events_Temp"); // Fill the dataset with results from the database and call it "Events_Temp"
            conn.Close();

            return ds;
        }
        public string AddEvent()
        {
            
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "INSERT INTO Events (NameOfEvent, Date, NumberOfAttendees, Venue, TicketPrice) " +
                               "VALUES (@NameOfEvent, @Date, @NumberOfAttendees, @Venue, @TicketPrice)";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@NameOfEvent", this.NameOfEvent);
            comm.Parameters.AddWithValue("@Date", this.Date);
            comm.Parameters.AddWithValue("@NumberOfAttendees", this.NumberOfAttendees);
            comm.Parameters.AddWithValue("@Venue", this.Venue);
            comm.Parameters.AddWithValue("@TicketPrice", this.TicketPrice);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Inserted {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message;
            }

            return Feedback;
        }
        public string UpdateEvent(int eventID)
        {
            
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "UPDATE Events SET NameOfEvent = @NameOfEvent, Date = @Date, " +
                               "NumberOfAttendees = @NumberOfAttendees, Venue = @Venue, TicketPrice = @TicketPrice " +
                               "WHERE EventID = @EventID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@NameOfEvent", this.NameOfEvent);
            comm.Parameters.AddWithValue("@Date", this.Date);
            comm.Parameters.AddWithValue("@NumberOfAttendees", this.NumberOfAttendees);
            comm.Parameters.AddWithValue("@Venue", this.Venue);
            comm.Parameters.AddWithValue("@TicketPrice", this.TicketPrice);
            comm.Parameters.AddWithValue("@EventID", eventID);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Updated {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message;
            }

            return Feedback;
        }

        public string DeleteEvent(int eventID)
        {
            
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "DELETE FROM Events WHERE EventID = @EventID";

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@EventID", eventID);

            try
            {
                conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                Feedback = $"SUCCESS: Deleted {intRecs} records.";
                conn.Close();
            }
            catch (Exception err)
            {
                Feedback = "ERROR: " + err.Message;
            }

            return Feedback;
        }

        public SqlDataReader FindOneEvent(int eventID)
        {
            
            SqlConnection conn = new SqlConnection(GetConnected());
            SqlCommand comm = new SqlCommand();

            string sqlString = "SELECT * FROM Events WHERE EventID = @EventID";
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@EventID", eventID);

            conn.Open();
            return comm.ExecuteReader(); // Caller must close the connection!
        }
        //////////////////////////////////////////////////
        public static double CalculateTotalRevenue(List<Event> events)
        {
            double totalRevenue = 0.0;

            foreach (Event evt in events)
            {
                // Calculate revenue for each event and add it to the total
                totalRevenue += evt.TicketPrice * evt.NumberOfAttendees;
            }

            return totalRevenue;
        }
        /////////////////////////////////////////////////////
        
    }

}
