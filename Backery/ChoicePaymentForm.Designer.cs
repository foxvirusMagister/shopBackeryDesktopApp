namespace Backery
{
    partial class ChoicePaymentForm
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
            Title = new Label();
            TotalPrice = new Label();
            PhisicalButton = new Button();
            CardButton = new Button();
            QrButton = new Button();
            CuponeButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Segoe UI", 28F);
            Title.Location = new Point(316, 22);
            Title.Name = "Title";
            Title.Size = new Size(180, 60);
            Title.TabIndex = 0;
            Title.Text = "Оплата";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalPrice
            // 
            TotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TotalPrice.Font = new Font("Segoe UI", 28F);
            TotalPrice.Location = new Point(250, 107);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(318, 60);
            TotalPrice.TabIndex = 1;
            TotalPrice.Text = "Итоговая цена";
            TotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhisicalButton
            // 
            PhisicalButton.Anchor = AnchorStyles.Left;
            PhisicalButton.BackColor = Color.DarkGoldenrod;
            PhisicalButton.Font = new Font("Segoe UI", 28F);
            PhisicalButton.ForeColor = Color.LightGoldenrodYellow;
            PhisicalButton.Location = new Point(33, 190);
            PhisicalButton.Name = "PhisicalButton";
            PhisicalButton.Size = new Size(289, 88);
            PhisicalButton.TabIndex = 2;
            PhisicalButton.Text = "Наличными";
            PhisicalButton.UseVisualStyleBackColor = false;
            PhisicalButton.Click += CardButton_Click;
            // 
            // CardButton
            // 
            CardButton.Anchor = AnchorStyles.Left;
            CardButton.BackColor = Color.DarkGoldenrod;
            CardButton.Font = new Font("Segoe UI", 28F);
            CardButton.ForeColor = Color.LightGoldenrodYellow;
            CardButton.Location = new Point(33, 315);
            CardButton.Name = "CardButton";
            CardButton.Size = new Size(289, 88);
            CardButton.TabIndex = 3;
            CardButton.Text = "Картой";
            CardButton.UseVisualStyleBackColor = false;
            CardButton.Click += CardButton_Click;
            // 
            // QrButton
            // 
            QrButton.Anchor = AnchorStyles.Right;
            QrButton.BackColor = Color.DarkGoldenrod;
            QrButton.Font = new Font("Segoe UI", 28F);
            QrButton.ForeColor = Color.LightGoldenrodYellow;
            QrButton.Location = new Point(471, 190);
            QrButton.Name = "QrButton";
            QrButton.Size = new Size(285, 88);
            QrButton.TabIndex = 4;
            QrButton.Text = "Qr-Кодом";
            QrButton.UseVisualStyleBackColor = false;
            QrButton.Click += CardButton_Click;
            // 
            // CuponeButton
            // 
            CuponeButton.Anchor = AnchorStyles.Right;
            CuponeButton.BackColor = Color.DarkGoldenrod;
            CuponeButton.Font = new Font("Segoe UI", 28F);
            CuponeButton.ForeColor = Color.LightGoldenrodYellow;
            CuponeButton.Location = new Point(471, 315);
            CuponeButton.Name = "CuponeButton";
            CuponeButton.Size = new Size(285, 88);
            CuponeButton.TabIndex = 5;
            CuponeButton.Text = "Купоном";
            CuponeButton.UseVisualStyleBackColor = false;
            CuponeButton.Click += CardButton_Click;
            // 
            // ChoicePaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(CuponeButton);
            Controls.Add(QrButton);
            Controls.Add(CardButton);
            Controls.Add(PhisicalButton);
            Controls.Add(TotalPrice);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChoicePaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChoicePaymentForm";
            WindowState = FormWindowState.Maximized;
            FormClosed += ChoicePaymentForm_FormClosed;
            Load += ChoicePaymentForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Label TotalPrice;
        private Button PhisicalButton;
        private Button CardButton;
        private Button QrButton;
        private Button CuponeButton;
    }
}