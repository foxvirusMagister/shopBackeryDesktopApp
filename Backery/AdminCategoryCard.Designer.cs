namespace Backery
{
    partial class AdminCategoryCard
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
            DeleteButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // CategoryName
            // 
            CategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryName.Font = new Font("Segoe UI", 22F);
            CategoryName.Location = new Point(-1, 0);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(390, 71);
            CategoryName.TabIndex = 1;
            CategoryName.Text = "ИмяИМЯИмя";
            CategoryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkGoldenrod;
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Segoe UI", 22F);
            DeleteButton.ForeColor = Color.LightGoldenrodYellow;
            DeleteButton.Location = new Point(3, 144);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(386, 69);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGoldenrod;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 22F);
            button1.ForeColor = Color.LightGoldenrodYellow;
            button1.Location = new Point(3, 74);
            button1.Name = "button1";
            button1.Size = new Size(386, 69);
            button1.TabIndex = 3;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminCategoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(button1);
            Controls.Add(DeleteButton);
            Controls.Add(CategoryName);
            Margin = new Padding(20, 3, 15, 3);
            Name = "AdminCategoryCard";
            Size = new Size(392, 216);
            Load += AdminCategoryCard_Load;
            Click += AdminCategoryCard_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label CategoryName;
        private Button DeleteButton;
        private Button button1;
    }
}
