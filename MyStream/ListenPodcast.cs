using AxWMPLib;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyStream
{
    public partial class ListenPodcast : Form
    {
        public string _username { get; set; }
        private bool buttonClicked = false;
        static int count = 0;
        static int countPodcast1 = 0;
        static int countPodcast2 = 0;
        static int countPodcast3 = 0;
        static int countPodcast4 = 0;
        static int countPodcast5 = 0;
        AxWindowsMediaPlayer activePlayer; // general player
        public ListenPodcast() // basic constructor
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public ListenPodcast(string username) // advanced constructor
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
            _username = username;
        }

        private void ListenPodcast_Load(object sender, EventArgs e) // initiate active player as first podcast
        {
            activePlayer = playerPodcast1;
        }

        private void buttonBeckToMain_Click(object sender, EventArgs e) // close this form - returns to main form
        {
            Main main = new Main(_username);
            this.Close();
            main.Show();
        }

        private void buttonViewReviews_Click(object sender, EventArgs e) // open the reviews panel
        {
            if (activePlayer.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = true;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = false;
                panelAddToFav.Visible = false;
                panel_display_Podcast.SendToBack();
            }
        }

        private void buttonLeaveReview_Click(object sender, EventArgs e) // open the leave review panel
        {
            if (activePlayer.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = true;
                panel_rate_me.Visible = false;
                panelAddToFav.Visible = false;
                panel_display_Podcast.SendToBack();
            }
        }

        private void buttonRateMe_Click(object sender, EventArgs e) //open the rate  panel
        {
            if (activePlayer.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = true;
                panelAddToFav.Visible = false;
                panel_display_Podcast.SendToBack();
            }
        }

        private void buttonClosePlayer_Click(object sender, EventArgs e) // close the active player at this time
        {

            activePlayer.Visible = false;
            activePlayer.close();
            panel_display_Podcast.Visible = true;
        }

        private void button_close_rate_win_Click(object sender, EventArgs e) // close the rate panel
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

        private void button_confirm_rate_Click(object sender, EventArgs e) // confirm the rate add update the avg for this content
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
                foreach (KeyValuePair<int, User> user in User._users)
                {
                    bool userFound = false;
                    if (_username == user.Value._UserName)
                    {
                        userFound = true;
                        bool rated = false;
                        foreach (string item in user.Value._rates)
                        {
                            if (item == podcast_name)
                            {
                                rated = true;
                                MessageBox.Show("You can rate each content only once!");
                                break;
                            }
                        }
                        if (!rated)
                        {
                            ContentController.addRate(rate, podcast_name);
                            user.Value._rates.Add(podcast_name);
                            UserHendler.updateUser( user.Value);
                        }
                        break;
                    }
                    if (userFound)
                    {
                        break;
                    }
                }
                pb_star_1.Image = Resources.grey_star;
                pb_star_2.Image = Resources.grey_star;
                pb_star_3.Image = Resources.grey_star;
                pb_star_4.Image = Resources.grey_star;
                pb_star_5.Image = Resources.grey_star;
                label_rating_input.Text = string.Empty;
                comboBoxChoosePodcast.SelectedIndex = -1;
            }
        }

        private void button_leave_review_Click(object sender, EventArgs e) // transfer the user from rate panel to the leave review panel
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

        private void buttonCloseReview_Click(object sender, EventArgs e) // close the leave review panel
        {
            panelLeaveReview.Visible = false;
            comboBoxPodcastToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonConfirmReview_Click(object sender, EventArgs e) // confirm the review that the user enter
        {
            if (comboBoxPodcastToReview.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a podcast to review first");
            }
           else if (String.IsNullOrWhiteSpace(textBoxReview.Text))
            {
                MessageBox.Show("You cannot leave an empty review !");
            }
            else
            {
                string name = comboBoxPodcastToReview.Text;
                string review = textBoxReview.Text;
                panelLeaveReview.Visible = false;
                comboBoxPodcastToReview.SelectedIndex = -1;
                textBoxReview.Text = string.Empty;
                ContentController.addPodReviews(name, review); 
            }
        }

        private void buttonRateMovieFromReview_Click(object sender, EventArgs e) // transfer the user from leave review panel to the rate panel
        {
            panelLeaveReview.Visible = false;
            panel_rate_me.Visible = true;
            comboBoxPodcastToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonCloseReviewList_Click(object sender, EventArgs e) // close the review list panel
        {
            panelReviewList.Visible = false;
            listViewReview.Clear();
            comboBoxChoosePodcastToReviewList.SelectedIndex = -1;
        }

        private void buttonViewReview_Click(object sender, EventArgs e) // open the list view and show all the review for this content
        {
            if (!buttonClicked)
            {
                if (comboBoxChoosePodcastToReviewList.SelectedIndex == -1)
                {
                    MessageBox.Show("please choose a podcast to view first");
                }
                else
                {
                    string series = comboBoxChoosePodcastToReviewList.Text;
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
                }
                buttonClicked = true;
            }
        }

        private void buttonLeaveReviewFromList_Click(object sender, EventArgs e) // transfer the user from view review panel to the leave review panel
        {
            panelReviewList.Visible = false;
            panelReviewList.SendToBack();
            panelLeaveReview.Visible = true;
            listViewReview.Clear();
            comboBoxChoosePodcastToReviewList.SelectedIndex = -1;
        }

        private void play_Podcast(Podcast podcast, string path) //activate the podcast that user selected
        {
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YouTubePodcasts", path));
            if (File.Exists(fullPath))
            {
                panel_display_Podcast.SendToBack();
                activePlayer.Visible = true;
                activePlayer.URL = fullPath;
                activePlayer.Show();
            }
            else
            {
                MessageBox.Show("There is an error with playing the episode");
            }
        }

        private void setInfo(Podcast podcast) // set the info for the selected podcast
        {
            if (podcast != null)
            {
                labelName.Text += " " + podcast._name;
                labelRelease.Text += " " + podcast._date;
                labelHost.Text += " " + podcast._host;
                labelGuest.Text += " " + podcast._guest;
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

        private void buttonAddToFav_Click(object sender, EventArgs e) // open the add to favorite panel
        {
            if (activePlayer.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = false;
                panelAddToFav.Visible = true;
                panel_display_Podcast.SendToBack();
            }
        }

        private void comboBoxChoosePodcastToReviewList_SelectedIndexChanged(object sender, EventArgs e) // ensure that the view list will generate only once 
        {
            count++;
            if (count > 1)
            {
                listViewReview.Items.Clear();
            }
            buttonClicked = false;
        }

        private void buttonpodcast1_Click(object sender, EventArgs e) // activate the "Android Over Iphone" podcast
        {
            countPodcast1++;
            if (countPodcast1 % 2 == 1)
            {
                setInfo(null);
                Podcast podcast1 = Content._contents["Android Over Iphone"] as Podcast;
                if (podcast1 == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    if(activePlayer.Visible==true)
                    {
                        activePlayer.Visible = false;
                        activePlayer.close();
                    }
                    setInfo(podcast1);
                    labelDescription.Text += " The question about iphone over android";
                    playerPodcast1.Visible = true;
                    playerPodcast2.Visible = false;
                    playerPodcast3.Visible = false;
                    playerPodcast4.Visible = false;
                    playerPodcast5.Visible = false;
                    string path = podcast1._path;
                    activePlayer = playerPodcast1;
                    play_Podcast(podcast1 , path);
                }
            }
            else { playerPodcast1.Visible = false; setInfo(null); }
        }

        private void buttonpodcast2_Click(object sender, EventArgs e) // activate the "Deep Web" podcast
        {
            countPodcast2++;
            if (countPodcast2 % 2 == 1)
            {
                setInfo(null);
                Podcast podcast2 = Content._contents["Deep Web"] as Podcast;
                if (podcast2 == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    if (activePlayer.Visible == true)
                    {
                        activePlayer.Visible = false;
                        activePlayer.close();
                    }
                    setInfo(podcast2);
                    labelDescription.Text += " The dark side of the internet";
                    playerPodcast1.Visible = false;
                    playerPodcast2.Visible = true;
                    playerPodcast3.Visible = false;
                    playerPodcast4.Visible = false;
                    playerPodcast5.Visible = false;
                    string path = podcast2._path;
                    activePlayer = playerPodcast2;
                    play_Podcast(podcast2, path);
                }
            }
            else { playerPodcast2.Visible = false; setInfo(null); }
        }

        private void buttonpodcast3_Click(object sender, EventArgs e) // activate the "Harsh Reality Of Dating" podcast
        {
            countPodcast3++;
            if (countPodcast3 % 2 == 1)
            {
                setInfo(null);
                Podcast podcast3 = Content._contents["Harsh Reality Of Dating"] as Podcast;
                if (podcast3 == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    if (activePlayer.Visible == true)
                    {
                        activePlayer.Visible = false;
                        activePlayer.close();
                    }
                    setInfo(podcast3);
                    labelDescription.Text += " The truth behind the dating world ";
                    playerPodcast1.Visible = false;
                    playerPodcast2.Visible = false;
                    playerPodcast3.Visible = true;
                    playerPodcast4.Visible = false;
                    playerPodcast5.Visible = false;
                    string path = podcast3._path;
                    activePlayer = playerPodcast3;
                    play_Podcast(podcast3, path);
                }
            }
            else { playerPodcast3.Visible = false; setInfo(null); }
        }

        private void buttonpodcast4_Click(object sender, EventArgs e) // activate the "Reason ipads With USB-C" podcast
        {
            countPodcast4++;
            if (countPodcast4 % 2 == 1)
            {
                setInfo(null);
                Podcast podcast4 = Content._contents["Reason ipads With USB-C"] as Podcast;
                if (podcast4 == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    if (activePlayer.Visible == true)
                    {
                        activePlayer.Visible = false;
                        activePlayer.close();
                    }
                    setInfo(podcast4);
                    labelDescription.Text += " Ever wondered why iPads come with USB-C? ";
                    playerPodcast1.Visible = false;
                    playerPodcast2.Visible = false;
                    playerPodcast3.Visible = false;
                    playerPodcast4.Visible = true;
                    playerPodcast5.Visible = false;
                    string path = podcast4._path;
                    activePlayer = playerPodcast4;
                    play_Podcast(podcast4, path);
                }
            }
            else { playerPodcast4.Visible = false; setInfo(null); }
        }

        private void buttonpodcast5_Click(object sender, EventArgs e) // activate the "What Do Girls Want From Men" podcast
        {
            countPodcast5++;
            if (countPodcast5 % 2 == 1)
            {
                setInfo(null);
                Podcast podcast5 = Content._contents["What Do Girls Want From Men"] as Podcast;
                if (podcast5 == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    if (activePlayer.Visible == true)
                    {
                        activePlayer.Visible = false;
                        activePlayer.close();
                    }
                    setInfo(podcast5);
                    labelDescription.Text += " The most importent discovery above all ";
                    playerPodcast1.Visible = false;
                    playerPodcast2.Visible = false;
                    playerPodcast3.Visible = false;
                    playerPodcast4.Visible = false;
                    playerPodcast5.Visible = true;
                    string path = podcast5._path;
                    activePlayer = playerPodcast5;
                    play_Podcast(podcast5, path);
                }
            }
            else { playerPodcast5.Visible = false; setInfo(null); }
        }

        private void pb_star_1_Click_1(object sender, EventArgs e) // set 1 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "1";
            labelrating1.Text = "/5";
        }

        private void pb_star_2_Click_1(object sender, EventArgs e) // set 2 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "2";
            labelrating1.Text = "/5";
        }

        private void pb_star_3_Click_1(object sender, EventArgs e) // set 3 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "3";
            labelrating1.Text = "/5";
        }
        private void pb_star_4_Click_1(object sender, EventArgs e) // set 4 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.yellow_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "4";
            labelrating1.Text = "/5";

        }

        private void pb_star_5_Click_1(object sender, EventArgs e)// set 5 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.yellow_star;
            pb_star_5.Image = Resources.yellow_star;
            label_rating_input.Text = "5";
            labelrating1.Text = "/5";
        }

        private void buttonConfirmFav_Click(object sender, EventArgs e) // adding this content into the favorite list 
        {
            if (comboBoxPickPodToFav.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a podcast to add first");
            }
            else
            {
                string contentName = comboBoxPickPodToFav.Text;
                if (ContentController.addFav(_username, contentName))
                {
                    MessageBox.Show("The content has been added to your favorites list");
                }
                panelAddToFav.Visible = false;
                comboBoxPickPodToFav.SelectedIndex = -1;
            }
        }

        private void buttonClosePickFav_Click(object sender, EventArgs e) // close favorite list panel
        {
            panelAddToFav.Visible = false;
            comboBoxPickPodToFav.SelectedIndex = -1;
        }
    }
}
