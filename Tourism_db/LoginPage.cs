using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            bool showAdminButton = false;
            if ((usernameTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("admin")) || (usernameTextBox.Text.Equals("user") && passwordTextBox.Text.Equals("user")))
            {
                if (usernameTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("admin"))
                {
                    showAdminButton = true;
                }

                MainMenu form3 = new MainMenu(showAdminButton);
                this.Hide();
                form3.Show();
            }
            else
                MessageBox.Show("Indvalid username or password");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}