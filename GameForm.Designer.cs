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
            btnNewKing = new Button();
            lblInfo = new Label();
            gbxPlayers = new GroupBox();
            lblPlayer8 = new Label();
            lblPlayer7 = new Label();
            lblPlayer6 = new Label();
            lblPlayer5 = new Label();
            lblPlayer4 = new Label();
            lblPlayer3 = new Label();
            lblPlayer2 = new Label();
            lblPlayer1 = new Label();
            pbxUpdate = new PictureBox();
            gbxPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUpdate).BeginInit();
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
            lblKing.Location = new Point(342, 43);
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
            // btnNewKing
            // 
            btnNewKing.AutoSize = true;
            btnNewKing.BackColor = Color.DimGray;
            btnNewKing.BackgroundImageLayout = ImageLayout.None;
            btnNewKing.Cursor = Cursors.Hand;
            btnNewKing.FlatStyle = FlatStyle.Popup;
            btnNewKing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewKing.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnNewKing.Location = new Point(710, 353);
            btnNewKing.Name = "btnNewKing";
            btnNewKing.Size = new Size(116, 27);
            btnNewKing.TabIndex = 14;
            btnNewKing.Text = "Новий король";
            btnNewKing.UseVisualStyleBackColor = false;
            btnNewKing.Click += btnNewKing_Click;
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
            // gbxPlayers
            // 
            gbxPlayers.Controls.Add(lblPlayer8);
            gbxPlayers.Controls.Add(lblPlayer7);
            gbxPlayers.Controls.Add(lblPlayer6);
            gbxPlayers.Controls.Add(lblPlayer5);
            gbxPlayers.Controls.Add(lblPlayer4);
            gbxPlayers.Controls.Add(lblPlayer3);
            gbxPlayers.Controls.Add(lblPlayer2);
            gbxPlayers.Controls.Add(lblPlayer1);
            gbxPlayers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbxPlayers.ForeColor = Color.FromArgb(0, 192, 192);
            gbxPlayers.Location = new Point(186, 92);
            gbxPlayers.Name = "gbxPlayers";
            gbxPlayers.Size = new Size(489, 209);
            gbxPlayers.TabIndex = 16;
            gbxPlayers.TabStop = false;
            gbxPlayers.Text = "Гравці:";
            // 
            // lblPlayer8
            // 
            lblPlayer8.Anchor = AnchorStyles.None;
            lblPlayer8.AutoSize = true;
            lblPlayer8.FlatStyle = FlatStyle.Flat;
            lblPlayer8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer8.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer8.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer8.Location = new Point(6, 176);
            lblPlayer8.Name = "lblPlayer8";
            lblPlayer8.Size = new Size(20, 17);
            lblPlayer8.TabIndex = 25;
            lblPlayer8.Text = "...";
            lblPlayer8.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer7
            // 
            lblPlayer7.Anchor = AnchorStyles.None;
            lblPlayer7.AutoSize = true;
            lblPlayer7.FlatStyle = FlatStyle.Flat;
            lblPlayer7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer7.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer7.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer7.Location = new Point(6, 155);
            lblPlayer7.Name = "lblPlayer7";
            lblPlayer7.Size = new Size(20, 17);
            lblPlayer7.TabIndex = 24;
            lblPlayer7.Text = "...";
            lblPlayer7.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer6
            // 
            lblPlayer6.Anchor = AnchorStyles.None;
            lblPlayer6.AutoSize = true;
            lblPlayer6.FlatStyle = FlatStyle.Flat;
            lblPlayer6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer6.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer6.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer6.Location = new Point(6, 134);
            lblPlayer6.Name = "lblPlayer6";
            lblPlayer6.Size = new Size(20, 17);
            lblPlayer6.TabIndex = 23;
            lblPlayer6.Text = "...";
            lblPlayer6.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer5
            // 
            lblPlayer5.Anchor = AnchorStyles.None;
            lblPlayer5.AutoSize = true;
            lblPlayer5.FlatStyle = FlatStyle.Flat;
            lblPlayer5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer5.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer5.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer5.Location = new Point(6, 113);
            lblPlayer5.Name = "lblPlayer5";
            lblPlayer5.Size = new Size(20, 17);
            lblPlayer5.TabIndex = 22;
            lblPlayer5.Text = "...";
            lblPlayer5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer4
            // 
            lblPlayer4.Anchor = AnchorStyles.None;
            lblPlayer4.AutoSize = true;
            lblPlayer4.FlatStyle = FlatStyle.Flat;
            lblPlayer4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer4.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer4.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer4.Location = new Point(6, 92);
            lblPlayer4.Name = "lblPlayer4";
            lblPlayer4.Size = new Size(20, 17);
            lblPlayer4.TabIndex = 21;
            lblPlayer4.Text = "...";
            lblPlayer4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer3
            // 
            lblPlayer3.Anchor = AnchorStyles.None;
            lblPlayer3.AutoSize = true;
            lblPlayer3.FlatStyle = FlatStyle.Flat;
            lblPlayer3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer3.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer3.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer3.Location = new Point(6, 71);
            lblPlayer3.Name = "lblPlayer3";
            lblPlayer3.Size = new Size(20, 17);
            lblPlayer3.TabIndex = 20;
            lblPlayer3.Text = "...";
            lblPlayer3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer2
            // 
            lblPlayer2.Anchor = AnchorStyles.None;
            lblPlayer2.AutoSize = true;
            lblPlayer2.FlatStyle = FlatStyle.Flat;
            lblPlayer2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer2.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer2.Location = new Point(6, 50);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(20, 17);
            lblPlayer2.TabIndex = 19;
            lblPlayer2.Text = "...";
            lblPlayer2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer1
            // 
            lblPlayer1.Anchor = AnchorStyles.None;
            lblPlayer1.AutoSize = true;
            lblPlayer1.FlatStyle = FlatStyle.Flat;
            lblPlayer1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer1.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer1.Location = new Point(6, 29);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(20, 17);
            lblPlayer1.TabIndex = 18;
            lblPlayer1.Text = "...";
            lblPlayer1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbxUpdate
            // 
            pbxUpdate.Image = Resource1._303_3037570_eyequeue_white_eye_icon_transparent;
            pbxUpdate.Location = new Point(677, 89);
            pbxUpdate.Name = "pbxUpdate";
            pbxUpdate.Size = new Size(40, 23);
            pbxUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUpdate.TabIndex = 17;
            pbxUpdate.TabStop = false;
            pbxUpdate.Click += pbxUpdate_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(856, 402);
            Controls.Add(pbxUpdate);
            Controls.Add(gbxPlayers);
            Controls.Add(lblInfo);
            Controls.Add(btnNewKing);
            Controls.Add(confirmButton);
            Controls.Add(label1);
            Controls.Add(lblKing);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            gbxPlayers.ResumeLayout(false);
            gbxPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKing;
        private Label label1;
        private Button confirmButton;
        private Button btnNewKing;
        private Label lblInfo;
        private GroupBox gbxPlayers;
        private PictureBox pbxUpdate;
        private Label lblPlayer8;
        private Label lblPlayer7;
        private Label lblPlayer6;
        private Label lblPlayer5;
        private Label lblPlayer4;
        private Label lblPlayer3;
        private Label lblPlayer2;
        private Label lblPlayer1;
    }
}