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
    public partial class SearchPlayer : Form
    {
        public SearchPlayer()
        {
            InitializeComponent();
        }

        private void SearchEvent_Load(object sender, EventArgs e)
        {

        }

        private void txtNameOfEventBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            // Create an instance of the GamePlayer class
            GamePlayer temp = new GamePlayer();

            // Call the method to search players. 
            string playerName = txtPlayerName.Text; 

            DataSet ds = temp.SearchPlayers(playerName);

            // Display the results in a DataGridView
            dgvResults.DataSource = ds; // dgvResults is your DataGridView
            dgvResults.DataMember = "Players_Temp"; // This should match the name used in the DataSet
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gather the information (Gathers the row clicked, then chooses the first cell's data)
            string playerIdStr = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            // display the ID in a MessageBox 
            MessageBox.Show("Player ID: " + playerIdStr);

            // Convert the string ID to an integer
            int playerID = Convert.ToInt32(playerIdStr);

            // Create the editor form, passing it one Player's ID, and show it
            FillOutInfo playerEditor = new FillOutInfo(playerID);
            playerEditor.ShowDialog();
        }
    }
}
