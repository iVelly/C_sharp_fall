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
            // Creating a new Book object.
            Book temp = new Book();

            // Setting the Book object's properties based on user input.
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;
            temp.DatePublished = dtpDatePublished.Value;

            // Convert txtPrice.Text to a decimal and assign it to temp.Price.
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                lblFeedback.Text = "Invalid price entered.";
                return; // Exit the method if the price is invalid.
            }
            else
            {
                temp.Price = price; // Assign the price to temp.Price if the conversion is successful.
            }

            // Convert txtPages.Text to an integer and assign it to temp.Pages.
            if (!int.TryParse(txtPages.Text, out int pages))
            {
                lblFeedback.Text = "Invalid number of pages entered.";
                return; // Exit the method if the number of pages is invalid...Without the return, after displaying the error message "Invalid number of pages entered," the method would not stop. It would proceed to the next lines of code... 
            }
            else
            {
                temp.Pages = pages; // Assign the pages to temp.Pages if the conversion is successful.
            }


            // Print Statement
            lblFeedback.Text = "Book Details:\n" +
                   "Title: " + temp.Title + "\n" +
                   "Author: " + temp.AuthorFirst + " " + temp.AuthorLast + "\n" +
                   "Email: " + temp.Email + "\n" +
                   "Date Published: " + temp.DatePublished + "\n" +
                   "Price: $" + temp.Price+ "\n" +
                   "Pages: " + temp.Pages;

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
    }
}
