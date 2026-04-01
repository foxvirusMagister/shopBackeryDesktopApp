namespace Backery
{
    partial class ThanksForBuyingForm
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
            GetCheck = new Button();
            CheckPreview = new TextBox();
            ExitButton = new Button();
            SaveCheck = new SaveFileDialog();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Segoe UI", 36F);
            Title.Location = new Point(113, 361);
            Title.Name = "Title";
            Title.Size = new Size(571, 70);
            Title.TabIndex = 0;
            Title.Text = "Спасибо за покупку";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GetCheck
            // 
            GetCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GetCheck.BackColor = Color.DarkGoldenrod;
            GetCheck.Font = new Font("Segoe UI", 24F);
            GetCheck.ForeColor = Color.LightGoldenrodYellow;
            GetCheck.Location = new Point(268, 287);
            GetCheck.Name = "GetCheck";
            GetCheck.Size = new Size(261, 71);
            GetCheck.TabIndex = 1;
            GetCheck.Text = "Получить чек";
            GetCheck.UseVisualStyleBackColor = false;
            GetCheck.Click += GetCheck_Click;
            // 
            // CheckPreview
            // 
            CheckPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CheckPreview.BorderStyle = BorderStyle.None;
            CheckPreview.Location = new Point(75, 143);
            CheckPreview.Multiline = true;
            CheckPreview.Name = "CheckPreview";
            CheckPreview.ReadOnly = true;
            CheckPreview.ScrollBars = ScrollBars.Both;
            CheckPreview.Size = new Size(631, 124);
            CheckPreview.TabIndex = 2;
            CheckPreview.Text = "gfhfg";
            CheckPreview.WordWrap = false;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.DarkGoldenrod;
            ExitButton.Font = new Font("Segoe UI", 24F);
            ExitButton.ForeColor = Color.LightGoldenrodYellow;
            ExitButton.Location = new Point(27, 35);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(185, 71);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveCheck
            // 
            SaveCheck.DefaultExt = "txt";
            SaveCheck.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            SaveCheck.InitialDirectory = "Рабочий стол";
            SaveCheck.Title = "Сохранить чек";
            // 
            // ThanksForBuyingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(CheckPreview);
            Controls.Add(GetCheck);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThanksForBuyingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThanksForBuyingForm";
            WindowState = FormWindowState.Maximized;
            Load += ThanksForBuyingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button GetCheck;
        private TextBox CheckPreview;
        private Button ExitButton;
        private SaveFileDialog SaveCheck;
    }
}