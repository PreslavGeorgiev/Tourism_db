namespace Tourism_db
{
    partial class RegisterPage
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
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtConfirm = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            button1 = new Button();
            label5 = new Label();
            clickHereButton = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 41);
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
            label2.Location = new Point(95, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 1;
            label2.Text = "Confirm Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(157, 173);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(160, 219);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(285, 40);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 32);
            txtUsername.TabIndex = 4;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirm.Location = new Point(285, 126);
            txtConfirm.Margin = new Padding(2);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(150, 32);
            txtConfirm.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(285, 172);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 32);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(285, 217);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 32);
            txtLastName.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(234, 280);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(113, 43);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(194, 328);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 9;
            label5.Text = "Already have an account?";
            // 
            // clickHereButton
            // 
            clickHereButton.AutoSize = true;
            clickHereButton.Location = new Point(335, 328);
            clickHereButton.Margin = new Padding(2, 0, 2, 0);
            clickHereButton.Name = "clickHereButton";
            clickHereButton.Size = new Size(62, 15);
            clickHereButton.TabIndex = 10;
            clickHereButton.Text = "Click here!";
            clickHereButton.Click += label6_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(285, 82);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 32);
            txtPassword.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(168, 84);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 12;
            label7.Text = "Password:";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 403);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(clickHereButton);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtConfirm);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "RegisterPage";
            Text = "Register Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtConfirm;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button button1;
        private Label label5;
        private Label clickHereButton;
        private TextBox txtPassword;
        private Label label7;
    }
}