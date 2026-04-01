namespace Backery
{
    partial class ProductDetailsShowUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsShowUser));
            ProductName = new Label();
            ProductPrice = new Label();
            ProductContent = new Label();
            BuyButton = new Button();
            SaveCheck = new SaveFileDialog();
            CancelButton = new Button();
            label1 = new Label();
            ProductPicture = new PictureBox();
            panel1 = new Panel();
            ProductAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductAmount).BeginInit();
            SuspendLayout();
            // 
            // ProductName
            // 
            ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductName.BackColor = Color.DarkGoldenrod;
            ProductName.BorderStyle = BorderStyle.FixedSingle;
            ProductName.Font = new Font("Segoe UI", 22F);
            ProductName.ForeColor = Color.LightGoldenrodYellow;
            ProductName.Location = new Point(379, 4);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(335, 129);
            ProductName.TabIndex = 0;
            ProductName.Text = "NameNAmeNAMENAMENAME";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductPrice
            // 
            ProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPrice.BackColor = Color.DarkGoldenrod;
            ProductPrice.BorderStyle = BorderStyle.FixedSingle;
            ProductPrice.Font = new Font("Segoe UI", 22F);
            ProductPrice.ForeColor = Color.LightGoldenrodYellow;
            ProductPrice.Location = new Point(379, 133);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(335, 59);
            ProductPrice.TabIndex = 1;
            ProductPrice.Text = "PRice";
            ProductPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductContent
            // 
            ProductContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductContent.BackColor = Color.DarkGoldenrod;
            ProductContent.BorderStyle = BorderStyle.FixedSingle;
            ProductContent.Font = new Font("Segoe UI", 18F);
            ProductContent.ForeColor = Color.LightGoldenrodYellow;
            ProductContent.Location = new Point(394, 192);
            ProductContent.Name = "ProductContent";
            ProductContent.Size = new Size(305, 135);
            ProductContent.TabIndex = 3;
            ProductContent.Text = "Descrjegpirgerjgjeroijgoijdfoijgodsijf";
            ProductContent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BuyButton
            // 
            BuyButton.BackColor = Color.DarkGoldenrod;
            BuyButton.Font = new Font("Segoe UI", 20F);
            BuyButton.ForeColor = Color.LightGoldenrodYellow;
            BuyButton.Location = new Point(30, 350);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(305, 66);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Добавить в корзину";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Click += BuyButton_Click;
            // 
            // SaveCheck
            // 
            SaveCheck.DefaultExt = "txt";
            SaveCheck.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            SaveCheck.InitialDirectory = "Рабочий стол";
            SaveCheck.Title = "Сохранить чек";
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DarkGoldenrod;
            CancelButton.Font = new Font("Segoe UI", 24F);
            CancelButton.ForeColor = Color.LightGoldenrodYellow;
            CancelButton.Location = new Point(445, 350);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(217, 66);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Отменить";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.DarkGoldenrod;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 22F);
            label1.ForeColor = Color.LightGoldenrodYellow;
            label1.Location = new Point(30, 249);
            label1.Name = "label1";
            label1.Size = new Size(305, 40);
            label1.TabIndex = 7;
            label1.Text = "Количество";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductPicture
            // 
            ProductPicture.Location = new Point(21, 23);
            ProductPicture.Name = "ProductPicture";
            ProductPicture.Size = new Size(328, 223);
            ProductPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPicture.TabIndex = 8;
            ProductPicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(ProductAmount);
            panel1.Controls.Add(ProductPrice);
            panel1.Controls.Add(ProductName);
            panel1.Controls.Add(ProductContent);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 420);
            panel1.TabIndex = 9;
            // 
            // ProductAmount
            // 
            ProductAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductAmount.BackColor = Color.DarkGoldenrod;
            ProductAmount.BorderStyle = BorderStyle.None;
            ProductAmount.Font = new Font("Segoe UI", 26F);
            ProductAmount.ForeColor = Color.LightGoldenrodYellow;
            ProductAmount.Location = new Point(27, 287);
            ProductAmount.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            ProductAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ProductAmount.Name = "ProductAmount";
            ProductAmount.Size = new Size(305, 50);
            ProductAmount.TabIndex = 4;
            ProductAmount.TextAlign = HorizontalAlignment.Center;
            ProductAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ProductDetailsShowUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(752, 428);
            Controls.Add(ProductPicture);
            Controls.Add(label1);
            Controls.Add(CancelButton);
            Controls.Add(BuyButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ProductDetailsShowUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о продукте";
            Load += ProductDetailsShowUser_Load;
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ProductName;
        private Label ProductPrice;
        private Label ProductContent;
        private Button BuyButton;
        private SaveFileDialog SaveCheck;
        private Button CancelButton;
        private Label label1;
        private PictureBox ProductPicture;
        private Panel panel1;
        private NumericUpDown ProductAmount;
    }
}