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

namespace Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Hide the Delete Buttons
            btnDelete.Enabled = false;
            btnDelete.Visible = false;

            //Hide the Update Buttons
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
        }

        public Form1(int personID)
        {
            InitializeComponent(); // Initializes all form objects

            //Hide the Add Button
            btnAdd.Enabled = false;
            btnAdd.Visible = false;

            // Create an instance of PersonV2 to access its methods
            PersonV2 temp = new PersonV2();

            // Assuming you have a method like FindOnePerson in PersonV2 class
            SqlDataReader dr = temp.FindOnePerson(personID);

            // Use the information to fill out the form
            while (dr.Read()) // If there's data available
            {
                // Take the data from the datareader and copy them into the appropriate text fields
                txtfirstName.Text = dr["FirstName"].ToString();
                txtmiddleName.Text = dr["MiddleName"].ToString();
                txtlastName.Text = dr["LastName"].ToString();
                txtstreet1.Text = dr["Street1"].ToString();
                txtstreet2.Text = dr["Street2"].ToString();
                txtcity.Text = dr["City"].ToString();
                txtstate.Text = dr["State"].ToString();
                txtzip.Text = dr["Zip"].ToString();
                txtphone.Text = dr["Phone"].ToString();
                txtemail.Text = dr["Email"].ToString();
                txtCellPhone.Text = dr["CellPhone"].ToString();
                txtInstagram.Text = dr["InstagramURL"].ToString();

                // Display the person's ID in a label
                lblPersonID.Text = personID.ToString();
            }

            //close the data reader
            dr.Close();
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

            // If there's a PersonID property to uniquely identify the record
            temp.PersonID = Convert.ToInt32(lblPersonID.Text);

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
                    lblFeedback.Text = "SUCCESS: The record was updated in the database.";
                }
            }
            else
            {
                // Display the error message
                lblFeedback.Text = temp.Feedback;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Create an instance of the PersonV2 class
            PersonV2 temp = new PersonV2();

           
            // Retrieve the PersonID from the form 
            temp.PersonID = Convert.ToInt32(lblPersonID.Text);

            // Call the DeleteARecord method and store the result
            string result = temp.DeleteARecord();

            // Check if the result contains "ERROR"
            if (result.Contains("ERROR"))
            {
                // If there's an error, display it
                lblFeedback.Text = result;
            }
            else
            {
                // If deletion was successful, display a success message
                lblFeedback.Text = "SUCCESS: The record was successfully deleted.";

            }
        }

        

    }
}
