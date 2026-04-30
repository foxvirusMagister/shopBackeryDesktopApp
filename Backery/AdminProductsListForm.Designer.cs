namespace Backery
{
    partial class AdminProductsListForm
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
            PageSelector = new NumericUpDown();
            CatsCount = new ComboBox();
            AddButton = new Button();
            Title = new Label();
            ProductPanel = new TableLayoutPanel();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PageSelector).BeginInit();
            SuspendLayout();
            // 
            // PageSelector
            // 
            PageSelector.Anchor = AnchorStyles.Bottom;
            PageSelector.BackColor = Color.DarkGoldenrod;
            PageSelector.Font = new Font("Segoe UI", 24F);
            PageSelector.ForeColor = Color.LightGoldenrodYellow;
            PageSelector.Location = new Point(387, 375);
            PageSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PageSelector.Name = "PageSelector";
            PageSelector.Size = new Size(71, 50);
            PageSelector.TabIndex = 17;
            PageSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CatsCount
            // 
            CatsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CatsCount.BackColor = Color.DarkGoldenrod;
            CatsCount.Font = new Font("Segoe UI", 22F);
            CatsCount.ForeColor = Color.LightGoldenrodYellow;
            CatsCount.FormattingEnabled = true;
            CatsCount.Items.AddRange(new object[] { "1", "3", "6", "10", "15", "25", "45" });
            CatsCount.Location = new Point(28, 378);
            CatsCount.Name = "CatsCount";
            CatsCount.Size = new Size(171, 48);
            CatsCount.TabIndex = 16;
            CatsCount.Text = "25";
            CatsCount.SelectedIndexChanged += CatsCount_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.DarkGoldenrod;
            AddButton.Font = new Font("Segoe UI", 24F);
            AddButton.ForeColor = Color.LightGoldenrodYellow;
            AddButton.Location = new Point(617, 25);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(171, 58);
            AddButton.TabIndex = 15;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 32F);
            Title.Location = new Point(178, 40);
            Title.Name = "Title";
            Title.Size = new Size(389, 59);
            Title.TabIndex = 12;
            Title.Text = "Выберите продукт";
            // 
            // ProductPanel
            // 
            ProductPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductPanel.AutoScroll = true;
            ProductPanel.BackColor = Color.DarkGoldenrod;
            ProductPanel.ColumnCount = 4;
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.Location = new Point(28, 102);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.RowCount = 1;
            ProductPanel.RowStyles.Add(new RowStyle());
            ProductPanel.Size = new Size(745, 240);
            ProductPanel.TabIndex = 14;
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.BackColor = Color.DarkGoldenrod;
            BackButton.Font = new Font("Segoe UI", 24F);
            BackButton.ForeColor = Color.LightGoldenrodYellow;
            BackButton.Location = new Point(12, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(119, 58);
            BackButton.TabIndex = 13;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AdminProductsListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(PageSelector);
            Controls.Add(CatsCount);
            Controls.Add(AddButton);
            Controls.Add(Title);
            Controls.Add(ProductPanel);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProductsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProductsListForm";
            WindowState = FormWindowState.Maximized;
            Load += AdminProductsListForm_Load;
            ((System.ComponentModel.ISupportInitialize)PageSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown PageSelector;
        private ComboBox CatsCount;
        private Button AddButton;
        private Label Title;
        private TableLayoutPanel ProductPanel;
        private Button BackButton;
    }
}