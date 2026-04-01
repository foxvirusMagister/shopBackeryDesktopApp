namespace Backery
{
    partial class SelectProductUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProductUserForm));
            PageSelector = new NumericUpDown();
            CatsCount = new ComboBox();
            Title = new Label();
            BackButton = new Button();
            ProductPanel = new TableLayoutPanel();
            CartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PageSelector).BeginInit();
            SuspendLayout();
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
            PageSelector.TabIndex = 9;
            PageSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PageSelector.ValueChanged += PageSelector_ValueChanged;
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
            CatsCount.TabIndex = 8;
            CatsCount.Text = "10";
            CatsCount.SelectedIndexChanged += CatsCount_SelectedIndexChanged;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 42F);
            Title.Location = new Point(194, 32);
            Title.Name = "Title";
            Title.Size = new Size(445, 74);
            Title.TabIndex = 6;
            Title.Text = "Выберите товар";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkGoldenrod;
            BackButton.Font = new Font("Segoe UI", 24F);
            BackButton.ForeColor = Color.LightGoldenrodYellow;
            BackButton.Location = new Point(21, 32);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(151, 60);
            BackButton.TabIndex = 5;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ProductPanel
            // 
            ProductPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ProductPanel.AutoScroll = true;
            ProductPanel.BackColor = Color.DarkGoldenrod;
            ProductPanel.ColumnCount = 4;
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.ColumnStyles.Add(new ColumnStyle());
            ProductPanel.Location = new Point(21, 121);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.RowCount = 1;
            ProductPanel.RowStyles.Add(new RowStyle());
            ProductPanel.Size = new Size(745, 240);
            ProductPanel.TabIndex = 7;
            // 
            // CartButton
            // 
            CartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CartButton.BackColor = Color.DarkGoldenrod;
            CartButton.Font = new Font("Segoe UI", 22F);
            CartButton.ForeColor = Color.LightGoldenrodYellow;
            CartButton.Location = new Point(637, 32);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(151, 60);
            CartButton.TabIndex = 10;
            CartButton.Text = "Корзина";
            CartButton.UseVisualStyleBackColor = false;
            CartButton.Click += CartButton_Click;
            // 
            // SelectProductUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(CartButton);
            Controls.Add(PageSelector);
            Controls.Add(CatsCount);
            Controls.Add(Title);
            Controls.Add(BackButton);
            Controls.Add(ProductPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectProductUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбери продукт";
            WindowState = FormWindowState.Maximized;
            Load += SelectProductUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)PageSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown PageSelector;
        private ComboBox CatsCount;
        private Label Title;
        private Button BackButton;
        private TableLayoutPanel ProductPanel;
        private Button CartButton;
    }
}