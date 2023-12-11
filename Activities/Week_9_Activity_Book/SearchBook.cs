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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void txtBookTitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchABook_Click(object sender, EventArgs e)
        {
            // Create an instance of the EBook class 
            EBook temp = new EBook();

           
            DataSet ds = temp.SearchBooks(txtBookTitleBox.Text, txtBookIDBox.Text);

            // Display the search results in a DataGridView control
            dgvResults.DataSource = ds;
            dgvResults.DataMember = ds.Tables["Books_Temp"].ToString(); 
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResult_CellDoubleContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gather the clicked row's book ID
            string bookIDStr = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            
            MessageBox.Show("Book ID: " + bookIDStr);

            
             int bookID = Convert.ToInt32(bookIDStr);
             Form1 editorForm = new Form1(bookID);
             editorForm.ShowDialog();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {

        }
    }
}
