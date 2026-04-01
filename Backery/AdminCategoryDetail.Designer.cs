namespace Backery
{
    partial class AdminCategoryDetail
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
            OkButton = new Button();
            CancelButton = new Button();
            CategoryNameField = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.DarkGoldenrod;
            OkButton.Font = new Font("Segoe UI", 24F);
            OkButton.ForeColor = Color.LightGoldenrodYellow;
            OkButton.Location = new Point(58, 351);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(288, 60);
            OkButton.TabIndex = 1;
            OkButton.Text = "Принять\\Создать";
            OkButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkGoldenrod;
            CancelButton.Font = new Font("Segoe UI", 24F);
            CancelButton.ForeColor = Color.LightGoldenrodYellow;
            CancelButton.Location = new Point(443, 351);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(288, 60);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CategoryNameField
            // 
            CategoryNameField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryNameField.BackColor = Color.DarkGoldenrod;
            CategoryNameField.BorderStyle = BorderStyle.None;
            CategoryNameField.Font = new Font("Segoe UI", 36F);
            CategoryNameField.ForeColor = Color.LightGoldenrodYellow;
            CategoryNameField.Location = new Point(191, 113);
            CategoryNameField.Name = "CategoryNameField";
            CategoryNameField.Size = new Size(416, 64);
            CategoryNameField.TabIndex = 8;
            CategoryNameField.Text = "Название";
            CategoryNameField.TextAlign = HorizontalAlignment.Center;
            CategoryNameField.Click += CategoryNameField_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 443);
            panel1.TabIndex = 9;
            // 
            // AdminCategoryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(CategoryNameField);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCategoryDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCategoryDetail";
            Load += AdminCategoryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Button CancelButton;
        private TextBox CategoryNameField;
        private Panel panel1;
    }
}