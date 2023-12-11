using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Check if there are any errors in the feedback
            if (!temp.Feedback.Contains("Error"))
            {
                // Display EBook details if no errors
                lblFeedback.Text = "EBook Details:\n" +
                    "Title: " + temp.Title + "\n" +
                    "Author: " + temp.AuthorFirst + " " + temp.AuthorLast + "\n" +
                    "Email: " + temp.Email + "\n" +
                    "Date Published: " + temp.DatePublished + "\n" +
                    "Price: $" + temp.Price + "\n" +
                    "Pages: " + temp.Pages + "\n" +
                    "Rental Due Date: " + temp.RentalDueDate + "\n" +
                    "Bookmark Page: " + temp.BookmarkPage;
            }
            else
            {
                // Show the accumulated error messages in feedback
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
    }
}
