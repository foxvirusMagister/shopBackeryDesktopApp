namespace Backery
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            BackButton = new Button();
            UsernameField = new TextBox();
            PasswordField = new TextBox();
            EnterButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.BackColor = Color.DarkGoldenrod;
            BackButton.Font = new Font("Segoe UI", 12F);
            BackButton.ForeColor = Color.LightGoldenrodYellow;
            BackButton.Location = new Point(22, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(82, 40);
            BackButton.TabIndex = 6;
            BackButton.Text = "Выйти";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // UsernameField
            // 
            UsernameField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameField.BackColor = Color.DarkGoldenrod;
            UsernameField.BorderStyle = BorderStyle.None;
            UsernameField.Font = new Font("Segoe UI", 36F);
            UsernameField.ForeColor = Color.LightGoldenrodYellow;
            UsernameField.Location = new Point(192, 120);
            UsernameField.Name = "UsernameField";
            UsernameField.Size = new Size(416, 64);
            UsernameField.TabIndex = 7;
            UsernameField.Text = "Логин";
            UsernameField.TextAlign = HorizontalAlignment.Center;
            UsernameField.Click += ClearField;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordField.BackColor = Color.DarkGoldenrod;
            PasswordField.BorderStyle = BorderStyle.None;
            PasswordField.Font = new Font("Segoe UI", 36F);
            PasswordField.ForeColor = Color.LightGoldenrodYellow;
            PasswordField.Location = new Point(192, 242);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(416, 64);
            PasswordField.TabIndex = 8;
            PasswordField.Text = "Пароль";
            PasswordField.TextAlign = HorizontalAlignment.Center;
            PasswordField.Click += ClearField;
            // 
            // EnterButton
            // 
            EnterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnterButton.AutoSize = true;
            EnterButton.BackColor = Color.DarkGoldenrod;
            EnterButton.Font = new Font("Segoe UI", 26F);
            EnterButton.ForeColor = Color.LightGoldenrodYellow;
            EnterButton.Location = new Point(311, 356);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(176, 61);
            EnterButton.TabIndex = 9;
            EnterButton.Text = "Вход";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(EnterButton);
            Controls.Add(PasswordField);
            Controls.Add(UsernameField);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private TextBox UsernameField;
        private TextBox PasswordField;
        private Button EnterButton;
    }
}