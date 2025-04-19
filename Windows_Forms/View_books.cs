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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Book_Manager.Windows_Forms
{
   

    public partial class View_books : Form
    {
        

        string connectionString = "server=localhost;port=3309;database=LibraryDb;user=root;password=ishan123";
        public View_books()
        {
            InitializeComponent();
        }

        private void View_books_Load(object sender, EventArgs e)
        {

            display();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                int i = 0;
                try
                {
                    conn.Open();
                    string query = "select * from books where Title like('%" + textBox1.Text + "%')";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    i = Convert.ToInt32(table.Rows.Count.ToString());

                    dataGridView1.DataSource = table;

                    if (i == 0)
                    {
                        MessageBox.Show("No Book Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            panel2.Visible = true;

            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from books where id = " + i + "";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    foreach (DataRow row in table.Rows)
                    {
                        Title.Text = row["Title"].ToString();
                        Author.Text = row["Author"].ToString();
                        ISBN.Text = row["ISBN"].ToString();
                        Publication_Year.Text = row["PublicationYear"].ToString();
                        checkBox1.Checked = Convert.ToBoolean(row["IsAvailable"]);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE books SET Title = @Title, Author = @Author, ISBN = @ISBN, " +
                           "PublicationYear = @Year, IsAvailable = @IsAvailable WHERE Id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", Title.Text);
                    cmd.Parameters.AddWithValue("@Author", Author.Text);
                    cmd.Parameters.AddWithValue("@ISBN", ISBN.Text);
                    cmd.Parameters.AddWithValue("@Year", Publication_Year.Text);
                    cmd.Parameters.AddWithValue("@IsAvailable", checkBox1.Checked);
                    cmd.Parameters.AddWithValue("@Id", i);

                    cmd.ExecuteNonQuery();

                    display();

                    MessageBox.Show("Update Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        public void display()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from books";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Books WHERE Id = @Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", i);


                    cmd.ExecuteNonQuery();

                    display();

                    MessageBox.Show("Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
