namespace Backery
{
    partial class ProductCardUser
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
            ProductName = new Label();
            ProductCost = new Label();
            ProductPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            SuspendLayout();
            // 
            // ProductName
            // 
            ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductName.Font = new Font("Segoe UI", 16F);
            ProductName.Location = new Point(-1, 237);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(297, 79);
            ProductName.TabIndex = 0;
            ProductName.Text = "NAMENAME";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            ProductName.Click += ProductCardUser_Click;
            // 
            // ProductCost
            // 
            ProductCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductCost.Font = new Font("Segoe UI", 24F);
            ProductCost.Location = new Point(-1, 316);
            ProductCost.Name = "ProductCost";
            ProductCost.Size = new Size(293, 51);
            ProductCost.TabIndex = 1;
            ProductCost.Text = "COSTCOSTCOST";
            ProductCost.TextAlign = ContentAlignment.TopCenter;
            ProductCost.Click += ProductCardUser_Click;
            // 
            // ProductPicture
            // 
            ProductPicture.Location = new Point(3, -1);
            ProductPicture.Name = "ProductPicture";
            ProductPicture.Size = new Size(289, 224);
            ProductPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPicture.TabIndex = 2;
            ProductPicture.TabStop = false;
            ProductPicture.Click += ProductCardUser_Click;
            // 
            // ProductCardUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ProductPicture);
            Controls.Add(ProductCost);
            Controls.Add(ProductName);
            Name = "ProductCardUser";
            Size = new Size(295, 366);
            Load += ProductCardUser_Load;
            Click += ProductCardUser_Click;
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label ProductName;
        private Label ProductCost;
        private PictureBox ProductPicture;
    }
}
