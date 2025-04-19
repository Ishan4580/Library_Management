using Library_Book_Manager.DataBase;

namespace Library_Book_Manager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            using (var context = new LibraryContext())
            {
                var user = context.lib_People.FirstOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {
                    mdi_user mu = new mdi_user();
                    mu.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
        }
    }
}
