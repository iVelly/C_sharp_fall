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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            FillOutInfo temp = new FillOutInfo();
            temp.ShowDialog();
        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {
            SearchPlayer temp = new SearchPlayer();
            temp.ShowDialog();
        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            SearchPlayer temp = new SearchPlayer();
            temp.ShowDialog();
        }

        private void btnDeletePlayer_Click_1(object sender, EventArgs e)
        {
            SearchPlayer temp = new SearchPlayer();
            temp.ShowDialog();
        }

        private void btnCalTotRev_Click(object sender, EventArgs e)
        {
            AverageScreen temp = new AverageScreen();
            temp.ShowDialog();
        }

        private void btnCalTotHours_Click(object sender, EventArgs e)
        {
            TotalScreen temp = new TotalScreen();
            temp.ShowDialog();
        }
    }
}
