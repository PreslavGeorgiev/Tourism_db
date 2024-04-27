namespace Tourism_db
{
    partial class MainMenu
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
            comboBox1 = new ComboBox();
            adminButton = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 53);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // adminButton
            // 
            adminButton.BackColor = SystemColors.ActiveCaption;
            adminButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            adminButton.Location = new Point(205, 157);
            adminButton.Margin = new Padding(2);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(150, 43);
            adminButton.TabIndex = 1;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(322, 53);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 33);
            comboBox2.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(comboBox2);
            Controls.Add(adminButton);
            Controls.Add(comboBox1);
            Margin = new Padding(2);
            Name = "MainMenu";
            Text = "Main Page";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button adminButton;
        private ComboBox comboBox2;
    }
}