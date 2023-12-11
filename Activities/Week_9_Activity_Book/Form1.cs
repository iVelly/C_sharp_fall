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

namespace Lab_5_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Hide the Delete Buttons
            btnDeleteBook.Enabled = false;
            btnDeleteBook.Visible = false;

            //Hide the Update Buttons
            btnUpdateBook.Enabled = false;
            btnUpdateBook.Visible = false;
        }
        public Form1(int bookID)
        {
            InitializeComponent(); // Initializes all form objects

            // Create an instance of EBook to access its methods
            EBook temp = new EBook();

            // Assuming you have a method like FindOneBook in EBook class
            SqlDataReader dr = temp.FindOneEBook(bookID);

            // Use the information to fill out the form
            while (dr.Read()) // If there's data available
            {
                // Take the data from the datareader and copy them into the appropriate text fields
                txtTitle.Text = dr["Title"].ToString();
                txtAuthorFirst.Text = dr["AuthorFirst"].ToString();
                txtAuthorLast.Text = dr["AuthorLast"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                dtpDatePublished.Value = DateTime.Parse(dr["DatePublished"].ToString());
                txtPrice.Text = dr["Price"].ToString();
                txtPages.Text = dr["Pages"].ToString();
                dtpRentalDueDate.Value = DateTime.Parse(dr["RentalDueDate"].ToString());
                txtBookmarkPage.Text = dr["BookmarkPage"].ToString();

                // Display the book's ID in a label or as needed
                // lblBookID.Text = bookID.ToString();
            }

            // Close the data reader
            dr.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Creating a new EBook object.
            EBook temp = new EBook();

            // Setting the EBook object's properties based on user input.
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;
            temp.DatePublished = dtpDatePublished.Value;

            // Handle the Bookmark Page input
            if (!int.TryParse(txtBookmarkPage.Text, out int bookmarkPage))
            {
                temp.Feedback += "\nError: Invalid bookmark page entered.";
            }
            else
            {
                temp.BookmarkPage = bookmarkPage;
            }

            // Handle the Rental Due Date input
            temp.RentalDueDate = dtpRentalDueDate.Value;

            // Handle the Price input
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                temp.Feedback += "\nError: Invalid price entered.";
            }
            else
            {
                temp.Price = price;
            }

            // Handle the Pages input
            if (!int.TryParse(txtPages.Text, out int pages))
            {
                temp.Feedback += "\nError: Invalid number of pages entered.";
            }
            else
            {
                temp.Pages = pages;
            }

            //If there's no big problem with the person's information:
            if (temp.Feedback.Contains("Error") == false)
            {
                // Attempt to add the record to the database
                string result = temp.AddARecord();
                // If the database operation was successful
                if (result.Contains("Error") == false)
                {
                    lblFeedback.Text = "SUCCESS: The record was added to the database.";
                }
                else
                {
                    lblFeedback.Text = result; // Show the error from the database operation
                }

            }
            //Show that there's a problem with the information
            else
            {
                lblFeedback.Text = temp.Feedback;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPages_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtRentalDueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookmarkPage_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpRentalDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            EBook temp = new EBook();

        
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;
            temp.DatePublished = dtpDatePublished.Value; 
            temp.Price = Convert.ToDecimal(txtPrice.Text); 
            temp.Pages = Convert.ToInt32(txtPages.Text); 
            temp.RentalDueDate = dtpRentalDueDate.Value; 
            temp.BookmarkPage = Convert.ToInt32(txtBookmarkPage.Text); // Convert bookmark page to an int

            // Unique identifier for the book, like a BookID
            temp.BookID = Convert.ToInt32(lblBookID.Text);

            // Validation and update
            if (!temp.Feedback.Contains("ERROR"))
            {
                // If no errors when setting values, then perform the update in the database
                string result = temp.UpdateARecord();

                if (result.Contains("ERROR"))
                {
                    lblFeedback.Text = result; // Display the error from the update operation
                }
                else
                {
                    lblFeedback.Text = "SUCCESS: The book was updated in the database.";
                }
            }
            else
            {
                // Display the error message
                lblFeedback.Text = temp.Feedback;
            }
        }


        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this book record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
                // The user confirmed the deletion
                EBook temp = new EBook();

                // Retrieve the BookID from the form 
                temp.BookID = Convert.ToInt32(lblBookID.Text);

                // Call the DeleteARecord method and store the result
                string deleteResult = temp.DeleteARecord();

                // Check if the result contains "ERROR"
                if (deleteResult.Contains("ERROR"))
                {
                    // If there's an error, display it
                    lblFeedback.Text = deleteResult;
                }
                else
                {
                    // If deletion was successful, display a success message
                    lblFeedback.Text = "SUCCESS: The book was successfully deleted.";
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
