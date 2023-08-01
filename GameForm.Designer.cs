namespace KingForm
{
    partial class GameForm
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
            lblKing = new Label();
            label1 = new Label();
            confirmButton = new Button();
            button1 = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblKing
            // 
            lblKing.Anchor = AnchorStyles.None;
            lblKing.AutoSize = true;
            lblKing.FlatStyle = FlatStyle.Flat;
            lblKing.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKing.ForeColor = Color.FromArgb(0, 192, 192);
            lblKing.ImageAlign = ContentAlignment.TopCenter;
            lblKing.Location = new Point(331, 43);
            lblKing.Name = "lblKing";
            lblKing.Size = new Size(179, 25);
            lblKing.TabIndex = 1;
            lblKing.Text = "Натисніть \"Старт\"";
            lblKing.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(824, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // confirmButton
            // 
            confirmButton.AutoSize = true;
            confirmButton.BackColor = Color.DimGray;
            confirmButton.BackgroundImageLayout = ImageLayout.None;
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.FlatStyle = FlatStyle.Popup;
            confirmButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.FromArgb(0, 0, 0, 0);
            confirmButton.Location = new Point(580, 353);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(95, 27);
            confirmButton.TabIndex = 13;
            confirmButton.Text = "Старт";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.DimGray;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 0, 0);
            button1.Location = new Point(710, 353);
            button1.Name = "button1";
            button1.Size = new Size(116, 27);
            button1.TabIndex = 14;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoSize = true;
            lblInfo.FlatStyle = FlatStyle.Flat;
            lblInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.FromArgb(0, 192, 192);
            lblInfo.ImageAlign = ContentAlignment.TopCenter;
            lblInfo.Location = new Point(-2, -3);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(260, 17);
            lblInfo.TabIndex = 15;
            lblInfo.Text = "Щоб дізнатись хто король почніть гру*";
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(856, 402);
            Controls.Add(lblInfo);
            Controls.Add(button1);
            Controls.Add(confirmButton);
            Controls.Add(label1);
            Controls.Add(lblKing);
            Cursor = Cursors.Hand;
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKing;
        private Label label1;
        private Button confirmButton;
        private Button button1;
        private Label lblInfo;
    }
}