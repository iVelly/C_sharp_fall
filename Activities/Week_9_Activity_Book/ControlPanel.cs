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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.ShowDialog();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBook temp = new SearchBook();
            temp.ShowDialog();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            SearchBook temp = new SearchBook();
            temp.ShowDialog();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SearchBook temp = new SearchBook();
            temp.ShowDialog();
        }
    }
}
