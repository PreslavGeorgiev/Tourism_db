namespace Tourism_db
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logInButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(126, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(133, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(234, 74);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(167, 32);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(234, 115);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(167, 32);
            passwordTextBox.TabIndex = 3;
            // 
            // logInButton
            // 
            logInButton.BackColor = SystemColors.ActiveCaption;
            logInButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.Location = new Point(220, 179);
            logInButton.Margin = new Padding(2);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(137, 41);
            logInButton.TabIndex = 4;
            logInButton.Text = "Log in";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click_1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 284);
            Controls.Add(logInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "LoginPage";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button logInButton;
    }
}