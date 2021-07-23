namespace MusicMasterGame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.firstOption = new System.Windows.Forms.Button();
            this.ThirdOption = new System.Windows.Forms.Button();
            this.FourOption = new System.Windows.Forms.Button();
            this.SecondOption = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.GamePoints = new System.Windows.Forms.Label();
            this.Help50 = new System.Windows.Forms.Button();
            this.HintHelp = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextLevelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstOption
            // 
            this.firstOption.BackColor = System.Drawing.Color.White;
            this.firstOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstOption.FlatAppearance.BorderSize = 0;
            this.firstOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.firstOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.firstOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstOption.Font = new System.Drawing.Font("Kristen ITC", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstOption.Location = new System.Drawing.Point(75, 210);
            this.firstOption.Name = "firstOption";
            this.firstOption.Size = new System.Drawing.Size(170, 77);
            this.firstOption.TabIndex = 4;
            this.firstOption.UseVisualStyleBackColor = false;
            this.firstOption.Click += new System.EventHandler(this.FirstOption_Click);
            // 
            // ThirdOption
            // 
            this.ThirdOption.BackColor = System.Drawing.Color.White;
            this.ThirdOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThirdOption.FlatAppearance.BorderSize = 0;
            this.ThirdOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ThirdOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ThirdOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdOption.Font = new System.Drawing.Font("Kristen ITC", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdOption.Location = new System.Drawing.Point(340, 256);
            this.ThirdOption.Name = "ThirdOption";
            this.ThirdOption.Size = new System.Drawing.Size(170, 77);
            this.ThirdOption.TabIndex = 5;
            this.ThirdOption.UseVisualStyleBackColor = false;
            this.ThirdOption.Click += new System.EventHandler(this.ThirdOption_Click);
            // 
            // FourOption
            // 
            this.FourOption.BackColor = System.Drawing.Color.White;
            this.FourOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourOption.FlatAppearance.BorderSize = 0;
            this.FourOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FourOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FourOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourOption.Font = new System.Drawing.Font("Kristen ITC", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourOption.Location = new System.Drawing.Point(167, 361);
            this.FourOption.Name = "FourOption";
            this.FourOption.Size = new System.Drawing.Size(170, 77);
            this.FourOption.TabIndex = 6;
            this.FourOption.UseVisualStyleBackColor = false;
            this.FourOption.Click += new System.EventHandler(this.FourOption_Click);
            // 
            // SecondOption
            // 
            this.SecondOption.BackColor = System.Drawing.Color.White;
            this.SecondOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondOption.FlatAppearance.BorderSize = 0;
            this.SecondOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SecondOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SecondOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondOption.Font = new System.Drawing.Font("Kristen ITC", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondOption.Location = new System.Drawing.Point(535, 345);
            this.SecondOption.Name = "SecondOption";
            this.SecondOption.Size = new System.Drawing.Size(170, 77);
            this.SecondOption.TabIndex = 7;
            this.SecondOption.UseVisualStyleBackColor = false;
            this.SecondOption.Click += new System.EventHandler(this.SecondOption_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.AutoSize = true;
            this.GameTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameTimer.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTimer.ForeColor = System.Drawing.Color.White;
            this.GameTimer.Location = new System.Drawing.Point(408, 24);
            this.GameTimer.Name = "GameTimer";
            this.GameTimer.Size = new System.Drawing.Size(180, 40);
            this.GameTimer.TabIndex = 9;
            this.GameTimer.Text = "60 seconds";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("AR CENA", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(588, 127);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(212, 49);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "חזרה לעמוד הקודם";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TimerGame
            // 
            this.TimerGame.Interval = 1000;
            this.TimerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // GamePoints
            // 
            this.GamePoints.AutoSize = true;
            this.GamePoints.BackColor = System.Drawing.Color.Black;
            this.GamePoints.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePoints.ForeColor = System.Drawing.Color.White;
            this.GamePoints.Location = new System.Drawing.Point(408, 73);
            this.GamePoints.Name = "GamePoints";
            this.GamePoints.Size = new System.Drawing.Size(138, 40);
            this.GamePoints.TabIndex = 11;
            this.GamePoints.Text = "0 points";
            // 
            // Help50
            // 
            this.Help50.BackgroundImage = global::MusicMasterGame.Resource1._50_50;
            this.Help50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help50.FlatAppearance.BorderSize = 0;
            this.Help50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Help50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Help50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help50.Location = new System.Drawing.Point(697, 24);
            this.Help50.Name = "Help50";
            this.Help50.Size = new System.Drawing.Size(103, 97);
            this.Help50.TabIndex = 12;
            this.Help50.UseVisualStyleBackColor = true;
            this.Help50.Click += new System.EventHandler(this.Help50_Click);
            // 
            // HintHelp
            // 
            this.HintHelp.BackColor = System.Drawing.Color.Black;
            this.HintHelp.BackgroundImage = global::MusicMasterGame.Resource1.lightball;
            this.HintHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HintHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HintHelp.FlatAppearance.BorderSize = 0;
            this.HintHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.HintHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.HintHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HintHelp.Location = new System.Drawing.Point(594, 20);
            this.HintHelp.Name = "HintHelp";
            this.HintHelp.Size = new System.Drawing.Size(97, 106);
            this.HintHelp.TabIndex = 8;
            this.HintHelp.UseVisualStyleBackColor = false;
            this.HintHelp.Click += new System.EventHandler(this.HintHelp_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.BackColor = System.Drawing.Color.Black;
            this.GameLabel.Image = global::MusicMasterGame.Resource1.LogoPlay;
            this.GameLabel.Location = new System.Drawing.Point(0, 0);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(362, 170);
            this.GameLabel.TabIndex = 2;
            this.GameLabel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::MusicMasterGame.Resource1.LogoPlay;
            this.label1.Location = new System.Drawing.Point(337, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MusicMasterGame.Resource1.beats;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(828, 694);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NextLevelButton
            // 
            this.NextLevelButton.BackColor = System.Drawing.Color.Black;
            this.NextLevelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextLevelButton.BackgroundImage")));
            this.NextLevelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextLevelButton.FlatAppearance.BorderSize = 0;
            this.NextLevelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.NextLevelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.NextLevelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextLevelButton.Location = new System.Drawing.Point(697, 186);
            this.NextLevelButton.Name = "NextLevelButton";
            this.NextLevelButton.Size = new System.Drawing.Size(93, 82);
            this.NextLevelButton.TabIndex = 13;
            this.NextLevelButton.UseVisualStyleBackColor = false;
            this.NextLevelButton.Visible = false;
            this.NextLevelButton.Click += new System.EventHandler(this.NextLevelButton_Click_1);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 534);
            this.ControlBox = false;
            this.Controls.Add(this.NextLevelButton);
            this.Controls.Add(this.Help50);
            this.Controls.Add(this.GamePoints);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GameTimer);
            this.Controls.Add(this.HintHelp);
            this.Controls.Add(this.SecondOption);
            this.Controls.Add(this.FourOption);
            this.Controls.Add(this.ThirdOption);
            this.Controls.Add(this.firstOption);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GameLabel;
        private System.Windows.Forms.Button firstOption;
        private System.Windows.Forms.Button ThirdOption;
        private System.Windows.Forms.Button FourOption;
        private System.Windows.Forms.Button SecondOption;
        private System.Windows.Forms.Button HintHelp;
        private System.Windows.Forms.Label GameTimer;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.Label GamePoints;
        private System.Windows.Forms.Button Help50;
        private System.Windows.Forms.Button NextLevelButton;
    }
}