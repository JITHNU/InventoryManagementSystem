using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                label1.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-7JUK9DS\\SQLEXPRESS04; Database=MyProject; Trusted_Connection=True;"))
                {
                    conn.Open();

                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string adminName = reader["Username"].ToString(); // get the logged-in name

                        // Login successful
                        this.Hide();
                        Dashboard dashboard = new Dashboard(adminName); // pass name
                        dashboard.Show();
                    }
                    else
                    {
                        label1.Text = "Invalid username or password.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
