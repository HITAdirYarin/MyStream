namespace MyStream
{
    partial class SurpriseMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurpriseMe));
            this.labelheadline = new System.Windows.Forms.Label();
            this.buttonAddToFav = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelGanre = new System.Windows.Forms.Label();
            this.labelRelease = new System.Windows.Forms.Label();
            this.buttonBeckToMain = new System.Windows.Forms.Button();
            this.player_fast = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player_fast)).BeginInit();
            this.SuspendLayout();
            // 
            // labelheadline
            // 
            this.labelheadline.AutoSize = true;
            this.labelheadline.BackColor = System.Drawing.Color.Transparent;
            this.labelheadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelheadline.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelheadline.Location = new System.Drawing.Point(1592, 9);
            this.labelheadline.Name = "labelheadline";
            this.labelheadline.Size = new System.Drawing.Size(273, 82);
            this.labelheadline.TabIndex = 23;
            this.labelheadline.Text = "Stream";
            this.labelheadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddToFav
            // 
            this.buttonAddToFav.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddToFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddToFav.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddToFav.Location = new System.Drawing.Point(1565, 824);
            this.buttonAddToFav.Name = "buttonAddToFav";
            this.buttonAddToFav.Size = new System.Drawing.Size(333, 55);
            this.buttonAddToFav.TabIndex = 27;
            this.buttonAddToFav.Text = "Add to favorits";
            this.buttonAddToFav.UseVisualStyleBackColor = false;
            this.buttonAddToFav.Click += new System.EventHandler(this.buttonAddToFav_Click);
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelName.Location = new System.Drawing.Point(1559, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(339, 94);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRate
            // 
            this.labelRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRate.Location = new System.Drawing.Point(1559, 408);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(333, 56);
            this.labelRate.TabIndex = 25;
            this.labelRate.Text = "Rate:";
            this.labelRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGanre
            // 
            this.labelGanre.BackColor = System.Drawing.Color.Transparent;
            this.labelGanre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGanre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGanre.Location = new System.Drawing.Point(1556, 313);
            this.labelGanre.Name = "labelGanre";
            this.labelGanre.Size = new System.Drawing.Size(333, 56);
            this.labelGanre.TabIndex = 24;
            this.labelGanre.Text = "Ganere:";
            this.labelGanre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRelease
            // 
            this.labelRelease.BackColor = System.Drawing.Color.Transparent;
            this.labelRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRelease.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelRelease.Location = new System.Drawing.Point(1556, 207);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(339, 86);
            this.labelRelease.TabIndex = 20;
            this.labelRelease.Text = "Release date:";
            this.labelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBeckToMain
            // 
            this.buttonBeckToMain.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBeckToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBeckToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBeckToMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBeckToMain.Location = new System.Drawing.Point(1565, 933);
            this.buttonBeckToMain.Name = "buttonBeckToMain";
            this.buttonBeckToMain.Size = new System.Drawing.Size(330, 55);
            this.buttonBeckToMain.TabIndex = 19;
            this.buttonBeckToMain.Text = "Back to main menu";
            this.buttonBeckToMain.UseVisualStyleBackColor = false;
            this.buttonBeckToMain.Click += new System.EventHandler(this.buttonBeckToMain_Click);
            // 
            // player_fast
            // 
            this.player_fast.Enabled = true;
            this.player_fast.Location = new System.Drawing.Point(-4978, -3271);
            this.player_fast.Name = "player_fast";
            this.player_fast.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player_fast.OcxState")));
            this.player_fast.Size = new System.Drawing.Size(11865, 7532);
            this.player_fast.TabIndex = 28;
            this.player_fast.Visible = false;
            this.player_fast.Enter += new System.EventHandler(this.player_fast_Enter);
            // 
            // SurpriseMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyStream.Properties.Resources.תמונה5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1909, 991);
            this.Controls.Add(this.labelheadline);
            this.Controls.Add(this.buttonAddToFav);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelGanre);
            this.Controls.Add(this.labelRelease);
            this.Controls.Add(this.buttonBeckToMain);
            this.Controls.Add(this.player_fast);
            this.DoubleBuffered = true;
            this.Name = "SurpriseMe";
            this.Text = "SurpriseMe";
            ((System.ComponentModel.ISupportInitialize)(this.player_fast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelheadline;
        private System.Windows.Forms.Button buttonAddToFav;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelGanre;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Button buttonBeckToMain;
        private AxWMPLib.AxWindowsMediaPlayer player_fast;
    }
}