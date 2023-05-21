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
            this.panel_rate_me = new System.Windows.Forms.Panel();
            this.labelrating1 = new System.Windows.Forms.Label();
            this.comboBoxChooseMovie = new System.Windows.Forms.ComboBox();
            this.choose_movie = new System.Windows.Forms.Label();
            this.label_rating_input = new System.Windows.Forms.Label();
            this.lbl_ratings = new System.Windows.Forms.Label();
            this.pb_star_5 = new System.Windows.Forms.PictureBox();
            this.pb_star_4 = new System.Windows.Forms.PictureBox();
            this.pb_star_3 = new System.Windows.Forms.PictureBox();
            this.pb_star_2 = new System.Windows.Forms.PictureBox();
            this.pb_star_1 = new System.Windows.Forms.PictureBox();
            this.button_leave_review = new System.Windows.Forms.Button();
            this.button_confirm_rate = new System.Windows.Forms.Button();
            this.button_close_rate_win = new System.Windows.Forms.Button();
            this.label_rate = new System.Windows.Forms.Label();
            this.buttonBeckToMain = new System.Windows.Forms.Button();
            this.labelRelease = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelheadline = new System.Windows.Forms.Label();
            this.buttonLeaveReview = new System.Windows.Forms.Button();
            this.buttonRateMe = new System.Windows.Forms.Button();
            this.buttonViewReviews = new System.Windows.Forms.Button();
            this.labelGanre = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClosePlayer = new System.Windows.Forms.Button();
            this.buttonAddToFav = new System.Windows.Forms.Button();
            this.player_fast = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel_display_movie.SuspendLayout();
            this.panel_rate_me.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_1)).BeginInit();
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
            this.panel_display_movie.Controls.Add(this.panel_rate_me);
            this.panel_display_movie.Controls.Add(this.button1);
            this.panel_display_movie.Location = new System.Drawing.Point(-2, -4);
            this.panel_display_movie.Name = "panel_display_movie";
            this.panel_display_movie.Size = new System.Drawing.Size(1568, 1003);
            this.panel_display_movie.TabIndex = 1;
            this.panel_display_movie.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_display_movie_Paint);
            // 
            // panel_rate_me
            // 
            this.panel_rate_me.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_rate_me.Controls.Add(this.labelrating1);
            this.panel_rate_me.Controls.Add(this.comboBoxChooseMovie);
            this.panel_rate_me.Controls.Add(this.choose_movie);
            this.panel_rate_me.Controls.Add(this.label_rating_input);
            this.panel_rate_me.Controls.Add(this.lbl_ratings);
            this.panel_rate_me.Controls.Add(this.pb_star_5);
            this.panel_rate_me.Controls.Add(this.pb_star_4);
            this.panel_rate_me.Controls.Add(this.pb_star_3);
            this.panel_rate_me.Controls.Add(this.pb_star_2);
            this.panel_rate_me.Controls.Add(this.pb_star_1);
            this.panel_rate_me.Controls.Add(this.button_leave_review);
            this.panel_rate_me.Controls.Add(this.button_confirm_rate);
            this.panel_rate_me.Controls.Add(this.button_close_rate_win);
            this.panel_rate_me.Controls.Add(this.label_rate);
            this.panel_rate_me.Location = new System.Drawing.Point(505, 297);
            this.panel_rate_me.Name = "panel_rate_me";
            this.panel_rate_me.Size = new System.Drawing.Size(674, 453);
            this.panel_rate_me.TabIndex = 1;
            this.panel_rate_me.Visible = false;
            this.panel_rate_me.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_rate_me_Paint);
            // 
            // labelrating1
            // 
            this.labelrating1.BackColor = System.Drawing.Color.Transparent;
            this.labelrating1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelrating1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelrating1.Location = new System.Drawing.Point(388, 290);
            this.labelrating1.Name = "labelrating1";
            this.labelrating1.Size = new System.Drawing.Size(65, 60);
            this.labelrating1.TabIndex = 28;
            this.labelrating1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxChooseMovie
            // 
            this.comboBoxChooseMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxChooseMovie.FormattingEnabled = true;
            this.comboBoxChooseMovie.Items.AddRange(new object[] {
            "Fast and Furious 9",
            "Ted",
            "300",
            "Frozen",
            "Friends with Benefits",
            "Titanic",
            "SpongeBob",
            "Shrek",
            "21 Jump street",
            "The godfather"});
            this.comboBoxChooseMovie.Location = new System.Drawing.Point(294, 126);
            this.comboBoxChooseMovie.Name = "comboBoxChooseMovie";
            this.comboBoxChooseMovie.Size = new System.Drawing.Size(291, 33);
            this.comboBoxChooseMovie.TabIndex = 27;
            this.comboBoxChooseMovie.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseMovie_SelectedIndexChanged);
            // 
            // choose_movie
            // 
            this.choose_movie.BackColor = System.Drawing.Color.Transparent;
            this.choose_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.choose_movie.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.choose_movie.Location = new System.Drawing.Point(37, 104);
            this.choose_movie.Name = "choose_movie";
            this.choose_movie.Size = new System.Drawing.Size(280, 60);
            this.choose_movie.TabIndex = 26;
            this.choose_movie.Text = "Choose Movie:";
            this.choose_movie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_rating_input
            // 
            this.label_rating_input.BackColor = System.Drawing.Color.Transparent;
            this.label_rating_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_rating_input.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_rating_input.Location = new System.Drawing.Point(348, 290);
            this.label_rating_input.Name = "label_rating_input";
            this.label_rating_input.Size = new System.Drawing.Size(71, 60);
            this.label_rating_input.TabIndex = 25;
            this.label_rating_input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ratings
            // 
            this.lbl_ratings.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ratings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_ratings.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_ratings.Location = new System.Drawing.Point(187, 290);
            this.lbl_ratings.Name = "lbl_ratings";
            this.lbl_ratings.Size = new System.Drawing.Size(166, 60);
            this.lbl_ratings.TabIndex = 24;
            this.lbl_ratings.Text = "Ratings:";
            this.lbl_ratings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_star_5
            // 
            this.pb_star_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_star_5.Image = global::MyStream.Properties.Resources.grey_star;
            this.pb_star_5.Location = new System.Drawing.Point(527, 209);
            this.pb_star_5.Name = "pb_star_5";
            this.pb_star_5.Size = new System.Drawing.Size(58, 57);
            this.pb_star_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star_5.TabIndex = 23;
            this.pb_star_5.TabStop = false;
            this.pb_star_5.Click += new System.EventHandler(this.pb_star_5_Click);
            // 
            // pb_star_4
            // 
            this.pb_star_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_star_4.Image = global::MyStream.Properties.Resources.grey_star;
            this.pb_star_4.Location = new System.Drawing.Point(420, 209);
            this.pb_star_4.Name = "pb_star_4";
            this.pb_star_4.Size = new System.Drawing.Size(58, 57);
            this.pb_star_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star_4.TabIndex = 22;
            this.pb_star_4.TabStop = false;
            this.pb_star_4.Click += new System.EventHandler(this.pb_star_4_Click);
            // 
            // pb_star_3
            // 
            this.pb_star_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_star_3.Image = global::MyStream.Properties.Resources.grey_star;
            this.pb_star_3.Location = new System.Drawing.Point(311, 209);
            this.pb_star_3.Name = "pb_star_3";
            this.pb_star_3.Size = new System.Drawing.Size(58, 57);
            this.pb_star_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star_3.TabIndex = 21;
            this.pb_star_3.TabStop = false;
            this.pb_star_3.Click += new System.EventHandler(this.pb_star_3_Click);
            // 
            // pb_star_2
            // 
            this.pb_star_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_star_2.Image = global::MyStream.Properties.Resources.grey_star;
            this.pb_star_2.Location = new System.Drawing.Point(214, 209);
            this.pb_star_2.Name = "pb_star_2";
            this.pb_star_2.Size = new System.Drawing.Size(58, 57);
            this.pb_star_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star_2.TabIndex = 20;
            this.pb_star_2.TabStop = false;
            this.pb_star_2.Click += new System.EventHandler(this.pb_star_2_Click);
            // 
            // pb_star_1
            // 
            this.pb_star_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_star_1.Image = global::MyStream.Properties.Resources.grey_star;
            this.pb_star_1.Location = new System.Drawing.Point(105, 209);
            this.pb_star_1.Name = "pb_star_1";
            this.pb_star_1.Size = new System.Drawing.Size(58, 57);
            this.pb_star_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star_1.TabIndex = 19;
            this.pb_star_1.TabStop = false;
            this.pb_star_1.Click += new System.EventHandler(this.pb_star_1_Click);
            // 
            // button_leave_review
            // 
            this.button_leave_review.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_leave_review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_leave_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_leave_review.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_leave_review.Location = new System.Drawing.Point(13, 367);
            this.button_leave_review.Name = "button_leave_review";
            this.button_leave_review.Size = new System.Drawing.Size(240, 55);
            this.button_leave_review.TabIndex = 18;
            this.button_leave_review.Text = "Leave Review";
            this.button_leave_review.UseVisualStyleBackColor = false;
            // 
            // button_confirm_rate
            // 
            this.button_confirm_rate.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_confirm_rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirm_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_confirm_rate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_confirm_rate.Location = new System.Drawing.Point(279, 367);
            this.button_confirm_rate.Name = "button_confirm_rate";
            this.button_confirm_rate.Size = new System.Drawing.Size(174, 55);
            this.button_confirm_rate.TabIndex = 17;
            this.button_confirm_rate.Text = "Confirm";
            this.button_confirm_rate.UseVisualStyleBackColor = false;
            this.button_confirm_rate.Click += new System.EventHandler(this.button_confirm_rate_Click);
            // 
            // button_close_rate_win
            // 
            this.button_close_rate_win.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_close_rate_win.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close_rate_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_close_rate_win.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_close_rate_win.Location = new System.Drawing.Point(498, 367);
            this.button_close_rate_win.Name = "button_close_rate_win";
            this.button_close_rate_win.Size = new System.Drawing.Size(145, 55);
            this.button_close_rate_win.TabIndex = 16;
            this.button_close_rate_win.Text = "Close";
            this.button_close_rate_win.UseVisualStyleBackColor = false;
            this.button_close_rate_win.Click += new System.EventHandler(this.button_close_rate_win_Click);
            // 
            // label_rate
            // 
            this.label_rate.BackColor = System.Drawing.Color.Transparent;
            this.label_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_rate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_rate.Location = new System.Drawing.Point(269, 0);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(137, 113);
            this.label_rate.TabIndex = 15;
            this.label_rate.Text = "Rate";
            this.label_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.labelRelease.Location = new System.Drawing.Point(1569, 184);
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
            this.labelDirector.Location = new System.Drawing.Point(1569, 240);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(333, 86);
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
            // buttonLeaveReview
            // 
            this.buttonLeaveReview.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLeaveReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaveReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLeaveReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLeaveReview.Location = new System.Drawing.Point(1572, 810);
            this.buttonLeaveReview.Name = "buttonLeaveReview";
            this.buttonLeaveReview.Size = new System.Drawing.Size(333, 55);
            this.buttonLeaveReview.TabIndex = 9;
            this.buttonLeaveReview.Text = "Leave a Review";
            this.buttonLeaveReview.UseVisualStyleBackColor = false;
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
            this.buttonRateMe.Click += new System.EventHandler(this.buttonRateMe_Click);
            // 
            // buttonViewReviews
            // 
            this.buttonViewReviews.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonViewReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonViewReviews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonViewReviews.Location = new System.Drawing.Point(1569, 749);
            this.buttonViewReviews.Name = "buttonViewReviews";
            this.buttonViewReviews.Size = new System.Drawing.Size(333, 55);
            this.buttonViewReviews.TabIndex = 11;
            this.buttonViewReviews.Text = "View Reviews";
            this.buttonViewReviews.UseVisualStyleBackColor = false;
            this.buttonViewReviews.Click += new System.EventHandler(this.buttonViewReviews_Click);
            // 
            // labelGanre
            // 
            this.labelGanre.BackColor = System.Drawing.Color.Transparent;
            this.labelGanre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGanre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGanre.Location = new System.Drawing.Point(1569, 309);
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
            this.labelName.Location = new System.Drawing.Point(1572, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(339, 113);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
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
            this.Controls.Add(this.buttonViewReviews);
            this.Controls.Add(this.buttonLeaveReview);
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
            this.panel_rate_me.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star_1)).EndInit();
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
        private System.Windows.Forms.Button buttonLeaveReview;
        private System.Windows.Forms.Button buttonRateMe;
        private System.Windows.Forms.Button buttonViewReviews;
        private System.Windows.Forms.Label labelGanre;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClosePlayer;
        private AxWMPLib.AxWindowsMediaPlayer player_fast;
        private System.Windows.Forms.Button buttonAddToFav;
        private System.Windows.Forms.Panel panel_rate_me;
        private System.Windows.Forms.PictureBox pb_star_1;
        private System.Windows.Forms.Button button_leave_review;
        private System.Windows.Forms.Button button_confirm_rate;
        private System.Windows.Forms.Button button_close_rate_win;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label lbl_ratings;
        private System.Windows.Forms.PictureBox pb_star_5;
        private System.Windows.Forms.PictureBox pb_star_4;
        private System.Windows.Forms.PictureBox pb_star_3;
        private System.Windows.Forms.PictureBox pb_star_2;
        private System.Windows.Forms.ComboBox comboBoxChooseMovie;
        private System.Windows.Forms.Label choose_movie;
        private System.Windows.Forms.Label label_rating_input;
        private System.Windows.Forms.Label labelrating1;
    }
}