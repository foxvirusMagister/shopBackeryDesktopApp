namespace Backery
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            LoginButton = new Button();
            Title = new Label();
            underTitle = new Label();
            Logo = new PictureBox();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LoginButton.BackColor = Color.DarkGoldenrod;
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.ForeColor = Color.LightGoldenrodYellow;
            LoginButton.Location = new Point(538, 12);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(82, 40);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Segoe UI", 42F);
            Title.Location = new Point(81, 127);
            Title.Name = "Title";
            Title.Size = new Size(524, 74);
            Title.TabIndex = 2;
            Title.Text = "Добро пожаловать";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Click += MainMenu_Click;
            // 
            // underTitle
            // 
            underTitle.Anchor = AnchorStyles.Bottom;
            underTitle.AutoSize = true;
            underTitle.BackColor = Color.Transparent;
            underTitle.Font = new Font("Segoe UI", 26F);
            underTitle.Location = new Point(46, 211);
            underTitle.Name = "underTitle";
            underTitle.Size = new Size(574, 47);
            underTitle.TabIndex = 3;
            underTitle.Text = "Нажмите по экрану что бы начать";
            underTitle.TextAlign = ContentAlignment.MiddleCenter;
            underTitle.Click += MainMenu_Click;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Logo.BackColor = Color.Transparent;
            Logo.BackgroundImageLayout = ImageLayout.None;
            Logo.Image = Properties.Resources.logo21;
            Logo.Location = new Point(12, -71);
            Logo.Name = "Logo";
            Logo.Size = new Size(352, 348);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            Logo.Click += MainMenu_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.AutoSize = true;
            ExitButton.BackColor = Color.DarkGoldenrod;
            ExitButton.Font = new Font("Segoe UI", 12F);
            ExitButton.ForeColor = Color.LightGoldenrodYellow;
            ExitButton.Location = new Point(12, 285);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(82, 40);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(648, 337);
            Controls.Add(ExitButton);
            Controls.Add(underTitle);
            Controls.Add(Title);
            Controls.Add(LoginButton);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "Добро пожаловать";
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            Click += MainMenu_Click;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginButton;
        private Label Title;
        private Label underTitle;
        private PictureBox Logo;
        private Button ExitButton;
    }
}
