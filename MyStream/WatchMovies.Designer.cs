namespace MyStream
{
    partial class WatchMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchMovies));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_display_movie = new System.Windows.Forms.Panel();
            this.buttonBeckToMain = new System.Windows.Forms.Button();
            this.labelRelease = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelheadline = new System.Windows.Forms.Label();
            this.buttonLeaveOpinion = new System.Windows.Forms.Button();
            this.buttonRateMe = new System.Windows.Forms.Button();
            this.buttonViewopinion = new System.Windows.Forms.Button();
            this.labelGanre = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClosePlayer = new System.Windows.Forms.Button();
            this.player_fast = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonAddToFav = new System.Windows.Forms.Button();
            this.panel_display_movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_fast)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2007, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 669);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MyStream.Properties.Resources.AAAABXRSEaLCgZ5HZ_BKX3Z3goNtosUM5ketFwiXPHrDo0iloQZX_dqX_ZahPfTmRo9FbZzj4_x_UyXnFF4JJD_iZXxEhjMiLFdVsyw5;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(27, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 174);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_display_movie
            // 
            this.panel_display_movie.BackColor = System.Drawing.Color.Black;
            this.panel_display_movie.Controls.Add(this.button1);
            this.panel_display_movie.Location = new System.Drawing.Point(-2, -4);
            this.panel_display_movie.Name = "panel_display_movie";
            this.panel_display_movie.Size = new System.Drawing.Size(1568, 1003);
            this.panel_display_movie.TabIndex = 1;
            // 
            // buttonBeckToMain
            // 
            this.buttonBeckToMain.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBeckToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBeckToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBeckToMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBeckToMain.Location = new System.Drawing.Point(1760, 932);
            this.buttonBeckToMain.Name = "buttonBeckToMain";
            this.buttonBeckToMain.Size = new System.Drawing.Size(145, 55);
            this.buttonBeckToMain.TabIndex = 2;
            this.buttonBeckToMain.Text = "Back";
            this.buttonBeckToMain.UseVisualStyleBackColor = false;
            this.buttonBeckToMain.Click += new System.EventHandler(this.buttonBeckToMain_Click_1);
            // 
            // labelRelease
            // 
            this.labelRelease.BackColor = System.Drawing.Color.Transparent;
            this.labelRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRelease.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRelease.Location = new System.Drawing.Point(1563, 135);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(339, 56);
            this.labelRelease.TabIndex = 5;
            this.labelRelease.Text = "Release date:";
            this.labelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDirector
            // 
            this.labelDirector.BackColor = System.Drawing.Color.Transparent;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDirector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDirector.Location = new System.Drawing.Point(1569, 213);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(333, 56);
            this.labelDirector.TabIndex = 6;
            this.labelDirector.Text = "Director(s):";
            this.labelDirector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDescription.Location = new System.Drawing.Point(1566, 458);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(336, 230);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description:";
            // 
            // labelheadline
            // 
            this.labelheadline.AutoSize = true;
            this.labelheadline.BackColor = System.Drawing.Color.Transparent;
            this.labelheadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelheadline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelheadline.Location = new System.Drawing.Point(1599, -4);
            this.labelheadline.Name = "labelheadline";
            this.labelheadline.Size = new System.Drawing.Size(270, 82);
            this.labelheadline.TabIndex = 8;
            this.labelheadline.Text = "Movies";
            this.labelheadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLeaveOpinion
            // 
            this.buttonLeaveOpinion.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLeaveOpinion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaveOpinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLeaveOpinion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLeaveOpinion.Location = new System.Drawing.Point(1572, 810);
            this.buttonLeaveOpinion.Name = "buttonLeaveOpinion";
            this.buttonLeaveOpinion.Size = new System.Drawing.Size(333, 55);
            this.buttonLeaveOpinion.TabIndex = 9;
            this.buttonLeaveOpinion.Text = "Leave an opinion";
            this.buttonLeaveOpinion.UseVisualStyleBackColor = false;
            // 
            // buttonRateMe
            // 
            this.buttonRateMe.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRateMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRateMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRateMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRateMe.Location = new System.Drawing.Point(1572, 871);
            this.buttonRateMe.Name = "buttonRateMe";
            this.buttonRateMe.Size = new System.Drawing.Size(333, 55);
            this.buttonRateMe.TabIndex = 10;
            this.buttonRateMe.Text = "Rate me!";
            this.buttonRateMe.UseVisualStyleBackColor = false;
            // 
            // buttonViewopinion
            // 
            this.buttonViewopinion.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonViewopinion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewopinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonViewopinion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewopinion.Location = new System.Drawing.Point(1569, 749);
            this.buttonViewopinion.Name = "buttonViewopinion";
            this.buttonViewopinion.Size = new System.Drawing.Size(333, 55);
            this.buttonViewopinion.TabIndex = 11;
            this.buttonViewopinion.Text = "View opinions";
            this.buttonViewopinion.UseVisualStyleBackColor = false;
            // 
            // labelGanre
            // 
            this.labelGanre.BackColor = System.Drawing.Color.Transparent;
            this.labelGanre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGanre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGanre.Location = new System.Drawing.Point(1569, 297);
            this.labelGanre.Name = "labelGanre";
            this.labelGanre.Size = new System.Drawing.Size(333, 56);
            this.labelGanre.TabIndex = 12;
            this.labelGanre.Text = "Ganere:";
            this.labelGanre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRate
            // 
            this.labelRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRate.Location = new System.Drawing.Point(1569, 379);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(333, 56);
            this.labelRate.TabIndex = 13;
            this.labelRate.Text = "Rate:";
            this.labelRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelName.Location = new System.Drawing.Point(1563, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(333, 56);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonClosePlayer
            // 
            this.buttonClosePlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClosePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClosePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonClosePlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClosePlayer.Location = new System.Drawing.Point(1572, 932);
            this.buttonClosePlayer.Name = "buttonClosePlayer";
            this.buttonClosePlayer.Size = new System.Drawing.Size(145, 55);
            this.buttonClosePlayer.TabIndex = 15;
            this.buttonClosePlayer.Text = "Close";
            this.buttonClosePlayer.UseVisualStyleBackColor = false;
            this.buttonClosePlayer.Click += new System.EventHandler(this.buttonClosePlayer_Click);
            // 
            // player_fast
            // 
            this.player_fast.Enabled = true;
            this.player_fast.Location = new System.Drawing.Point(1, 0);
            this.player_fast.Name = "player_fast";
            this.player_fast.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_fast.OcxState")));
            this.player_fast.Size = new System.Drawing.Size(1562, 991);
            this.player_fast.TabIndex = 17;
            this.player_fast.Visible = false;
            // 
            // buttonAddToFav
            // 
            this.buttonAddToFav.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddToFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddToFav.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddToFav.Location = new System.Drawing.Point(1569, 691);
            this.buttonAddToFav.Name = "buttonAddToFav";
            this.buttonAddToFav.Size = new System.Drawing.Size(333, 55);
            this.buttonAddToFav.TabIndex = 18;
            this.buttonAddToFav.Text = "Add to favorits";
            this.buttonAddToFav.UseVisualStyleBackColor = false;
            // 
            // WatchMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyStream.Properties.Resources.תמונה5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1909, 991);
            this.Controls.Add(this.buttonAddToFav);
            this.Controls.Add(this.buttonClosePlayer);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelGanre);
            this.Controls.Add(this.buttonViewopinion);
            this.Controls.Add(this.buttonLeaveOpinion);
            this.Controls.Add(this.buttonRateMe);
            this.Controls.Add(this.labelheadline);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelRelease);
            this.Controls.Add(this.buttonBeckToMain);
            this.Controls.Add(this.panel_display_movie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player_fast);
            this.DoubleBuffered = true;
            this.Name = "WatchMovies";
            this.Text = "WatchMovies";
            this.panel_display_movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_fast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_display_movie;
        private System.Windows.Forms.Button buttonBeckToMain;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelheadline;
        private System.Windows.Forms.Button buttonLeaveOpinion;
        private System.Windows.Forms.Button buttonRateMe;
        private System.Windows.Forms.Button buttonViewopinion;
        private System.Windows.Forms.Label labelGanre;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClosePlayer;
        private AxWMPLib.AxWindowsMediaPlayer player_fast;
        private System.Windows.Forms.Button buttonAddToFav;
    }
}