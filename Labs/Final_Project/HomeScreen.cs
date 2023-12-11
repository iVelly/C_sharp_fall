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

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            FillOutInfo temp = new FillOutInfo();
            temp.ShowDialog();
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            SearchEvent temp = new SearchEvent();
            temp.ShowDialog();
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            SearchEvent temp = new SearchEvent();
            temp.ShowDialog();
        }

        private void btnDeleteEvent_Click_1(object sender, EventArgs e)
        {
            SearchEvent temp = new SearchEvent();
            temp.ShowDialog();
        }

        private void btnCalTotRev_Click(object sender, EventArgs e)
        {
            TotalRevScreen temp = new TotalRevScreen();
            temp.ShowDialog();
        }
    }
}
