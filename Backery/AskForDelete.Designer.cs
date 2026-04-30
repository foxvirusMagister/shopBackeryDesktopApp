namespace Backery
{
    partial class AskForDelete
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
            BackGroundPanel = new Panel();
            NoButton = new Button();
            YesButton = new Button();
            label1 = new Label();
            BackGroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackGroundPanel
            // 
            BackGroundPanel.BackColor = Color.Wheat;
            BackGroundPanel.Controls.Add(NoButton);
            BackGroundPanel.Controls.Add(YesButton);
            BackGroundPanel.Controls.Add(label1);
            BackGroundPanel.Location = new Point(2, 1);
            BackGroundPanel.Name = "BackGroundPanel";
            BackGroundPanel.Size = new Size(796, 448);
            BackGroundPanel.TabIndex = 0;
            // 
            // NoButton
            // 
            NoButton.BackColor = Color.DarkGoldenrod;
            NoButton.Font = new Font("Segoe UI", 24F);
            NoButton.ForeColor = Color.LightGoldenrodYellow;
            NoButton.Location = new Point(530, 258);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(193, 93);
            NoButton.TabIndex = 2;
            NoButton.Text = "Нет";
            NoButton.UseVisualStyleBackColor = false;
            NoButton.Click += NoButton_Click;
            // 
            // YesButton
            // 
            YesButton.BackColor = Color.DarkGoldenrod;
            YesButton.Font = new Font("Segoe UI", 24F);
            YesButton.ForeColor = Color.LightGoldenrodYellow;
            YesButton.Location = new Point(37, 258);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(193, 93);
            YesButton.TabIndex = 1;
            YesButton.Text = "Да";
            YesButton.UseVisualStyleBackColor = false;
            YesButton.Click += YesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(144, 36);
            label1.Name = "label1";
            label1.Size = new Size(530, 45);
            label1.TabIndex = 0;
            label1.Text = "Вы действительно хотите удалить?";
            // 
            // AskForDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(BackGroundPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AskForDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AskForDelete";
            BackGroundPanel.ResumeLayout(false);
            BackGroundPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackGroundPanel;
        private Label label1;
        private Button YesButton;
        private Button NoButton;
    }
}