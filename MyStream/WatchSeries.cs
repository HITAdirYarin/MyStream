using MyStream.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public partial class WatchSeries : Form
    {
        static int count = 0;
        static int countAvatar = 0;
        static int countBridgerton = 0;
        static int countBrooklyn = 0;
        static int countWalkingDead = 0;
        static int countVikings = 0;
        public string _username { get; set; }
        public WatchSeries()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
        }

        public WatchSeries(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
            _username = username;
        }

        private void buttonBeckToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main(_username);
            this.Close();
            main.Show();
        }

        private void buttonClosePlayer_Click(object sender, EventArgs e)
        {
            player_fast.Visible = false;
            player_fast.close();
            panel_display_Series.Visible = true;
            labelName.Text = "Name:";
            labelRelease.Text = "Release date:";
            labelDirector.Text = "Director:";
            labelGanre.Text = "Ganere:";
            labelRate.Text = "Rate:";
            labelDescription.Text = "Description:";
        }

        private void buttonRateMe_Click(object sender, EventArgs e)
        {
            player_fast.SendToBack();
            panel_display_Series.SendToBack();
            panel_rate_me.Visible = true;
        }

        private void pb_star_1_Click(object sender, EventArgs e)
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "1";
            labelrating1.Text = "/5";
        }

        private void pb_star_2_Click(object sender, EventArgs e)
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "2";
            labelrating1.Text = "/5";
        }

        private void pb_star_3_Click(object sender, EventArgs e)
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "3";
            labelrating1.Text = "/5";
        }

        private void pb_star_4_Click(object sender, EventArgs e)
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.yellow_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "4";
            labelrating1.Text = "/5";
        }

        private void pb_star_5_Click(object sender, EventArgs e)
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.yellow_star;
            pb_star_5.Image = Resources.yellow_star;
            label_rating_input.Text = "5";
            labelrating1.Text = "/5";
        }

        private void button_close_rate_win_Click(object sender, EventArgs e)
        {
            panel_rate_me.Visible = false;
            pb_star_1.Image = Resources.grey_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = string.Empty;
            comboBoxChooseSeries.SelectedIndex = -1;
        }

        private void button_confirm_rate_Click(object sender, EventArgs e)
        {
            panel_rate_me.Visible = false;
            int rate = int.Parse(label_rating_input.Text);
            string Series_name = comboBoxChooseSeries.Text;
            ContentController.addRate(rate, Series_name);
            pb_star_1.Image = Resources.grey_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = string.Empty;
            comboBoxChooseSeries.SelectedIndex = -1;
        }

        private void buttonViewReviews_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = true;
            panelLeaveReview.Visible = false;
            panel_rate_me.Visible = false;
            player_fast.SendToBack();
            panel_display_Series.SendToBack();
        }

        private void button_leave_review_Click(object sender, EventArgs e)
        {
            panel_rate_me.Visible = false;
            panelLeaveReview.Visible = true;
            pb_star_1.Image = Resources.grey_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = string.Empty;
            comboBoxChooseSeries.SelectedIndex = -1;
        }

        private void buttonRateMovieFromReview_Click(object sender, EventArgs e)
        {
            panelLeaveReview.Visible = false;
            panel_rate_me.Visible = true;
            comboBoxSeriesToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonCloseReview_Click(object sender, EventArgs e)
        {
            panelLeaveReview.Visible = false;
            comboBoxSeriesToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonLeaveReview_Click(object sender, EventArgs e)
        {
            player_fast.SendToBack();
            panel_display_Series.SendToBack();
            panelLeaveReview.Visible = true;
        }

        private void buttonConfirmReview_Click(object sender, EventArgs e)
        {
            string movie = comboBoxSeriesToReview.Text;
            string review = textBoxReview.Text;
            panelLeaveReview.Visible = false;
            comboBoxSeriesToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
            //ContentController.addReviews(movie, review); // problem - need to build or update addReview function!
        }

        private void buttonCloseReviewList_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = false;
            listViewReview.Clear();
            comboBoxChooseSeriesToReviewList.SelectedIndex = -1;
        }

        private void buttonLeaveReviewFromList_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = false;
            panelReviewList.SendToBack();
            panelLeaveReview.Visible = true;
            listViewReview.Clear();
            comboBoxChooseSeriesToReviewList.SelectedIndex = -1;
        }

        
        private void comboBoxChooseSeriesToReviewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            if (count > 1)
            {
                listViewReview.Items.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e) //Broklyn99 open panel activator
        {
            countBrooklyn++;
            if (countBrooklyn % 2 == 1)
            {
                panelBrooklyn.Visible = true;
                panelBridgerton.Visible = false;
                panelAvatar.Visible = false;
                panelWalkingDead.Visible = false;
                panelVikings.Visible = false;
            }
            else { panelBrooklyn.Visible = false; }
        }

        private void buttonAvatar_Click(object sender, EventArgs e)
        {
            countAvatar++;
            if (countAvatar % 2 == 1) 
            { 
                panelAvatar.Visible = true;
                panelBridgerton.Visible = false;
                panelBrooklyn.Visible = false;
                panelWalkingDead.Visible= false;
                panelVikings.Visible = false;
            }
            else { panelAvatar.Visible = false; }
        }

        private void buttonBridgerton_Click(object sender, EventArgs e)
        {
            countBridgerton++;
            if (countBridgerton % 2 == 1) 
            { 
                panelBridgerton.Visible = true;
                panelAvatar.Visible = false;
                panelBrooklyn.Visible = false;
                panelWalkingDead.Visible = false;
                panelVikings.Visible = false;
            }
            else { panelBridgerton.Visible = false; }
        }

        private void buttonWalkingDead_Click(object sender, EventArgs e)
        {
            countWalkingDead++;
            if(countWalkingDead%2 == 1) 
            { 
                panelWalkingDead.Visible = true;
                panelBridgerton.Visible = false;
                panelAvatar.Visible = false;
                panelBrooklyn.Visible = false;
                panelVikings.Visible = false;
            }
            else { panelWalkingDead.Visible=false; }
        }

        private void buttonVikings_Click(object sender, EventArgs e)
        {
            countVikings++;
            if(countVikings%2== 1) 
            { 
                panelVikings.Visible = true;
                panelBridgerton.Visible = false;
                panelAvatar.Visible = false;
                panelBrooklyn.Visible = false;
                panelWalkingDead.Visible = false;
            }
            else { panelVikings.Visible = false; }
        }

        private void buttonViewReview_Click(object sender, EventArgs e) // need to build file for this!
        {
            string series = comboBoxChooseSeriesToReviewList.Text;
            foreach (KeyValuePair<string, Content> content in Content._contents)
            {
                if (content.Value._name == series)
                {
                    foreach (string review in content.Value._review)
                    {
                        listViewReview.Items.Add(review);
                    }
                    break;
                }
            }
            listViewReview.Show();
        }

        private void play_Series(Series series) //need to build an appropriate constructor for the series objects
        {
            //panel_display_Series.SendToBack();
            //player_fast.Size = new Size(1045, 645);
            //player_fast.Visible = true;
            //panel_display_Series.Visible = false;
            //string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YouTubeSeries", series._path));
            //if (File.Exists(fullPath))
            //{
            //    player_fast.URL = fullPath;
            //}
            //else
            //{
            //    MessageBox.Show("There is an error with playing the movie");
            //}
            //labelName.Text += " " + series._name;
            //labelRelease.Text += " " + series._date;
            //labelDirector.Text += " " + series._director;
            //labelGanre.Text += " " + series._genre;
            //string rate = series._rateAvg.ToString("0.0");
            //labelRate.Text += " " + rate + "/5";
            //player_fast.Show();
        }
    }
    
}
