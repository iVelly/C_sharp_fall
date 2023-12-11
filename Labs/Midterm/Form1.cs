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
            People temp = new People();
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

            
            lblFeedback.Text = "User Information" + "\nFirst Name: " + temp.FirstName + "\nMiddle Name: " + temp.MiddleName + "\nLast Name: " + temp.LastName + "\nPrimary Address: " + temp.Street1 + "\nSecondary Address: " + temp.Street2 + "\nState: " + temp.State + "\nCity: " + temp.City + "\nEmail: " + temp.Email + "\nZip Code: " + temp.Zip + "\nPhone Number: " + temp.Phone;
        }

        private void BigLetters_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
