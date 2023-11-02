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
            //Fill the text property of the Feedback variable with the book title, price, and date published with some descriptive text/strings
            // the "value" property of a DateTimePicket returns variable. We converted it to a string in a append it to the string/text.
            lblFeedback.Text = " Book Added: " + txtTitle.Text + "($" + txtPrice.Text + ") - Published " + dtpDatePublished.Value.ToString();
        }
    }
}
