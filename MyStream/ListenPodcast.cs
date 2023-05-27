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
    public partial class ListenPodcast : Form
    {
        public string _username { get; set; }
        public ListenPodcast()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public ListenPodcast(string username)
        {
            this.WindowState = FormWindowState.Maximized; // set full screen
            _username = username;
        }

        private void ListenPodcast_Load(object sender, EventArgs e)
        {

        }

        private void buttonBeckToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main(_username);
            this.Close();
            main.Show();
        }

        private void buttonViewReviews_Click(object sender, EventArgs e)
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = true;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = false;
                player_fast.SendToBack();
                panel_display_Podcast.SendToBack();
            }
        }

        private void buttonLeaveReview_Click(object sender, EventArgs e)
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = true;
                panel_rate_me.Visible = false;
                player_fast.SendToBack();
                panel_display_Podcast.SendToBack();
            }
        }

        private void buttonRateMe_Click(object sender, EventArgs e)
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = true;
                player_fast.SendToBack();
                panel_display_Podcast.SendToBack();
            }
        }

        private void buttonClosePlayer_Click(object sender, EventArgs e)
        {
            player_fast.Visible = false;
            player_fast.close();
            panel_display_Podcast.Visible = true;
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
            comboBoxChoosePodcast.SelectedIndex = -1;
        }

        private void button_confirm_rate_Click(object sender, EventArgs e)
        {
            if (comboBoxChoosePodcast.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a podcast to rate first");
            }
            else
            {
                panel_rate_me.Visible = false;
                int rate = int.Parse(label_rating_input.Text);
                string podcast_name = comboBoxChoosePodcast.Text;
                ContentController.addRate(rate, podcast_name); // need to build this function! 
                pb_star_1.Image = Resources.grey_star;
                pb_star_2.Image = Resources.grey_star;
                pb_star_3.Image = Resources.grey_star;
                pb_star_4.Image = Resources.grey_star;
                pb_star_5.Image = Resources.grey_star;
                label_rating_input.Text = string.Empty;
                comboBoxChoosePodcast.SelectedIndex = -1;
            }
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
            comboBoxChoosePodcast.SelectedIndex = -1;
        }

        private void buttonCloseReview_Click(object sender, EventArgs e)
        {
            panelLeaveReview.Visible = false;
            comboBoxPodcastToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonConfirmReview_Click(object sender, EventArgs e)
        {
            if (comboBoxPodcastToReview.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a podcast to review first");
            }
            else
            {
                string name = comboBoxPodcastToReview.Text;
                string review = textBoxReview.Text;
                panelLeaveReview.Visible = false;
                comboBoxPodcastToReview.SelectedIndex = -1;
                textBoxReview.Text = string.Empty;
                ContentController.addSeriesReviews(name, review); // need to build a function!
            }
        }

        private void buttonRateMovieFromReview_Click(object sender, EventArgs e)
        {
            panelLeaveReview.Visible = false;
            panel_rate_me.Visible = true;
            comboBoxPodcastToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonCloseReviewList_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = false;
            listViewReview.Clear();
            comboBoxChoosePodcastToReviewList.SelectedIndex = -1;
        }

        private void buttonViewReview_Click(object sender, EventArgs e)
        {
            if (comboBoxChoosePodcastToReviewList.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a podcast to view first");
            }
            string series = comboBoxChoosePodcastToReviewList.Text;
            foreach (KeyValuePair<string, Content> content in Content._contents)
            {
                if (content.Value._name == series)
                {
                    foreach (string review in content.Value._review)
                    {
                        listViewReview.Items.Add(review); // need to build a function for this!
                    }
                    break;
                }
            }
            listViewReview.Show();
        }

        private void buttonLeaveReviewFromList_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = false;
            panelReviewList.SendToBack();
            panelLeaveReview.Visible = true;
            listViewReview.Clear();
            comboBoxChoosePodcastToReviewList.SelectedIndex = -1;
        }

        private void play_Podcast(Podcast podcast, string path) //activate the podcast that user selected
        {
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, podcast._name, path));
            if (File.Exists(fullPath))
            {
                panel_display_Podcast.SendToBack();
                player_fast.Size = new Size(1042, 650);
                player_fast.Visible = true;
                panel_display_Podcast.Visible = false;
                player_fast.URL = fullPath;
                player_fast.Show();
            }
            else
            {
                MessageBox.Show("There is an error with playing the episode");
            }
        }

        private void setInfo(Podcast podcast)
        {
            if (podcast != null)
            {
                labelName.Text += " " + podcast._name;
                labelRelease.Text += " " + podcast._date;
                //labelHost.Text += " " + podcast._host;
                //labelGuest.Text += " " + podcast._guest;
                string rate = podcast._rateAvg.ToString("0.0");
                labelRate.Text += " " + rate + "/5";
            }
            else
            {
                labelName.Text = "Name:";
                labelRelease.Text = "Release date:";
                labelHost.Text = "Host:";
                labelGuest.Text = "Guest:";
                labelRate.Text = "Rate:";
                labelDescription.Text = "Description:";
            }
        } // set the info for the picked series
    }
}
