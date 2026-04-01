namespace Backery
{
    partial class AdminProductCategoriesForm
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
            BackButton = new Button();
            CategoryPanel = new TableLayoutPanel();
            Title = new Label();
            AddButton = new Button();
            CatsCount = new ComboBox();
            PageSelector = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PageSelector).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.BackColor = Color.DarkGoldenrod;
            BackButton.Font = new Font("Segoe UI", 24F);
            BackButton.ForeColor = Color.LightGoldenrodYellow;
            BackButton.Location = new Point(12, 28);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(119, 58);
            BackButton.TabIndex = 7;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CategoryPanel
            // 
            CategoryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryPanel.AutoScroll = true;
            CategoryPanel.BackColor = Color.DarkGoldenrod;
            CategoryPanel.ColumnCount = 3;
            CategoryPanel.ColumnStyles.Add(new ColumnStyle());
            CategoryPanel.ColumnStyles.Add(new ColumnStyle());
            CategoryPanel.ColumnStyles.Add(new ColumnStyle());
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            CategoryPanel.Location = new Point(28, 105);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.RowCount = 1;
            CategoryPanel.RowStyles.Add(new RowStyle());
            CategoryPanel.Size = new Size(745, 240);
            CategoryPanel.TabIndex = 8;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 32F);
            Title.Location = new Point(178, 43);
            Title.Name = "Title";
            Title.Size = new Size(439, 59);
            Title.TabIndex = 7;
            Title.Text = "Выберите категорию";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.DarkGoldenrod;
            AddButton.Font = new Font("Segoe UI", 24F);
            AddButton.ForeColor = Color.LightGoldenrodYellow;
            AddButton.Location = new Point(617, 28);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(171, 58);
            AddButton.TabIndex = 9;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // CatsCount
            // 
            CatsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CatsCount.BackColor = Color.DarkGoldenrod;
            CatsCount.Font = new Font("Segoe UI", 22F);
            CatsCount.ForeColor = Color.LightGoldenrodYellow;
            CatsCount.FormattingEnabled = true;
            CatsCount.Items.AddRange(new object[] { "1", "3", "6", "10", "15", "25", "45" });
            CatsCount.Location = new Point(28, 381);
            CatsCount.Name = "CatsCount";
            CatsCount.Size = new Size(171, 48);
            CatsCount.TabIndex = 10;
            CatsCount.Text = "25";
            CatsCount.SelectedIndexChanged += AdminProductCategoriesForm_Load;
            // 
            // PageSelector
            // 
            PageSelector.Anchor = AnchorStyles.Bottom;
            PageSelector.BackColor = Color.DarkGoldenrod;
            PageSelector.Font = new Font("Segoe UI", 24F);
            PageSelector.ForeColor = Color.LightGoldenrodYellow;
            PageSelector.Location = new Point(387, 378);
            PageSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PageSelector.Name = "PageSelector";
            PageSelector.Size = new Size(71, 50);
            PageSelector.TabIndex = 11;
            PageSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PageSelector.ValueChanged += AdminProductCategoriesForm_Load;
            // 
            // AdminProductCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(PageSelector);
            Controls.Add(CatsCount);
            Controls.Add(AddButton);
            Controls.Add(Title);
            Controls.Add(CategoryPanel);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProductCategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProductCategoriesForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminProductCategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)PageSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private TableLayoutPanel CategoryPanel;
        private Label Title;
        private Button AddButton;
        private ComboBox CatsCount;
        private NumericUpDown PageSelector;
    }
}