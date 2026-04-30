namespace Backery
{
    partial class AdminProductDetails
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
            BackGround = new Panel();
            CategoryField = new ComboBox();
            CancelButton = new Button();
            CompleteButton = new Button();
            DetailField = new TextBox();
            CostField = new TextBox();
            NameField = new TextBox();
            productPicture = new PictureBox();
            PictureImageDialog = new OpenFileDialog();
            BackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productPicture).BeginInit();
            SuspendLayout();
            // 
            // BackGround
            // 
            BackGround.BackColor = Color.Wheat;
            BackGround.Controls.Add(CategoryField);
            BackGround.Controls.Add(CancelButton);
            BackGround.Controls.Add(CompleteButton);
            BackGround.Controls.Add(DetailField);
            BackGround.Controls.Add(CostField);
            BackGround.Controls.Add(NameField);
            BackGround.Controls.Add(productPicture);
            BackGround.Location = new Point(1, 2);
            BackGround.Name = "BackGround";
            BackGround.Size = new Size(795, 409);
            BackGround.TabIndex = 0;
            BackGround.Paint += BackGround_Paint;
            // 
            // CategoryField
            // 
            CategoryField.BackColor = Color.DarkGoldenrod;
            CategoryField.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryField.FlatStyle = FlatStyle.Flat;
            CategoryField.Font = new Font("Segoe UI", 18F);
            CategoryField.FormattingEnabled = true;
            CategoryField.Location = new Point(409, 196);
            CategoryField.Name = "CategoryField";
            CategoryField.Size = new Size(368, 40);
            CategoryField.TabIndex = 12;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelButton.AutoSize = true;
            CancelButton.BackColor = Color.DarkGoldenrod;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Segoe UI", 24F);
            CancelButton.ForeColor = Color.LightGoldenrodYellow;
            CancelButton.Location = new Point(442, 302);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(304, 68);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CompleteButton
            // 
            CompleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CompleteButton.AutoSize = true;
            CompleteButton.BackColor = Color.DarkGoldenrod;
            CompleteButton.FlatStyle = FlatStyle.Popup;
            CompleteButton.Font = new Font("Segoe UI", 24F);
            CompleteButton.ForeColor = Color.LightGoldenrodYellow;
            CompleteButton.Location = new Point(41, 302);
            CompleteButton.Name = "CompleteButton";
            CompleteButton.Size = new Size(304, 68);
            CompleteButton.TabIndex = 10;
            CompleteButton.Text = "Добавить";
            CompleteButton.UseVisualStyleBackColor = false;
            CompleteButton.Click += CompleteButton_Click;
            // 
            // DetailField
            // 
            DetailField.BackColor = Color.DarkGoldenrod;
            DetailField.BorderStyle = BorderStyle.None;
            DetailField.Font = new Font("Segoe UI", 18F);
            DetailField.ForeColor = Color.LightGoldenrodYellow;
            DetailField.Location = new Point(408, 86);
            DetailField.Multiline = true;
            DetailField.Name = "DetailField";
            DetailField.Size = new Size(369, 104);
            DetailField.TabIndex = 3;
            DetailField.Text = "Состав";
            DetailField.Click += DetailField_Click;
            // 
            // CostField
            // 
            CostField.BackColor = Color.Wheat;
            CostField.BorderStyle = BorderStyle.None;
            CostField.Font = new Font("Segoe UI", 18F);
            CostField.Location = new Point(408, 48);
            CostField.Name = "CostField";
            CostField.Size = new Size(369, 32);
            CostField.TabIndex = 2;
            CostField.Text = "Цена";
            CostField.TextAlign = HorizontalAlignment.Center;
            CostField.Click += CostField_Click;
            // 
            // NameField
            // 
            NameField.BackColor = Color.Wheat;
            NameField.BorderStyle = BorderStyle.None;
            NameField.Font = new Font("Segoe UI", 18F);
            NameField.Location = new Point(408, 10);
            NameField.Name = "NameField";
            NameField.Size = new Size(369, 32);
            NameField.TabIndex = 1;
            NameField.Text = "Название";
            NameField.TextAlign = HorizontalAlignment.Center;
            NameField.Click += NameField_Click;
            // 
            // productPicture
            // 
            productPicture.BackgroundImageLayout = ImageLayout.Stretch;
            productPicture.Image = Properties.Resources.iconApp;
            productPicture.Location = new Point(11, 10);
            productPicture.Name = "productPicture";
            productPicture.Size = new Size(391, 255);
            productPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            productPicture.TabIndex = 0;
            productPicture.TabStop = false;
            productPicture.Click += productPicture_Click;
            // 
            // PictureImageDialog
            // 
            PictureImageDialog.DefaultExt = "jpg";
            PictureImageDialog.Filter = "Фото|*.jpg;*.png;*.jfif";
            PictureImageDialog.Title = "Выберите изображение";
            // 
            // AdminProductDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 414);
            Controls.Add(BackGround);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProductDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProductDetails";
            Load += AdminProductDetails_Load;
            BackGround.ResumeLayout(false);
            BackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BackGround;
        private TextBox NameField;
        private PictureBox productPicture;
        private TextBox CostField;
        private TextBox DetailField;
        private Button CancelButton;
        private Button CompleteButton;
        private OpenFileDialog PictureImageDialog;
        private ComboBox CategoryField;
    }
}