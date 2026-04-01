namespace Backery
{
    partial class CartForm
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
            TotalPriceLabel = new Label();
            Title = new Label();
            BackButton = new Button();
            ProductsPanel = new TableLayoutPanel();
            BuyButton = new Button();
            SuspendLayout();
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TotalPriceLabel.Font = new Font("Segoe UI", 36F);
            TotalPriceLabel.Location = new Point(226, 18);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(350, 65);
            TotalPriceLabel.TabIndex = 0;
            TotalPriceLabel.Text = "Итоговая цена";
            TotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Segoe UI", 32F);
            Title.Location = new Point(307, 95);
            Title.Name = "Title";
            Title.Size = new Size(191, 59);
            Title.TabIndex = 1;
            Title.Text = "Корзина";
            Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.DarkGoldenrod;
            BackButton.Font = new Font("Segoe UI", 26F);
            BackButton.ForeColor = Color.LightGoldenrodYellow;
            BackButton.Location = new Point(36, 35);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(150, 60);
            BackButton.TabIndex = 2;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ProductsPanel
            // 
            ProductsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductsPanel.AutoScroll = true;
            ProductsPanel.BackColor = Color.DarkGoldenrod;
            ProductsPanel.ColumnCount = 4;
            ProductsPanel.ColumnStyles.Add(new ColumnStyle());
            ProductsPanel.ColumnStyles.Add(new ColumnStyle());
            ProductsPanel.ColumnStyles.Add(new ColumnStyle());
            ProductsPanel.ColumnStyles.Add(new ColumnStyle());
            ProductsPanel.Location = new Point(21, 187);
            ProductsPanel.Name = "ProductsPanel";
            ProductsPanel.RowCount = 1;
            ProductsPanel.RowStyles.Add(new RowStyle());
            ProductsPanel.Size = new Size(758, 178);
            ProductsPanel.TabIndex = 3;
            // 
            // BuyButton
            // 
            BuyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuyButton.BackColor = Color.DarkGoldenrod;
            BuyButton.Font = new Font("Segoe UI", 26F);
            BuyButton.ForeColor = Color.LightGoldenrodYellow;
            BuyButton.Location = new Point(320, 378);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(150, 60);
            BuyButton.TabIndex = 4;
            BuyButton.Text = "Купить";
            BuyButton.UseVisualStyleBackColor = false;
            BuyButton.Click += BuyButton_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(BuyButton);
            Controls.Add(ProductsPanel);
            Controls.Add(BackButton);
            Controls.Add(Title);
            Controls.Add(TotalPriceLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartForm";
            WindowState = FormWindowState.Maximized;
            FormClosed += CartForm_FormClosed;
            Load += CartForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label TotalPriceLabel;
        private Label Title;
        private Button BackButton;
        private TableLayoutPanel ProductsPanel;
        private Button BuyButton;
    }
}