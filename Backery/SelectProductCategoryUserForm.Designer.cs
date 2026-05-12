namespace Backery
{
    partial class SelectProductCategoryUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProductCategoryUserForm));
            BackButton = new Button();
            Title = new Label();
            CategoryPanel = new TableLayoutPanel();
            CatsCount = new ComboBox();
            PageSelector = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PageSelector).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkGoldenrod;
            BackButton.Font = new Font("Segoe UI", 24F);
            BackButton.ForeColor = Color.LightGoldenrodYellow;
            BackButton.Location = new Point(21, 32);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(151, 60);
            BackButton.TabIndex = 0;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 42F);
            Title.Location = new Point(194, 32);
            Title.Name = "Title";
            Title.Size = new Size(572, 74);
            Title.TabIndex = 1;
            Title.Text = "Выберите категорию";
            // 
            // CategoryPanel
            // 
            CategoryPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CategoryPanel.AutoScroll = true;
            CategoryPanel.BackColor = Color.DarkGoldenrod;
            CategoryPanel.ColumnCount = 4;
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            CategoryPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            CategoryPanel.Location = new Point(21, 121);
            CategoryPanel.Name = "CategoryPanel";
            CategoryPanel.RowCount = 2;
            CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CategoryPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CategoryPanel.Size = new Size(745, 240);
            CategoryPanel.TabIndex = 2;
            // 
            // CatsCount
            // 
            CatsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CatsCount.BackColor = Color.DarkGoldenrod;
            CatsCount.Font = new Font("Segoe UI", 22F);
            CatsCount.ForeColor = Color.LightGoldenrodYellow;
            CatsCount.FormattingEnabled = true;
            CatsCount.Items.AddRange(new object[] { "1", "3", "6", "10", "15", "25", "45" });
            CatsCount.Location = new Point(21, 390);
            CatsCount.Name = "CatsCount";
            CatsCount.Size = new Size(171, 48);
            CatsCount.TabIndex = 3;
            CatsCount.Text = "10";
            CatsCount.SelectedIndexChanged += CatsCount_SelectedIndexChanged;
            // 
            // PageSelector
            // 
            PageSelector.Anchor = AnchorStyles.Bottom;
            PageSelector.BackColor = Color.DarkGoldenrod;
            PageSelector.Font = new Font("Segoe UI", 24F);
            PageSelector.ForeColor = Color.LightGoldenrodYellow;
            PageSelector.Location = new Point(375, 390);
            PageSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PageSelector.Name = "PageSelector";
            PageSelector.Size = new Size(71, 50);
            PageSelector.TabIndex = 4;
            PageSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PageSelector.ValueChanged += PageSelector_ValueChanged;
            // 
            // SelectProductCategoryUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(PageSelector);
            Controls.Add(CatsCount);
            Controls.Add(Title);
            Controls.Add(BackButton);
            Controls.Add(CategoryPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectProductCategoryUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбор категории продукта";
            WindowState = FormWindowState.Maximized;
            Load += SelectProductCategoryUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)PageSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label Title;
        private TableLayoutPanel CategoryPanel;
        private ComboBox CatsCount;
        private NumericUpDown PageSelector;
    }
}