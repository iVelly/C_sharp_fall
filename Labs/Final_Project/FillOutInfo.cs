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
    public partial class FillOutInfo : Form
    {
        public FillOutInfo()
        {
            InitializeComponent();

            //Hide the Delete Buttons
            btnDeleteEvent.Enabled = false;
            btnDeleteEvent.Visible = false;

            //Hide the Update Buttons
            btnUpdateEvent.Enabled = false;
            btnUpdateEvent.Visible = false;
        }

        public FillOutInfo(int eventID)
        {
            InitializeComponent(); // Initializes all form objects

            // Hide the Add Button
            btnAddEvent.Enabled = false;
            btnAddEvent.Visible = false;

            // Create an instance of Event to access its methods
            Event temp = new Event();

            // Use the method FindOneEvent in Event class
            using (SqlDataReader dr = temp.FindOneEvent(eventID))
            {
                if (dr.Read()) // If there's data available
                {
                    // Take the data from the datareader and copy them into the appropriate text fields
                    txtNameOfEvent.Text = dr["NameOfEvent"].ToString();
                    dtpDate.Value = (DateTime)dr["Date"];
                    txtNumberOfAttendees.Text = dr["NumberOfAttendees"].ToString();
                    txtVenue.Text = dr["Venue"].ToString();
                    txtTicketPrice.Text = dr["TicketPrice"].ToString();

                    // Display the event's ID in a label 
                    lblEventID.Text = eventID.ToString();
                }
                dr.Close(); // Close the data reader
            }
        }

        private void FillOutInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtNameOfEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpWhen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTicketPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfAttendees_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void lblEventID_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Event temp = new Event();
            temp.NameOfEvent = txtNameOfEvent.Text;
            temp.Date = dtpDate.Value;
            ///////////////////////
            int numberOfAttendees;
            if (int.TryParse(txtNumberOfAttendees.Text, out numberOfAttendees))
            {
                temp.NumberOfAttendees = numberOfAttendees;
            }
            else
            {
                // Handle the error or provide feedback to the user.
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Number of Attendees.";
            }

            temp.Venue = txtVenue.Text;
            //////////////////
            double ticketPrice;
            if (double.TryParse(txtTicketPrice.Text, out ticketPrice))
            {
                temp.TicketPrice = ticketPrice;
            }
            else
            {
                // Handle the error or provide feedback to the user.
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Ticket Price.";
            }


            // If there's no big problem with the event's information:
            if (!temp.Feedback.Contains("ERROR"))
            {
                // Attempt to add the event to the database
                string result = temp.AddEvent();
                // If the database operation was successful
                if (!result.Contains("ERROR"))
                {
                    lblFeedback.Text = "SUCCESS: The event was added to the database.";
                }
                else
                {
                    lblFeedback.Text = result; // Show the error from the database operation
                }
            }
            // Show that there's a problem with the information
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }


        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            Event temp = new Event();
            temp.NameOfEvent = txtNameOfEvent.Text;
            temp.Date = dtpDate.Value;

            int numberOfAttendees;
            if (int.TryParse(txtNumberOfAttendees.Text, out numberOfAttendees))
            {
                temp.NumberOfAttendees = numberOfAttendees;
            }
            else
            {
                // Handle the error or provide feedback to the user.
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Number of Attendees.";
            }

            temp.Venue = txtVenue.Text;

            double ticketPrice;
            if (double.TryParse(txtTicketPrice.Text, out ticketPrice))
            {
                temp.TicketPrice = ticketPrice;
            }
            else
            {
                // Handle the error or provide feedback to the user.
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Ticket Price.";
            }

            // Check if there are any validation errors
            if (!temp.Feedback.Contains("ERROR"))
            {
                // If no errors, attempt to update the event in the database
                string result = temp.UpdateEvent(temp.EventID);

                if (result.Contains("ERROR"))
                {
                    lblFeedback.Text = result; // Display any errors from the update operation
                }
                else
                {
                    lblFeedback.Text = "SUCCESS: The event was updated in the database.";
                }
            }
            // Show that there's a problem with the information
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }



        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
                // The user confirmed the deletion
                Event temp = new Event();

                // Retrieve the EventID from the form 
                temp.EventID = Convert.ToInt32(lblEventID.Text); 

                // Call the DeleteEvent method and store the result
                string deleteResult = temp.DeleteEvent(temp.EventID);

                // Check if the result contains "ERROR"
                if (deleteResult.Contains("ERROR"))
                {
                    // If there's an error, display it
                    lblFeedback.Text = deleteResult;
                }
                else
                {
                    // If deletion was successful, display a success message
                    lblFeedback.Text = "SUCCESS: The event was successfully deleted.";
                }
            }
            else
            {
                // The user clicked "No" or closed the confirmation dialog
                lblFeedback.Text = "Deletion canceled.";
            }
        }
        

    }
}
