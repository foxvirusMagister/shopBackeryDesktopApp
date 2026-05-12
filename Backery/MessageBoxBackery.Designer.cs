namespace Backery
{
    partial class MessageBoxBackery
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
            OkButton = new Button();
            BackGround = new Panel();
            TextField = new TextBox();
            BackGround.SuspendLayout();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.DarkGoldenrod;
            OkButton.Cursor = Cursors.Hand;
            OkButton.Font = new Font("Segoe UI", 24F);
            OkButton.ForeColor = Color.LightGoldenrodYellow;
            OkButton.Location = new Point(296, 324);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(193, 93);
            OkButton.TabIndex = 2;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // BackGround
            // 
            BackGround.BackColor = Color.Wheat;
            BackGround.Controls.Add(OkButton);
            BackGround.Controls.Add(TextField);
            BackGround.Location = new Point(2, 2);
            BackGround.Name = "BackGround";
            BackGround.Size = new Size(797, 447);
            BackGround.TabIndex = 3;
            // 
            // TextField
            // 
            TextField.BackColor = Color.DarkGoldenrod;
            TextField.BorderStyle = BorderStyle.None;
            TextField.Font = new Font("Segoe UI", 22F);
            TextField.ForeColor = Color.LightGoldenrodYellow;
            TextField.Location = new Point(37, 32);
            TextField.Multiline = true;
            TextField.Name = "TextField";
            TextField.ReadOnly = true;
            TextField.Size = new Size(723, 253);
            TextField.TabIndex = 4;
            TextField.Text = "textTextTextText";
            TextField.TextAlign = HorizontalAlignment.Center;
            // 
            // MessageBoxBackery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(BackGround);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxBackery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxBackery";
            Load += MessageBoxBackery_Load;
            BackGround.ResumeLayout(false);
            BackGround.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OkButton;
        private Panel BackGround;
        private TextBox TextField;
    }
}