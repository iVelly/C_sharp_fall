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
    public partial class SearchPerson : Form
    {
        public SearchPerson()
        {
            InitializeComponent();
        }

        private void btnSearchAPerson_Click(object sender, EventArgs e)
        {
            // Create an instance of the PersonV2 class
            PersonV2 temp = new PersonV2();

            // Assuming that you have a method called SearchPeople which accepts first name and last name
            // and returns a DataSet containing the search results
            DataSet ds = temp.SearchPeople(txtFirstNameBox.Text, txtLastNameBox.Text);

            // Display the search results in a DataGridView control
            dgvResults.DataSource = ds;
            dgvResults.DataMember = ds.Tables["People_Temp"].ToString(); // Use the appropriate table name from your DataSet

        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gather the information (Gathers the row clicked, then chooses the first cell's data)
            string personIDStr = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            // display the ID in a MessageBox
            MessageBox.Show("Person ID: " + personIDStr);

            // Convert the string ID to an integer
            int personID = Convert.ToInt32(personIDStr);

            // Create the editor form, passing it one Person's ID and show it
            Form1 Editor = new Form1(personID);
            Editor.ShowDialog();

        }

        private void SearchPerson_Load(object sender, EventArgs e)
        {

        }


    }
}
