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
            btnDeletePlayer.Enabled = false;
            btnDeletePlayer.Visible = false;

            //Hide the Update Buttons
            btnUpdatePlayer.Enabled = false;
            btnUpdatePlayer.Visible = false;
        }

        public FillOutInfo(int playerID)
        {
            InitializeComponent(); // Initializes all form objects

            // Hide the Add Button
            btnAddPlayer.Enabled = false;
            btnAddPlayer.Visible = false;

            // Create an instance of Event to access its methods
            GamePlayer temp = new GamePlayer();

            
            // Use the method FindOnePlayer in GamePlayer class
            using (SqlDataReader dr = temp.FindOnePlayer(playerID))
            {
                if (dr.Read()) // If there's data available
                {
                    // Take the data from the datareader and copy them into the appropriate text fields
                    txtPlayerName.Text = dr["PlayerName"].ToString();
                    nudLives.Value = Convert.ToInt32(dr["Lives"]);
                    //
                    txtHoursPlayed.Text = dr["HoursPlayed"].ToString();
                    //
                    nudHealth.Value = Convert.ToInt32(dr["Health"]);
                    nudStrength.Value = Convert.ToInt32(dr["Strength"]);
                    nudArmor.Value = Convert.ToInt32(dr["Armor"]);
                    dtpPlayingSince.Value = (DateTime)dr["PlayingSince"];


                    // Display the player's ID in a label 
                    lblPlayerID.Text = playerID.ToString();
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

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            GamePlayer temp = new GamePlayer();
            temp.PlayerName = txtPlayerName.Text;
            temp.Lives = (int)nudLives.Value;
            temp.Health = (int)nudHealth.Value;
            temp.Strength = (int)nudStrength.Value;
            temp.Armor = (int)nudArmor.Value;
            temp.PlayingSince = dtpPlayingSince.Value;

            double hoursPlayed;
            if (double.TryParse(txtHoursPlayed.Text, out hoursPlayed))
            {
                temp.HoursPlayed = hoursPlayed;
            }
            else
            {
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Hours Played.";
            }

            // Check for validation errors
            if (!temp.Feedback.Contains("ERROR"))
            {
                // Attempt to add the player to the database
                string result = temp.AddPlayer();

                // If the database operation was successful
                if (!result.Contains("ERROR"))
                {
                    lblFeedback.Text = "SUCCESS: The player was added to the database.";
                }
                else
                {
                    lblFeedback.Text = result; // Show the error from the database operation
                }
            }
            else
            {
                lblFeedback.Text = temp.Feedback; // Show that there's a problem with the information
            }
        }



        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            GamePlayer temp = new GamePlayer();

            // Assuming you have a label lblPlayerID to display the PlayerID
            temp.PlayerID = int.Parse(lblPlayerID.Text);

            temp.PlayerName = txtPlayerName.Text;
            temp.Lives = (int)nudLives.Value;
            temp.Health = (int)nudHealth.Value;
            temp.Strength = (int)nudStrength.Value;
            temp.Armor = (int)nudArmor.Value;
            temp.PlayingSince = dtpPlayingSince.Value;

            double hoursPlayed;
            if (double.TryParse(txtHoursPlayed.Text, out hoursPlayed))
            {
                temp.HoursPlayed = hoursPlayed;
            }
            else
            {
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Hours Played.";
            }

            // Check if there are any validation errors
            if (!temp.Feedback.Contains("ERROR"))
            {
                // If no errors, attempt to update the player in the database
                string result = temp.UpdatePlayer(temp.PlayerID);

                if (result.Contains("ERROR"))
                {
                    lblFeedback.Text = result; // Display any errors from the update operation
                }
                else
                {
                    lblFeedback.Text = "SUCCESS: The player was updated in the database.";
                }
            }
            // Show that there's a problem with the information
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }




        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this player?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
                // The user confirmed the deletion
                GamePlayer temp = new GamePlayer();

                // Retrieve the PlayerID from the form 
                temp.PlayerID = Convert.ToInt32(lblPlayerID.Text);

                // Call the DeletePlayer method and store the result
                string deleteResult = temp.DeletePlayer(temp.PlayerID);

                // Check if the result contains "ERROR"
                if (deleteResult.Contains("ERROR"))
                {
                    // If there's an error, display it
                    lblFeedback.Text = deleteResult;
                }
                else
                {
                    // If deletion was successful, display a success message
                    lblFeedback.Text = "SUCCESS: The player was successfully deleted...probably was trash anyways";
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
