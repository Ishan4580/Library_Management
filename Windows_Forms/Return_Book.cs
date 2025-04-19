using Library_Book_Manager.models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Library_Book_Manager.Windows_Forms
{
    public partial class Return_Book : Form
    {
        string connectionString = "server=localhost;port=3309;database=LibraryDb;user=root;password=ishan123";

        public Return_Book()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            string email = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
                return;
            }



            string query = @"  SELECT
    book_borrowing.Id AS BorrowId,
book_borrowing.BookId,   
    books.Title AS BookTitle,
    book_borrowing.BorrowDate,
    book_borrowing.ReturnDate
            FROM
    members
JOIN
    book_borrowing ON members.Id = book_borrowing.MemberId
JOIN
    books ON book_borrowing.BookId = books.Id
WHERE
    members.Email = @Email AND book_borrowing.ReturnDate IS NULL;";
            //AND book_borrowing.ReturnDate IS NULL



            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No books currently borrowed by this member.");
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string bookTitle = row.Cells["BookTitle"].Value.ToString();
                string borrowDate = Convert.ToDateTime(row.Cells["BorrowDate"].Value).ToString();

                // Assuming you have label controls like labelBookTitle and labelBorrowDate
                lib_bookname.Text = bookTitle;
                lib_borrowdate.Text = borrowDate;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int borrowId = Convert.ToInt32(row.Cells["BorrowId"].Value);
                DateTime returnDate = dateTimePicker1.Value;

                // Get BookId from selected row to update book availability
                int bookId = Convert.ToInt32(row.Cells["BookId"].Value);

                string updateReturnQuery = "UPDATE book_borrowing SET ReturnDate = @ReturnDate WHERE Id = @BorrowId";
                string updateAvailabilityQuery = "UPDATE books SET IsAvailable = 1 WHERE Id = @BookId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                using (MySqlCommand cmdReturn = new MySqlCommand(updateReturnQuery, conn))
                using (MySqlCommand cmdBookUpdate = new MySqlCommand(updateAvailabilityQuery, conn))
                {
                    cmdReturn.Parameters.AddWithValue("@ReturnDate", returnDate);
                    cmdReturn.Parameters.AddWithValue("@BorrowId", borrowId);

                    cmdBookUpdate.Parameters.AddWithValue("@BookId", bookId);

                    panel3.Visible = true;

                    try
                    {
                        conn.Open();

                        int result = cmdReturn.ExecuteNonQuery();
                        if (result > 0)
                        {
                            // Now mark the book as available
                            cmdBookUpdate.ExecuteNonQuery();

                            MessageBox.Show("Book returned successfully.");

                            //LoadBorrowedBooks(); // Refresh table
                            lib_bookname.Text = "";
                            lib_borrowdate.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Book return failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }
    }
}
