namespace Backery
{
    partial class AdminProductCard
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
            ProductPicture = new PictureBox();
            ProductCost = new Label();
            ProductName = new Label();
            EditButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductPicture).BeginInit();
            SuspendLayout();
            // 
            // ProductPicture
            // 
            ProductPicture.Location = new Point(3, 3);
            ProductPicture.Name = "ProductPicture";
            ProductPicture.Size = new Size(289, 166);
            ProductPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductPicture.TabIndex = 5;
            ProductPicture.TabStop = false;
            // 
            // ProductCost
            // 
            ProductCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductCost.Font = new Font("Segoe UI", 24F);
            ProductCost.Location = new Point(0, 212);
            ProductCost.Name = "ProductCost";
            ProductCost.Size = new Size(293, 51);
            ProductCost.TabIndex = 4;
            ProductCost.Text = "COSTCOSTCOST";
            ProductCost.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProductName
            // 
            ProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductName.Font = new Font("Segoe UI", 16F);
            ProductName.Location = new Point(3, 172);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(297, 40);
            ProductName.TabIndex = 3;
            ProductName.Text = "NAMENAME";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.DarkGoldenrod;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Segoe UI", 22F);
            EditButton.ForeColor = Color.LightGoldenrodYellow;
            EditButton.Location = new Point(3, 266);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(289, 46);
            EditButton.TabIndex = 6;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkGoldenrod;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 22F);
            DeleteButton.ForeColor = Color.LightGoldenrodYellow;
            DeleteButton.Location = new Point(4, 317);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(289, 46);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AdminProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(ProductPicture);
            Controls.Add(ProductCost);
            Controls.Add(ProductName);
            Name = "AdminProductCard";
            Size = new Size(295, 366);
            Load += AdminProductCard_Load;
            Click += AdminProductCard_Click;
            ((System.ComponentModel.ISupportInitialize)ProductPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ProductPicture;
        private Label ProductCost;
        private Label ProductName;
        private Button EditButton;
        private Button DeleteButton;
    }
}
