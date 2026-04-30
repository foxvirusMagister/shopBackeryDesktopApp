namespace Backery
{
    partial class AdminDeleteProductDialog
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
            panel1 = new Panel();
            Title = new Label();
            YesButton = new Button();
            NoButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(NoButton);
            panel1.Controls.Add(YesButton);
            panel1.Controls.Add(Title);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 447);
            panel1.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 26F);
            Title.Location = new Point(45, 60);
            Title.Name = "Title";
            Title.Size = new Size(712, 47);
            Title.TabIndex = 0;
            Title.Text = "Вы действительно хотите удалить продукт?";
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.DarkGoldenrod;
            YesButton.DialogResult = DialogResult.OK;
            YesButton.FlatStyle = FlatStyle.Popup;
            YesButton.Font = new Font("Segoe UI", 26F);
            YesButton.ForeColor = Color.LightGoldenrodYellow;
            YesButton.Location = new Point(73, 261);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(214, 99);
            YesButton.TabIndex = 1;
            YesButton.Text = "ДА";
            YesButton.UseVisualStyleBackColor = false;
            // 
            // NoButton
            // 
            NoButton.BackColor = Color.DarkGoldenrod;
            NoButton.FlatStyle = FlatStyle.Popup;
            NoButton.Font = new Font("Segoe UI", 26F);
            NoButton.ForeColor = Color.LightGoldenrodYellow;
            NoButton.Location = new Point(501, 261);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(214, 99);
            NoButton.TabIndex = 2;
            NoButton.Text = "НЕТ";
            NoButton.UseVisualStyleBackColor = false;
            // 
            // AdminDeleteProductDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDeleteProductDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDeleteProductDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button YesButton;
        private Label Title;
        private Button NoButton;
    }
}