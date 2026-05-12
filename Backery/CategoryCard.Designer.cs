namespace Backery
{
    partial class CategoryCard
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
            CategoryName = new Label();
            CategoryImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CategoryImage).BeginInit();
            SuspendLayout();
            // 
            // CategoryName
            // 
            CategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryName.Font = new Font("Segoe UI", 22F);
            CategoryName.Location = new Point(-1, 229);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(346, 45);
            CategoryName.TabIndex = 0;
            CategoryName.Text = "ИмяИМЯИмя";
            CategoryName.TextAlign = ContentAlignment.MiddleCenter;
            CategoryName.Click += CategoryCard_Click;
            // 
            // CategoryImage
            // 
            CategoryImage.Image = Properties.Resources.iconApp;
            CategoryImage.Location = new Point(0, 0);
            CategoryImage.Name = "CategoryImage";
            CategoryImage.Size = new Size(345, 226);
            CategoryImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CategoryImage.TabIndex = 1;
            CategoryImage.TabStop = false;
            CategoryImage.Click += CategoryCard_Click;
            // 
            // CategoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(CategoryImage);
            Controls.Add(CategoryName);
            Name = "CategoryCard";
            Size = new Size(344, 273);
            Load += CategoryCard_Load;
            Click += CategoryCard_Click;
            ((System.ComponentModel.ISupportInitialize)CategoryImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label CategoryName;
        private PictureBox CategoryImage;
    }
}
