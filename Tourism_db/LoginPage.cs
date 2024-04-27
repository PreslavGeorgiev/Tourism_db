using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_db;

namespace Tourism_db
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void logInButton_Click_1(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("admin"))
            {
                MainMenu mainPage = new MainMenu(true);
                mainPage.Show();
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Countries2; Integrated Security=True;");
                con.Open();
                string query = "SELECT date FROM Users WHERE username=@username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                string date = Convert.ToString(cmd.ExecuteScalar());
                query = "SELECT COUNT(*) FROM Users WHERE username=@username AND hash=@salt";
                cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@salt", hashPassword($"{passwordTextBox.Text}{date}"));
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    MainMenu mainPage = new MainMenu(false);
                    mainPage.Show();
                    return;
                }

                MessageBox.Show("Indvalid username or password");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        string hashPassword(string text)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(text);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}