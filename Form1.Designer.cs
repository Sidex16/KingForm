namespace KingForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guideLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addToFirstColon = new Label();
            addToSecondColon = new Label();
            confirmButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // guideLabel
            // 
            guideLabel.Anchor = AnchorStyles.None;
            guideLabel.AutoSize = true;
            guideLabel.FlatStyle = FlatStyle.Flat;
            guideLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            guideLabel.ForeColor = Color.FromArgb(0, 192, 192);
            guideLabel.ImageAlign = ContentAlignment.TopCenter;
            guideLabel.Location = new Point(180, 30);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new Size(343, 25);
            guideLabel.TabIndex = 0;
            guideLabel.Text = "Додайте потрібну кількість гравців";
            guideLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 15, 15);
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Yellow;
            textBox1.Location = new Point(56, 79);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Yellow;
            textBox2.Location = new Point(473, 79);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 39);
            textBox2.TabIndex = 2;
            // 
            // addToFirstColon
            // 
            addToFirstColon.AutoSize = true;
            addToFirstColon.BackColor = Color.Transparent;
            addToFirstColon.Cursor = Cursors.Hand;
            addToFirstColon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addToFirstColon.ForeColor = Color.FromArgb(0, 192, 192);
            addToFirstColon.Location = new Point(229, 97);
            addToFirstColon.Name = "addToFirstColon";
            addToFirstColon.Size = new Size(21, 21);
            addToFirstColon.TabIndex = 9;
            addToFirstColon.Text = "+";
            addToFirstColon.Click += addToFirstColon_Click;
            // 
            // addToSecondColon
            // 
            addToSecondColon.AutoSize = true;
            addToSecondColon.BackColor = Color.Transparent;
            addToSecondColon.Cursor = Cursors.Hand;
            addToSecondColon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addToSecondColon.ForeColor = Color.FromArgb(0, 192, 192);
            addToSecondColon.Location = new Point(646, 97);
            addToSecondColon.Name = "addToSecondColon";
            addToSecondColon.Size = new Size(21, 21);
            addToSecondColon.TabIndex = 11;
            addToSecondColon.Text = "+";
            addToSecondColon.Click += addToSecondColon_Click;
            // 
            // confirmButton
            // 
            confirmButton.AutoSize = true;
            confirmButton.BackColor = Color.DimGray;
            confirmButton.BackgroundImageLayout = ImageLayout.None;
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.FlatStyle = FlatStyle.Popup;
            confirmButton.ForeColor = Color.FromArgb(0, 0, 0, 0);
            confirmButton.Location = new Point(301, 301);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(95, 27);
            confirmButton.TabIndex = 12;
            confirmButton.Text = "Завершити";
            confirmButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(230, 70);
            label1.Name = "label1";
            label1.Size = new Size(19, 25);
            label1.TabIndex = 13;
            label1.Text = "_";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(647, 70);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 14;
            label2.Text = "_";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirmButton);
            Controls.Add(addToSecondColon);
            Controls.Add(addToFirstColon);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(guideLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Begin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label guideLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label addToFirstColon;
        private Label addToSecondColon;
        private Button confirmButton;
        private Label label1;
        private Label label2;
    }
}