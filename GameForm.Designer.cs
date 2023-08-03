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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            lblKing = new Label();
            btnConfirm = new Button();
            lblInfo = new Label();
            gbxPlayers = new GroupBox();
            lblNumber8 = new Label();
            lblNumber7 = new Label();
            lblNumber6 = new Label();
            lblNumber5 = new Label();
            lblNumber4 = new Label();
            lblNumber3 = new Label();
            lblNumber2 = new Label();
            lblNumber1 = new Label();
            lblPlayer8 = new Label();
            lblPlayer7 = new Label();
            lblPlayer6 = new Label();
            lblPlayer5 = new Label();
            lblPlayer4 = new Label();
            lblPlayer3 = new Label();
            lblPlayer2 = new Label();
            lblPlayer1 = new Label();
            pbxPlay = new PictureBox();
            pbxShow = new PictureBox();
            pbxReroll = new PictureBox();
            pbxJudgement = new PictureBox();
            pbxTask = new PictureBox();
            lblJudgement = new Label();
            lblTask = new Label();
            gbxPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxReroll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxJudgement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTask).BeginInit();
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
            lblKing.Location = new Point(405, 57);
            lblKing.Name = "lblKing";
            lblKing.Size = new Size(211, 31);
            lblKing.TabIndex = 1;
            lblKing.Text = "Натисніть \"Старт\"";
            lblKing.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.AutoSize = true;
            btnConfirm.BackColor = Color.DimGray;
            btnConfirm.BackgroundImageLayout = ImageLayout.None;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.FromArgb(0, 0, 0, 0);
            btnConfirm.Location = new Point(427, 467);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(109, 36);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Старт";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoSize = true;
            lblInfo.FlatStyle = FlatStyle.Flat;
            lblInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.FromArgb(0, 192, 192);
            lblInfo.ImageAlign = ContentAlignment.TopCenter;
            lblInfo.Location = new Point(-2, -4);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(339, 23);
            lblInfo.TabIndex = 15;
            lblInfo.Text = "Щоб дізнатись хто король почніть гру*";
            lblInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbxPlayers
            // 
            gbxPlayers.Controls.Add(lblNumber8);
            gbxPlayers.Controls.Add(lblNumber7);
            gbxPlayers.Controls.Add(lblNumber6);
            gbxPlayers.Controls.Add(lblNumber5);
            gbxPlayers.Controls.Add(lblNumber4);
            gbxPlayers.Controls.Add(lblNumber3);
            gbxPlayers.Controls.Add(lblNumber2);
            gbxPlayers.Controls.Add(lblNumber1);
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
            gbxPlayers.Location = new Point(213, 123);
            gbxPlayers.Margin = new Padding(3, 4, 3, 4);
            gbxPlayers.Name = "gbxPlayers";
            gbxPlayers.Padding = new Padding(3, 4, 3, 4);
            gbxPlayers.Size = new Size(559, 279);
            gbxPlayers.TabIndex = 16;
            gbxPlayers.TabStop = false;
            gbxPlayers.Text = "Гравці:";
            // 
            // lblNumber8
            // 
            lblNumber8.Anchor = AnchorStyles.None;
            lblNumber8.AutoSize = true;
            lblNumber8.FlatStyle = FlatStyle.Flat;
            lblNumber8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber8.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber8.ImageAlign = ContentAlignment.TopCenter;
            lblNumber8.Location = new Point(514, 235);
            lblNumber8.Name = "lblNumber8";
            lblNumber8.Size = new Size(25, 23);
            lblNumber8.TabIndex = 33;
            lblNumber8.Text = "...";
            lblNumber8.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber7
            // 
            lblNumber7.Anchor = AnchorStyles.None;
            lblNumber7.AutoSize = true;
            lblNumber7.FlatStyle = FlatStyle.Flat;
            lblNumber7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber7.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber7.ImageAlign = ContentAlignment.TopCenter;
            lblNumber7.Location = new Point(514, 207);
            lblNumber7.Name = "lblNumber7";
            lblNumber7.Size = new Size(25, 23);
            lblNumber7.TabIndex = 32;
            lblNumber7.Text = "...";
            lblNumber7.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber6
            // 
            lblNumber6.Anchor = AnchorStyles.None;
            lblNumber6.AutoSize = true;
            lblNumber6.FlatStyle = FlatStyle.Flat;
            lblNumber6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber6.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber6.ImageAlign = ContentAlignment.TopCenter;
            lblNumber6.Location = new Point(514, 179);
            lblNumber6.Name = "lblNumber6";
            lblNumber6.Size = new Size(25, 23);
            lblNumber6.TabIndex = 31;
            lblNumber6.Text = "...";
            lblNumber6.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber5
            // 
            lblNumber5.Anchor = AnchorStyles.None;
            lblNumber5.AutoSize = true;
            lblNumber5.FlatStyle = FlatStyle.Flat;
            lblNumber5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber5.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber5.ImageAlign = ContentAlignment.TopCenter;
            lblNumber5.Location = new Point(514, 151);
            lblNumber5.Name = "lblNumber5";
            lblNumber5.Size = new Size(25, 23);
            lblNumber5.TabIndex = 30;
            lblNumber5.Text = "...";
            lblNumber5.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber4
            // 
            lblNumber4.Anchor = AnchorStyles.None;
            lblNumber4.AutoSize = true;
            lblNumber4.FlatStyle = FlatStyle.Flat;
            lblNumber4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber4.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber4.ImageAlign = ContentAlignment.TopCenter;
            lblNumber4.Location = new Point(514, 123);
            lblNumber4.Name = "lblNumber4";
            lblNumber4.Size = new Size(25, 23);
            lblNumber4.TabIndex = 29;
            lblNumber4.Text = "...";
            lblNumber4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber3
            // 
            lblNumber3.Anchor = AnchorStyles.None;
            lblNumber3.AutoSize = true;
            lblNumber3.FlatStyle = FlatStyle.Flat;
            lblNumber3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber3.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber3.ImageAlign = ContentAlignment.TopCenter;
            lblNumber3.Location = new Point(514, 95);
            lblNumber3.Name = "lblNumber3";
            lblNumber3.Size = new Size(25, 23);
            lblNumber3.TabIndex = 28;
            lblNumber3.Text = "...";
            lblNumber3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber2
            // 
            lblNumber2.Anchor = AnchorStyles.None;
            lblNumber2.AutoSize = true;
            lblNumber2.FlatStyle = FlatStyle.Flat;
            lblNumber2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber2.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber2.ImageAlign = ContentAlignment.TopCenter;
            lblNumber2.Location = new Point(514, 67);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(25, 23);
            lblNumber2.TabIndex = 27;
            lblNumber2.Text = "...";
            lblNumber2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumber1
            // 
            lblNumber1.Anchor = AnchorStyles.None;
            lblNumber1.AutoSize = true;
            lblNumber1.FlatStyle = FlatStyle.Flat;
            lblNumber1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber1.ForeColor = Color.FromArgb(0, 192, 192);
            lblNumber1.ImageAlign = ContentAlignment.TopCenter;
            lblNumber1.Location = new Point(514, 39);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(25, 23);
            lblNumber1.TabIndex = 26;
            lblNumber1.Text = "...";
            lblNumber1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPlayer8
            // 
            lblPlayer8.Anchor = AnchorStyles.None;
            lblPlayer8.AutoSize = true;
            lblPlayer8.FlatStyle = FlatStyle.Flat;
            lblPlayer8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer8.ForeColor = Color.FromArgb(0, 192, 192);
            lblPlayer8.ImageAlign = ContentAlignment.TopCenter;
            lblPlayer8.Location = new Point(19, 235);
            lblPlayer8.Name = "lblPlayer8";
            lblPlayer8.Size = new Size(25, 23);
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
            lblPlayer7.Location = new Point(19, 207);
            lblPlayer7.Name = "lblPlayer7";
            lblPlayer7.Size = new Size(25, 23);
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
            lblPlayer6.Location = new Point(19, 179);
            lblPlayer6.Name = "lblPlayer6";
            lblPlayer6.Size = new Size(25, 23);
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
            lblPlayer5.Location = new Point(19, 151);
            lblPlayer5.Name = "lblPlayer5";
            lblPlayer5.Size = new Size(25, 23);
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
            lblPlayer4.Location = new Point(19, 123);
            lblPlayer4.Name = "lblPlayer4";
            lblPlayer4.Size = new Size(25, 23);
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
            lblPlayer3.Location = new Point(19, 95);
            lblPlayer3.Name = "lblPlayer3";
            lblPlayer3.Size = new Size(25, 23);
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
            lblPlayer2.Location = new Point(19, 67);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(25, 23);
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
            lblPlayer1.Location = new Point(19, 39);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(25, 23);
            lblPlayer1.TabIndex = 18;
            lblPlayer1.Text = "...";
            lblPlayer1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pbxPlay
            // 
            pbxPlay.Cursor = Cursors.Hand;
            pbxPlay.Image = Resource1._211876_play_icon;
            pbxPlay.Location = new Point(778, 352);
            pbxPlay.Margin = new Padding(3, 4, 3, 4);
            pbxPlay.Name = "pbxPlay";
            pbxPlay.Size = new Size(58, 49);
            pbxPlay.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPlay.TabIndex = 19;
            pbxPlay.TabStop = false;
            pbxPlay.Click += pbxPlay_Click;
            // 
            // pbxShow
            // 
            pbxShow.Cursor = Cursors.Hand;
            pbxShow.Image = Resource1._211661_eye_icon;
            pbxShow.Location = new Point(778, 291);
            pbxShow.Margin = new Padding(3, 4, 3, 4);
            pbxShow.Name = "pbxShow";
            pbxShow.Size = new Size(58, 53);
            pbxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pbxShow.TabIndex = 17;
            pbxShow.TabStop = false;
            pbxShow.Click += pbxShow_Click;
            // 
            // pbxReroll
            // 
            pbxReroll.Cursor = Cursors.Hand;
            pbxReroll.Image = Resource1._7106354_reload_data_infographic_update_element_icon;
            pbxReroll.Location = new Point(778, 236);
            pbxReroll.Margin = new Padding(3, 4, 3, 4);
            pbxReroll.Name = "pbxReroll";
            pbxReroll.Size = new Size(58, 47);
            pbxReroll.SizeMode = PictureBoxSizeMode.Zoom;
            pbxReroll.TabIndex = 18;
            pbxReroll.TabStop = false;
            pbxReroll.Click += pbxReroll_Click;
            // 
            // pbxJudgement
            // 
            pbxJudgement.Cursor = Cursors.Hand;
            pbxJudgement.Image = Resource1._339870_capitol_death_hanging_punishment_sentence_icon;
            pbxJudgement.Location = new Point(914, 16);
            pbxJudgement.Margin = new Padding(3, 4, 3, 4);
            pbxJudgement.Name = "pbxJudgement";
            pbxJudgement.Size = new Size(50, 53);
            pbxJudgement.SizeMode = PictureBoxSizeMode.Zoom;
            pbxJudgement.TabIndex = 20;
            pbxJudgement.TabStop = false;
            pbxJudgement.Click += pbxJudgement_Click;
            // 
            // pbxTask
            // 
            pbxTask.Cursor = Cursors.Hand;
            pbxTask.Image = Resource1._8686963_ic_fluent_clipboard_task_list_icon;
            pbxTask.Location = new Point(914, 77);
            pbxTask.Margin = new Padding(3, 4, 3, 4);
            pbxTask.Name = "pbxTask";
            pbxTask.Size = new Size(50, 53);
            pbxTask.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTask.TabIndex = 21;
            pbxTask.TabStop = false;
            pbxTask.Click += pbxTask_Click;
            // 
            // lblJudgement
            // 
            lblJudgement.Anchor = AnchorStyles.None;
            lblJudgement.AutoSize = true;
            lblJudgement.FlatStyle = FlatStyle.Flat;
            lblJudgement.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblJudgement.ForeColor = Color.FromArgb(0, 192, 192);
            lblJudgement.ImageAlign = ContentAlignment.TopCenter;
            lblJudgement.Location = new Point(69, 469);
            lblJudgement.Name = "lblJudgement";
            lblJudgement.Size = new Size(269, 32);
            lblJudgement.TabIndex = 22;
            lblJudgement.Text = "Натисніть \"Старт\"";
            lblJudgement.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTask
            // 
            lblTask.Anchor = AnchorStyles.None;
            lblTask.AutoSize = true;
            lblTask.FlatStyle = FlatStyle.Flat;
            lblTask.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTask.ForeColor = Color.FromArgb(0, 192, 192);
            lblTask.ImageAlign = ContentAlignment.TopCenter;
            lblTask.Location = new Point(69, 436);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(269, 32);
            lblTask.TabIndex = 23;
            lblTask.Text = "Натисніть \"Старт\"";
            lblTask.TextAlign = ContentAlignment.TopCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25);
            ClientSize = new Size(978, 536);
            Controls.Add(lblTask);
            Controls.Add(lblJudgement);
            Controls.Add(pbxTask);
            Controls.Add(pbxJudgement);
            Controls.Add(pbxPlay);
            Controls.Add(pbxReroll);
            Controls.Add(pbxShow);
            Controls.Add(gbxPlayers);
            Controls.Add(lblInfo);
            Controls.Add(btnConfirm);
            Controls.Add(lblKing);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            gbxPlayers.ResumeLayout(false);
            gbxPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxReroll).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxJudgement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKing;
        private Button btnConfirm;
        private Label lblInfo;
        private GroupBox gbxPlayers;
        private PictureBox pbxShow;
        private Label lblPlayer8;
        private Label lblPlayer7;
        private Label lblPlayer6;
        private Label lblPlayer5;
        private Label lblPlayer4;
        private Label lblPlayer3;
        private Label lblPlayer2;
        private Label lblPlayer1;
        private Label lblNumber8;
        private Label lblNumber7;
        private Label lblNumber6;
        private Label lblNumber5;
        private Label lblNumber4;
        private Label lblNumber3;
        private Label lblNumber2;
        private Label lblNumber1;
        private PictureBox pbxReroll;
        private PictureBox pbxPlay;
        private PictureBox pbxJudgement;
        private PictureBox pbxTask;
        private Label lblJudgement;
        private Label lblTask;
    }
}