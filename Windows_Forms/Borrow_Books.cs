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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Book_Manager.Windows_Forms
{
    public partial class Borrow_Books : Form
    {
        // Dictionary to map book titles to IDs
        public Dictionary<string, int> bookMap = new Dictionary<string, int>();
    

        string connectionString = "server=localhost;port=3309;database=LibraryDb;user=root;password=ishan123";

        public Borrow_Books()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i = 0;


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from members where email ='" + txt_email.Text + "'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    i = Convert.ToInt32(table.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Email Not Found");
                    }
                    else
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            txt_memberid.Text = row["id"].ToString();
                            txt_name.Text = row["name"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txt_Title_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;

            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();
                bookMap.Clear(); // clear the previous search result


                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string query = "SELECT * FROM Books WHERE Title LIKE @title";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@title", "%" + txt_bookname.Text + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            listBox1.Visible = true;

                            foreach (DataRow row in table.Rows)
                            {
                                //listBox1.Items.Add(row["Title"].ToString());
                                ////txt_bookid.Text = row["Id"].ToString(); // shows the last book's ID
                                ///
                                string title = row["Title"].ToString();
                                int bookId = Convert.ToInt32(row["Id"]);

                                // Store title -> id mapping
                                if (!bookMap.ContainsKey(title))
                                {
                                    bookMap.Add(title, bookId);
                                    listBox1.Items.Add(title);
                                }
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }



        private void txt_bookname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                listBox1.Focus();
                //you might need select to value to allow arrow keys
                listBox1.SelectedIndex = 0;

            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    txt_bookname.Text = listBox1.SelectedItem.ToString();
            //    txt_bookid.Text = listBox1.SelectedItem.;
            //    listBox1.Visible = false;
            //}

            if (e.KeyCode == Keys.Enter && listBox1.SelectedItem != null)
            {
                string selectedTitle = listBox1.SelectedItem.ToString();
                txt_bookname.Text = selectedTitle;

                if (bookMap.ContainsKey(selectedTitle))
                {
                    txt_bookid.Text = bookMap[selectedTitle].ToString();
                }

                listBox1.Visible = false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //txt_bookname.Text = listBox1.SelectedIndex.ToString();
            ////txt_bookid.Text = listBox1.SelectedIndex.
            //listBox1.Visible = false;
            if (listBox1.SelectedItem != null)
            {
                string selectedTitle = listBox1.SelectedItem.ToString();
                txt_bookname.Text = selectedTitle;

                if (bookMap.ContainsKey(selectedTitle))
                {
                    txt_bookid.Text = bookMap[selectedTitle].ToString();
                }

                listBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //  Check if the book is available
                    string checkQuery = "SELECT IsAvailable FROM Books WHERE Id = @BookId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@BookId", txt_bookid.Text);

                    object result = checkCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Book not found.");
                        return;
                    }

                    bool isAvailable = Convert.ToBoolean(result);

                    if (!isAvailable)
                    {
                        MessageBox.Show("Book is not available right now.");
                        return;
                    }


                    //Insert borrow record
                    string query = "INSERT INTO book_borrowing ( BookId , MemberId , BorrowDate , ReturnDate ) " +
                                   "VALUES (@BookId, @MemberId, @BorrowDate, NULL)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookId", txt_bookid.Text);
                    cmd.Parameters.AddWithValue("@MemberId", txt_memberid.Text);
                    cmd.Parameters.AddWithValue("@BorrowDate", dateTimePicker1.Value);
                    //cmd.Parameters.AddWithValue("@ReturnDate", dateTimePicker2.Value);

                    int rows = cmd.ExecuteNonQuery();

                    // 2 Update book availability
                    if (rows > 0)
                    {
                        string updateQuery = "UPDATE Books SET IsAvailable = 0 WHERE Id = @BookId";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@BookId", txt_bookid.Text);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Book borrowed successfully");
                    }
                    else
                    {
                        MessageBox.Show("Borrowing failed.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
        
    }
}
