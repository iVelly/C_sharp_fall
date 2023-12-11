using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TotalRevScreen : Form
    {
        public TotalRevScreen()
        {
            InitializeComponent();
        }
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_LGermeil;User Id=SE133_LGermeil;Password=008017491;";
        }
        private List<Event> GetEventsFromDataSource()
        {
            List<Event> events = new List<Event>();

            // Establish a connection to your SQL database
            using (SqlConnection connection = new SqlConnection(GetConnected()))
            {
                connection.Open();

                // Define your SQL query to retrieve event data
                string sqlQuery = "SELECT NameOfEvent, Date, NumberOfAttendees, Venue, TicketPrice FROM Events";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create Event objects and populate them with data from the database
                            Event evt = new Event
                            {
                                NameOfEvent = reader["NameOfEvent"].ToString(),
                                Date = Convert.ToDateTime(reader["Date"]),
                                NumberOfAttendees = Convert.ToInt32(reader["NumberOfAttendees"]),
                                Venue = reader["Venue"].ToString(),
                                TicketPrice = Convert.ToDouble(reader["TicketPrice"])
                            };

                            events.Add(evt);
                        }
                    }
                }

                connection.Close();
            }

            return events;
        }
        private void btnCalculateTotalRevenue_Click(object sender, EventArgs e)
        {
            List<Event> events = GetEventsFromDataSource(); // Retrieve events from your data source

            // Call the method to calculate total revenue
            double totalRevenue = Event.CalculateTotalRevenue(events);

            // Display the total revenue in a label
            lblFeedback.Text = $"Total Revenue: ${totalRevenue:F2}";

            // Clear the ListBox 
            lstEvents.Items.Clear();

            // Populate the ListBox with the list of events
            foreach (Event evt in events)
            {
                lstEvents.Items.Add($"{evt.NameOfEvent}, Date: {evt.Date}, Attendees: {evt.NumberOfAttendees}, Venue: {evt.Venue}, Price: ${evt.TicketPrice:F2}");
            }
        }

        private void TotalRevScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
