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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            guideLabel = new Label();
            textBox2 = new TextBox();
            confirmButton = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            btnOpenTask = new Button();
            btnOpenJudgement = new Button();
            cbxNumberOfPlayers = new ComboBox();
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
            guideLabel.Location = new Point(281, 36);
            guideLabel.Name = "guideLabel";
            guideLabel.Size = new Size(221, 25);
            guideLabel.TabIndex = 0;
            guideLabel.Text = "Введіть число гравців:";
            guideLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(15, 15, 15);
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.PaleTurquoise;
            textBox2.Location = new Point(542, 88);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 39);
            textBox2.TabIndex = 2;
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
            confirmButton.Location = new Point(368, 350);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(95, 27);
            confirmButton.TabIndex = 12;
            confirmButton.Text = "Завершити";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(15, 15, 15);
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.PaleTurquoise;
            textBox1.Location = new Point(87, 88);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 39);
            textBox1.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(15, 15, 15);
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.PaleTurquoise;
            textBox3.Location = new Point(87, 150);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 39);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(15, 15, 15);
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.PaleTurquoise;
            textBox4.Location = new Point(542, 150);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 39);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(15, 15, 15);
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.PaleTurquoise;
            textBox5.Location = new Point(87, 212);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 39);
            textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(15, 15, 15);
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.PaleTurquoise;
            textBox6.Location = new Point(542, 212);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(189, 39);
            textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(15, 15, 15);
            textBox7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.PaleTurquoise;
            textBox7.Location = new Point(87, 274);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(189, 39);
            textBox7.TabIndex = 33;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(15, 15, 15);
            textBox8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.ForeColor = Color.PaleTurquoise;
            textBox8.Location = new Point(542, 274);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(189, 39);
            textBox8.TabIndex = 28;
            // 
            // btnOpenTask
            // 
            btnOpenTask.AutoSize = true;
            btnOpenTask.BackColor = Color.DimGray;
            btnOpenTask.BackgroundImageLayout = ImageLayout.None;
            btnOpenTask.Cursor = Cursors.Hand;
            btnOpenTask.FlatStyle = FlatStyle.Popup;
            btnOpenTask.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenTask.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnOpenTask.Location = new Point(636, 350);
            btnOpenTask.Name = "btnOpenTask";
            btnOpenTask.Size = new Size(95, 27);
            btnOpenTask.TabIndex = 37;
            btnOpenTask.Text = "Завдання";
            btnOpenTask.UseVisualStyleBackColor = false;
            btnOpenTask.Click += btnOpenTask_Click;
            // 
            // btnOpenJudgement
            // 
            btnOpenJudgement.AutoSize = true;
            btnOpenJudgement.BackColor = Color.DimGray;
            btnOpenJudgement.BackgroundImageLayout = ImageLayout.None;
            btnOpenJudgement.Cursor = Cursors.Hand;
            btnOpenJudgement.FlatStyle = FlatStyle.Popup;
            btnOpenJudgement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenJudgement.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnOpenJudgement.Location = new Point(749, 350);
            btnOpenJudgement.Name = "btnOpenJudgement";
            btnOpenJudgement.Size = new Size(95, 27);
            btnOpenJudgement.TabIndex = 38;
            btnOpenJudgement.Text = "Покарання";
            btnOpenJudgement.UseVisualStyleBackColor = false;
            btnOpenJudgement.Click += btnOpenJudgement_Click;
            // 
            // cbxNumberOfPlayers
            // 
            cbxNumberOfPlayers.BackColor = Color.FromArgb(25, 25, 25);
            cbxNumberOfPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNumberOfPlayers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxNumberOfPlayers.ForeColor = Color.FromArgb(0, 192, 192);
            cbxNumberOfPlayers.FormattingEnabled = true;
            cbxNumberOfPlayers.Location = new Point(503, 36);
            cbxNumberOfPlayers.Name = "cbxNumberOfPlayers";
            cbxNumberOfPlayers.Size = new Size(37, 25);
            cbxNumberOfPlayers.TabIndex = 39;
            cbxNumberOfPlayers.SelectedIndexChanged += cbxNumberOfPlayers_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(856, 402);
            Controls.Add(cbxNumberOfPlayers);
            Controls.Add(btnOpenJudgement);
            Controls.Add(btnOpenTask);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(confirmButton);
            Controls.Add(textBox2);
            Controls.Add(guideLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Begin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label guideLabel;
        private TextBox textBox2;
        private Button confirmButton;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button btnOpenTask;
        private Button btnOpenJudgement;
        private ComboBox cbxNumberOfPlayers;
    }
}