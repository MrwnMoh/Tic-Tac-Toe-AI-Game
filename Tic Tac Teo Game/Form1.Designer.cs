namespace Tic_Tac_Teo_Game
{
    partial class frmGame
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
            this.TpGameName = new System.Windows.Forms.Label();
            this.TpPlayerName = new System.Windows.Forms.Label();
            this.Btn2I1 = new System.Windows.Forms.Button();
            this.Btn2I2 = new System.Windows.Forms.Button();
            this.Btn2I0 = new System.Windows.Forms.Button();
            this.Btn1I1 = new System.Windows.Forms.Button();
            this.Btn1I2 = new System.Windows.Forms.Button();
            this.Btn1I0 = new System.Windows.Forms.Button();
            this.Btn0I1 = new System.Windows.Forms.Button();
            this.Btn0I2 = new System.Windows.Forms.Button();
            this.Btn0I0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TpWinnerName = new System.Windows.Forms.Label();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.TpTurnMark = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TpInfo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TpGameName
            // 
            this.TpGameName.AutoSize = true;
            this.TpGameName.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpGameName.ForeColor = System.Drawing.Color.Black;
            this.TpGameName.Location = new System.Drawing.Point(669, 41);
            this.TpGameName.Name = "TpGameName";
            this.TpGameName.Size = new System.Drawing.Size(419, 90);
            this.TpGameName.TabIndex = 9;
            this.TpGameName.Text = "Tic Tac Toe";
            // 
            // TpPlayerName
            // 
            this.TpPlayerName.AutoSize = true;
            this.TpPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpPlayerName.ForeColor = System.Drawing.Color.Black;
            this.TpPlayerName.Location = new System.Drawing.Point(73, 224);
            this.TpPlayerName.Name = "TpPlayerName";
            this.TpPlayerName.Size = new System.Drawing.Size(149, 45);
            this.TpPlayerName.TabIndex = 10;
            this.TpPlayerName.Tag = "P1";
            this.TpPlayerName.Text = "Player 1";
            // 
            // Btn2I1
            // 
            this.Btn2I1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn2I1.FlatAppearance.BorderSize = 0;
            this.Btn2I1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2I1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2I1.Location = new System.Drawing.Point(812, 534);
            this.Btn2I1.Name = "Btn2I1";
            this.Btn2I1.Size = new System.Drawing.Size(117, 125);
            this.Btn2I1.TabIndex = 8;
            this.Btn2I1.Tag = "2I1";
            this.Btn2I1.Text = "?";
            this.Btn2I1.UseVisualStyleBackColor = true;
            this.Btn2I1.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn2I2
            // 
            this.Btn2I2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn2I2.FlatAppearance.BorderSize = 0;
            this.Btn2I2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2I2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2I2.Location = new System.Drawing.Point(1044, 534);
            this.Btn2I2.Name = "Btn2I2";
            this.Btn2I2.Size = new System.Drawing.Size(117, 125);
            this.Btn2I2.TabIndex = 7;
            this.Btn2I2.Tag = "2I2";
            this.Btn2I2.Text = "?";
            this.Btn2I2.UseVisualStyleBackColor = true;
            this.Btn2I2.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn2I0
            // 
            this.Btn2I0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn2I0.FlatAppearance.BorderSize = 0;
            this.Btn2I0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2I0.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2I0.Location = new System.Drawing.Point(580, 534);
            this.Btn2I0.Name = "Btn2I0";
            this.Btn2I0.Size = new System.Drawing.Size(117, 125);
            this.Btn2I0.TabIndex = 6;
            this.Btn2I0.Tag = "2I0";
            this.Btn2I0.Text = "?";
            this.Btn2I0.UseVisualStyleBackColor = true;
            this.Btn2I0.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn1I1
            // 
            this.Btn1I1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn1I1.FlatAppearance.BorderSize = 0;
            this.Btn1I1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1I1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1I1.Location = new System.Drawing.Point(812, 343);
            this.Btn1I1.Name = "Btn1I1";
            this.Btn1I1.Size = new System.Drawing.Size(117, 125);
            this.Btn1I1.TabIndex = 5;
            this.Btn1I1.Tag = "1I1";
            this.Btn1I1.Text = "?";
            this.Btn1I1.UseVisualStyleBackColor = true;
            this.Btn1I1.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn1I2
            // 
            this.Btn1I2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn1I2.FlatAppearance.BorderSize = 0;
            this.Btn1I2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1I2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1I2.Location = new System.Drawing.Point(1044, 346);
            this.Btn1I2.Name = "Btn1I2";
            this.Btn1I2.Size = new System.Drawing.Size(117, 125);
            this.Btn1I2.TabIndex = 4;
            this.Btn1I2.Tag = "1I2";
            this.Btn1I2.Text = "?";
            this.Btn1I2.UseVisualStyleBackColor = true;
            this.Btn1I2.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn1I0
            // 
            this.Btn1I0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn1I0.FlatAppearance.BorderSize = 0;
            this.Btn1I0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1I0.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1I0.Location = new System.Drawing.Point(580, 343);
            this.Btn1I0.Name = "Btn1I0";
            this.Btn1I0.Size = new System.Drawing.Size(117, 125);
            this.Btn1I0.TabIndex = 3;
            this.Btn1I0.Tag = "1I0";
            this.Btn1I0.Text = "?";
            this.Btn1I0.UseVisualStyleBackColor = true;
            this.Btn1I0.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn0I1
            // 
            this.Btn0I1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn0I1.FlatAppearance.BorderSize = 0;
            this.Btn0I1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0I1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0I1.Location = new System.Drawing.Point(812, 158);
            this.Btn0I1.Name = "Btn0I1";
            this.Btn0I1.Size = new System.Drawing.Size(117, 125);
            this.Btn0I1.TabIndex = 2;
            this.Btn0I1.Tag = "0I1";
            this.Btn0I1.Text = "?";
            this.Btn0I1.UseVisualStyleBackColor = true;
            this.Btn0I1.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn0I2
            // 
            this.Btn0I2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn0I2.FlatAppearance.BorderSize = 0;
            this.Btn0I2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0I2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0I2.Location = new System.Drawing.Point(1044, 158);
            this.Btn0I2.Name = "Btn0I2";
            this.Btn0I2.Size = new System.Drawing.Size(117, 125);
            this.Btn0I2.TabIndex = 1;
            this.Btn0I2.Tag = "0I2";
            this.Btn0I2.Text = "?";
            this.Btn0I2.UseVisualStyleBackColor = true;
            this.Btn0I2.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // Btn0I0
            // 
            this.Btn0I0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn0I0.FlatAppearance.BorderSize = 0;
            this.Btn0I0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0I0.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0I0.Location = new System.Drawing.Point(580, 158);
            this.Btn0I0.Name = "Btn0I0";
            this.Btn0I0.Size = new System.Drawing.Size(117, 125);
            this.Btn0I0.TabIndex = 0;
            this.Btn0I0.Tag = "0I0";
            this.Btn0I0.Text = "?";
            this.Btn0I0.UseVisualStyleBackColor = true;
            this.Btn0I0.Click += new System.EventHandler(this.On_Player_Clieck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 90);
            this.label1.TabIndex = 11;
            this.label1.Tag = "P1";
            this.label1.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 90);
            this.label2.TabIndex = 12;
            this.label2.Tag = "P1";
            this.label2.Text = "Winner";
            // 
            // TpWinnerName
            // 
            this.TpWinnerName.AutoSize = true;
            this.TpWinnerName.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpWinnerName.ForeColor = System.Drawing.Color.Black;
            this.TpWinnerName.Location = new System.Drawing.Point(73, 359);
            this.TpWinnerName.Name = "TpWinnerName";
            this.TpWinnerName.Size = new System.Drawing.Size(199, 45);
            this.TpWinnerName.TabIndex = 13;
            this.TpWinnerName.Tag = "P1";
            this.TpWinnerName.Text = "In Progress";
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.Color.OldLace;
            this.BtnRestart.FlatAppearance.BorderSize = 0;
            this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestart.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestart.Location = new System.Drawing.Point(61, 534);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(256, 85);
            this.BtnRestart.TabIndex = 14;
            this.BtnRestart.Text = "Restart Game";
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.Restart_Game);
            // 
            // TpTurnMark
            // 
            this.TpTurnMark.AutoSize = true;
            this.TpTurnMark.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpTurnMark.ForeColor = System.Drawing.Color.Black;
            this.TpTurnMark.Location = new System.Drawing.Point(274, 224);
            this.TpTurnMark.Name = "TpTurnMark";
            this.TpTurnMark.Size = new System.Drawing.Size(43, 45);
            this.TpTurnMark.TabIndex = 15;
            this.TpTurnMark.Tag = "P1";
            this.TpTurnMark.Text = "X";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 85);
            this.button1.TabIndex = 16;
            this.button1.Text = "Play Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Play_Game);
            // 
            // TpInfo
            // 
            this.TpInfo.AutoSize = true;
            this.TpInfo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TpInfo.Location = new System.Drawing.Point(12, 9);
            this.TpInfo.Name = "TpInfo";
            this.TpInfo.Size = new System.Drawing.Size(154, 38);
            this.TpInfo.TabIndex = 17;
            this.TpInfo.Tag = "P1";
            this.TpInfo.Text = "Level Test";
            this.TpInfo.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Tic_Tac_Teo_Game.Properties.Resources.Line_12;
            this.pictureBox3.Location = new System.Drawing.Point(634, -67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(469, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tic_Tac_Teo_Game.Properties.Resources._94059_angle_plane_paper_art_airplane_line;
            this.pictureBox2.Location = new System.Drawing.Point(-38, 590);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Teo_Game.Properties.Resources.Designer_Studio_effects_vid1__10_1;
            this.pictureBox1.Location = new System.Drawing.Point(192, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1279, 729);
            this.Controls.Add(this.TpInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TpTurnMark);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.TpWinnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TpPlayerName);
            this.Controls.Add(this.Btn2I1);
            this.Controls.Add(this.Btn2I2);
            this.Controls.Add(this.Btn2I0);
            this.Controls.Add(this.Btn1I1);
            this.Controls.Add(this.Btn1I2);
            this.Controls.Add(this.Btn1I0);
            this.Controls.Add(this.Btn0I1);
            this.Controls.Add(this.Btn0I2);
            this.Controls.Add(this.Btn0I0);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TpGameName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmGame";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn0I0;
        private System.Windows.Forms.Button Btn0I2;
        private System.Windows.Forms.Button Btn0I1;
        private System.Windows.Forms.Button Btn1I1;
        private System.Windows.Forms.Button Btn1I2;
        private System.Windows.Forms.Button Btn1I0;
        private System.Windows.Forms.Button Btn2I1;
        private System.Windows.Forms.Button Btn2I2;
        private System.Windows.Forms.Button Btn2I0;
        private System.Windows.Forms.Label TpGameName;
        private System.Windows.Forms.Label TpPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TpWinnerName;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Label TpTurnMark;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TpInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

