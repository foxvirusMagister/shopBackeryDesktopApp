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
            SuspendLayout();
            // 
            // CategoryName
            // 
            CategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryName.Font = new Font("Segoe UI", 22F);
            CategoryName.Location = new Point(-1, 0);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(394, 216);
            CategoryName.TabIndex = 0;
            CategoryName.Text = "ИмяИМЯИмя";
            CategoryName.TextAlign = ContentAlignment.MiddleCenter;
            CategoryName.Click += CategoryCard_Click;
            // 
            // CategoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(CategoryName);
            Name = "CategoryCard";
            Size = new Size(392, 216);
            Load += CategoryCard_Load;
            Click += CategoryCard_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label CategoryName;
    }
}
