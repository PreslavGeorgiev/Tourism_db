using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_db
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }
        string hashPassword(string text)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(text);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtUsername, txtPassword, txtConfirm, txtFirstName, txtLastName };

            string salt = string.Empty;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(textBoxes[i].Text))
                {
                    MessageBox.Show("Please fill in all the boxes!");
                    break;
                }
                else
                {
                    if (!txtUsername.Text.Contains("@"))
                    {
                        MessageBox.Show("Invalid email entered.");
                        return;
                    }

                    string special = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
                    if (!Regex.IsMatch(txtPassword.Text, special))
                    {
                        MessageBox.Show("Password needs more special characters");
                        return;
                    }

                    if (txtPassword.Text.Equals(txtConfirm.Text))
                    {
                        salt = DateTime.Now.ToString();
                        txtConfirm.Text = salt;
                        string password = txtPassword.Text;
                        string hash = hashPassword($"{password}{salt}");

                        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Countries2;Integrated Security=True;");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE username=@username", con);
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text;
                        if (Convert.ToInt32(cmd.ExecuteScalar()) != 0)
                        {
                            MessageBox.Show("User already exists");
                            return;
                        }
                        cmd = new SqlCommand("INSERT INTO Users(username, date, hash) VALUES(@username, @salt, @hash)", con);
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUsername.Text;
                        cmd.Parameters.Add("@salt", SqlDbType.DateTime).Value = salt;
                        cmd.Parameters.Add("@hash", SqlDbType.NVarChar).Value = hash;
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("INSERT INTO CreatedUsers(username) VALUES(@username)", con);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User was successfully registered!");

                        LoginPage loginPage = new LoginPage();
                        this.Hide();
                        loginPage.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match!");
                        break;
                    }
                }
            }
        }
    }
}
