using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();
            temp.FirstName = txtfirstName.Text;
            temp.MiddleName = txtmiddleName.Text;
            temp.LastName = txtlastName.Text;
            temp.Street1 = txtstreet1.Text;
            temp.Street2 = txtstreet2.Text;
            temp.City = txtcity.Text;
            temp.State = txtstate.Text;
            temp.Zip = txtzip.Text;
            temp.Phone = txtphone.Text;
            temp.Email = txtemail.Text;
            temp.CellPhone = txtCellPhone.Text;
            temp.InstagramURL = txtInstagram.Text;

            //If there's no big problem with the person's information:
            if (temp.Feedback.Contains("ERROR") == false)
            {
                // Attempt to add the record to the database
                string result = temp.AddARecord();
                // If the database operation was successful
                if (result.Contains("ERROR") == false)
                {
                    lblFeedback.Text = "SUCCESS: The record was added to the database.";
                }
                else
                {
                    lblFeedback.Text = result; // Show the error from the database operation
                }

                //lblFeedback.Text = "User Information"
        //+ "\nFirst Name: " + temp.FirstName
        //+ "\nMiddle Name: " + temp.MiddleName
       // + "\nLast Name: " + temp.LastName
        //+ "\nPrimary Address: " + temp.Street1
        //+ "\nSecondary Address: " + temp.Street2
        //+ "\nState: " + temp.State
        //+ "\nCity: " + temp.City
        //+ "\nZip Code: " + temp.Zip
        //+ "\nPhone Number: " + temp.Phone
        //+ "\n InstagramURL: " + temp.InstagramURL
       // + "\n Cell Phone: " + temp.CellPhone;
            }
            //Show that there's a problem with the information
            else
            {
                lblFeedback.Text = temp.Feedback;
            }



        }

        private void BigLetters_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInstagram_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRewardsEarned_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpCustomerSince_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
