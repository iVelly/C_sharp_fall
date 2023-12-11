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
            Customer temp = new Customer();
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
            temp.CustomerSince = dtpCustomerSince.Value;
            
            //
            double totalPurchases;
            // Try to convert the inputText to a double
            if (double.TryParse(txtTotalPurchase.Text, out totalPurchases))
            {
                // Conversion succeeded, it's a valid number
                temp.TotalPurchases = totalPurchases;
            }
            else
            {
                // Cant Convert?, it's not a valid number
                // Show an error message to the user or handle the error correctlyyyyyyy
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Total Purchases.";
            }
            temp.DiscountMember = chbxDiscountMember.Checked;
            
            //temp.RewardsEarned = int.Parse(txtRewardsEarned.Text);
            int rewardsEarned;
            // Try to convert the inputText to a integer
            if (int.TryParse(txtRewardsEarned.Text, out rewardsEarned))
            {
                // Conversion succeeded, it's a valid number
                temp.RewardsEarned = rewardsEarned;
            }
            else
            {
                // Cant Convert?, it's not a valid number
                // Show an error message to the user or handle the error correctlyyyyyyy
                temp.Feedback += "\nERROR: Please enter a valid numeric value for Rewards Earned.";
            }

            //If there's no big problem with the person's information
            if (temp.Feedback.Contains("ERROR") == false)
            {
                lblFeedback.Text = "User Information"
        + "\nFirst Name: " + temp.FirstName
        + "\nMiddle Name: " + temp.MiddleName
        + "\nLast Name: " + temp.LastName
        + "\nPrimary Address: " + temp.Street1
        + "\nSecondary Address: " + temp.Street2
        + "\nState: " + temp.State
        + "\nCity: " + temp.City
        + "\nEmail: " + temp.Email
        + "\nZip Code: " + temp.Zip
        + "\nPhone Number: " + temp.Phone
        + "\nCustomer Since: " + temp.CustomerSince.ToString("yyyy-MM-dd")
        + "\nTotal Purchases: " +"$" +temp.TotalPurchases
        + "\nDiscount Member: " + temp.DiscountMember
        + "\nRewards Earned: " + temp.RewardsEarned;
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
