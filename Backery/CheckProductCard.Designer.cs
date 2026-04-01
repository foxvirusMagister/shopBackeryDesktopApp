namespace Backery
{
    partial class CheckProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ProductImage = new PictureBox();
            ProductName = new Label();
            ProductPrice = new Label();
            ProductCount = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // ProductImage
            // 
            ProductImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductImage.BackColor = Color.Wheat;
            ProductImage.Location = new Point(3, 47);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(289, 209);
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductImage.TabIndex = 0;
            ProductImage.TabStop = false;
            ProductImage.Click += ProductImage_Click;
            // 
            // ProductName
            // 
            ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductName.Font = new Font("Segoe UI", 12F);
            ProductName.Location = new Point(3, 259);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(289, 53);
            ProductName.TabIndex = 1;
            ProductName.Text = "Название";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            ProductName.Click += ProductImage_Click;
            // 
            // ProductPrice
            // 
            ProductPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPrice.Font = new Font("Segoe UI", 24F);
            ProductPrice.Location = new Point(3, 312);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(289, 54);
            ProductPrice.TabIndex = 2;
            ProductPrice.Text = "Цена";
            ProductPrice.TextAlign = ContentAlignment.TopCenter;
            ProductPrice.Click += ProductImage_Click;
            // 
            // ProductCount
            // 
            ProductCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductCount.Font = new Font("Segoe UI", 24F);
            ProductCount.Location = new Point(0, 0);
            ProductCount.Name = "ProductCount";
            ProductCount.Size = new Size(289, 44);
            ProductCount.TabIndex = 3;
            ProductCount.Text = "Количество";
            ProductCount.TextAlign = ContentAlignment.TopCenter;
            ProductCount.Click += ProductImage_Click;
            // 
            // CheckProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(ProductCount);
            Controls.Add(ProductPrice);
            Controls.Add(ProductName);
            Controls.Add(ProductImage);
            Name = "CheckProductCard";
            Size = new Size(295, 366);
            Load += CheckProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ProductImage;
        private Label ProductName;
        private Label ProductPrice;
        private Label ProductCount;
    }
}
