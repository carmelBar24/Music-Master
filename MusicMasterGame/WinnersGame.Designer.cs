namespace MusicMasterGame
{
    partial class WinnersGame
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
            this.components = new System.ComponentModel.Container();
            this.MusicAnswer = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.WinnersTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerGame = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayMusic = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.PictureBox();
            this.WinnersLabel = new System.Windows.Forms.PictureBox();
            this.helpWinners = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnersLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicAnswer
            // 
            this.MusicAnswer.Location = new System.Drawing.Point(174, 424);
            this.MusicAnswer.Name = "MusicAnswer";
            this.MusicAnswer.Size = new System.Drawing.Size(140, 20);
            this.MusicAnswer.TabIndex = 3;
            this.MusicAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("AR CENA", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.Location = new System.Drawing.Point(197, 484);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(90, 34);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // WinnersTimer
            // 
            this.WinnersTimer.Interval = 1000;
            this.WinnersTimer.Tick += new System.EventHandler(this.WinnersTimer_Tick);
            // 
            // TimerGame
            // 
            this.TimerGame.AutoSize = true;
            this.TimerGame.Font = new System.Drawing.Font("AR CENA", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerGame.ForeColor = System.Drawing.Color.LightYellow;
            this.TimerGame.Location = new System.Drawing.Point(354, 273);
            this.TimerGame.Name = "TimerGame";
            this.TimerGame.Size = new System.Drawing.Size(123, 32);
            this.TimerGame.TabIndex = 5;
            this.TimerGame.Text = "80 seconds";
            this.TimerGame.Click += new System.EventHandler(this.label2_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("AR CENA", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.Color.LightYellow;
            this.LevelLabel.Location = new System.Drawing.Point(24, 273);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(76, 32);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "Level 1";
            this.LevelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackgroundImage = global::MusicMasterGame.Resource1.hint_winners;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Location = new System.Drawing.Point(25, 150);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 77);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::MusicMasterGame.Resource1.x_winners;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(417, 48);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 77);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayMusic
            // 
            this.PlayMusic.BackgroundImage = global::MusicMasterGame.Resource1.play_button;
            this.PlayMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayMusic.FlatAppearance.BorderSize = 0;
            this.PlayMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PlayMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayMusic.Location = new System.Drawing.Point(205, 302);
            this.PlayMusic.Name = "PlayMusic";
            this.PlayMusic.Size = new System.Drawing.Size(82, 78);
            this.PlayMusic.TabIndex = 2;
            this.PlayMusic.UseVisualStyleBackColor = true;
            this.PlayMusic.Click += new System.EventHandler(this.PlayMusic_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameLabel.BackgroundImage = global::MusicMasterGame.Resource1.GameLogoWin;
            this.GameLabel.Location = new System.Drawing.Point(174, 122);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(282, 126);
            this.GameLabel.TabIndex = 1;
            this.GameLabel.TabStop = false;
            // 
            // WinnersLabel
            // 
            this.WinnersLabel.BackgroundImage = global::MusicMasterGame.Resource1.coollogo_com_26160799;
            this.WinnersLabel.Location = new System.Drawing.Point(25, 12);
            this.WinnersLabel.Name = "WinnersLabel";
            this.WinnersLabel.Size = new System.Drawing.Size(400, 113);
            this.WinnersLabel.TabIndex = 0;
            this.WinnersLabel.TabStop = false;
            // 
            // helpWinners
            // 
            this.helpWinners.BackgroundImage = global::MusicMasterGame.Resource1.helping;
            this.helpWinners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpWinners.FlatAppearance.BorderSize = 0;
            this.helpWinners.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpWinners.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.helpWinners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpWinners.Location = new System.Drawing.Point(392, 317);
            this.helpWinners.Name = "helpWinners";
            this.helpWinners.Size = new System.Drawing.Size(75, 63);
            this.helpWinners.TabIndex = 9;
            this.helpWinners.UseVisualStyleBackColor = true;
            this.helpWinners.Click += new System.EventHandler(this.helpWinners_Click);
            // 
            // WinnersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(490, 606);
            this.ControlBox = false;
            this.Controls.Add(this.helpWinners);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TimerGame);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.MusicAnswer);
            this.Controls.Add(this.PlayMusic);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.WinnersLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WinnersGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinnersGame";
            this.Load += new System.EventHandler(this.WinnersGame_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnersLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WinnersLabel;
        private System.Windows.Forms.PictureBox GameLabel;
        private System.Windows.Forms.Button PlayMusic;
        private System.Windows.Forms.TextBox MusicAnswer;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Timer WinnersTimer;
        private System.Windows.Forms.Label TimerGame;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Button helpWinners;
    }
}