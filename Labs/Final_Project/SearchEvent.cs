using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class SearchEvent : Form
    {
        public SearchEvent()
        {
            InitializeComponent();
        }

        private void SearchEvent_Load(object sender, EventArgs e)
        {

        }

        private void txtNameOfEventBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            // Create an instance of the Event class
            Event temp = new Event();

            // Call the method to search events. 
            string nameOfEvent = txtNameOfEventBox.Text; 
            

            DataSet ds = temp.SearchEvents(nameOfEvent);

            // Display the results in a DataGridView
            dgvResults.DataSource = ds; // dgvResults is your DataGridView
            dgvResults.DataMember = "Events_Temp"; // This should match the name used in the DataSet
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gather the information (Gathers the row clicked, then chooses the first cell's data)
            string eventIdStr = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            // display the ID in a MessageBox 
            MessageBox.Show("Event ID: " + eventIdStr);

            // Convert the string ID to an integer
            int eventID = Convert.ToInt32(eventIdStr);

            // Create the editor form, passing it one Event's ID, and show it
            // Replace 'FillOutInfo' with the actual name of your form used for editing an event
            FillOutInfo eventEditor = new FillOutInfo(eventID);
            eventEditor.ShowDialog();
        }
    }
}
