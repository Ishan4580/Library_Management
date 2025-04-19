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

namespace Library_Book_Manager.Windows_Forms
{
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;port=3309;database=LibraryDb;user=root;password=ishan123";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Books (Title, Author, ISBN, PublicationYear, IsAvailable) " +
                                   "VALUES (@Title, @Author, @ISBN, @Year, @IsAvailable)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title",textBox1.Text);
                    cmd.Parameters.AddWithValue("@Author",textBox2.Text);
                    cmd.Parameters.AddWithValue("@ISBN",textBox3.Text);
                    cmd.Parameters.AddWithValue("@Year",textBox4.Text);
                    cmd.Parameters.AddWithValue("@IsAvailable",checkBox1.Checked); // ✅ Boolean value

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
