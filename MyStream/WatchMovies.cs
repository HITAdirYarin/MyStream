using AxWMPLib;
using MyStream.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyStream
{
    public partial class WatchMovies : Form
    {
        public string _username { get; set; }
        public WatchMovies()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
        }

        public WatchMovies(string username)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
            _username = username;
        }

            private void _Click(object sender, EventArgs e)
        {
            
        }
        private void player_fast_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonClosePlayer_Click(object sender, EventArgs e)
        {
            player_fast.Visible = false;
            player_fast.close();
            panel_display_movie.Visible = true;
            labelName.Text = "Name:";
            labelRelease.Text = "Release date:";
            labelDirector.Text = "Director:";
            labelGanre.Text = "Ganere:";
            labelRate.Text = "Rate:";
            labelDescription.Text = "Description:";
        }

        private void buttonBeckToMain_Click_1(object sender, EventArgs e)
        {
            Main main = new Main(_username);
            this.Close();
            main.Show();
        }

        private void play_movie(Movies movie)
        {
            panel_display_movie.SendToBack();
            player_fast.Size = new Size(1042, 650);
            player_fast.Visible = true;
            panel_display_movie.Visible = false;
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YouTubeMovies", movie._path));
            if (File.Exists(fullPath))
            {
                player_fast.URL = fullPath;
            }
            else
            {
                MessageBox.Show("There is an error with playing the movie");
            }
            labelName.Text += " " + movie._name;
            labelRelease.Text += " " + movie._date;
            labelDirector.Text += " " + movie._director;
            labelGanre.Text += " " + movie._genre;
            string rate = movie._rateAvg.ToString("0.0");
            labelRate.Text += " " + rate + "/5";
            player_fast.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Movies fast9 =Content._contents["Fast and Furious 9"] as Movies ;
            if (fast9 == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(fast9);
                labelDescription.Text += " Dominic and his team are working againts the time to foil a plot, which threatens the entire civilization.";
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonRateMe_Click(object sender, EventArgs e)
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the movie first");
            }
            else
            {
                player_fast.SendToBack();
                panel_display_movie.SendToBack();
                panel_rate_me.Visible = true;
            } 
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
            panel_rate_me.Visible=false;
            pb_star_1.Image = Resources.grey_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = string.Empty;
            comboBoxChooseMovie.SelectedIndex = -1;
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

        private void button_confirm_rate_Click(object sender, EventArgs e)
        {
            if(comboBoxChooseMovie.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a movie to rate first");
            }
            else
            {
                panel_rate_me.Visible = false;
                int rate = int.Parse(label_rating_input.Text);
                string movie_name = comboBoxChooseMovie.Text;
                ContentController.addRate(rate, movie_name);
                pb_star_1.Image = Resources.grey_star;
                pb_star_2.Image = Resources.grey_star;
                pb_star_3.Image = Resources.grey_star;
                pb_star_4.Image = Resources.grey_star;
                pb_star_5.Image = Resources.grey_star;
                label_rating_input.Text = string.Empty;
                comboBoxChooseMovie.SelectedIndex = -1;
            }
        }

        private void buttonViewReviews_Click(object sender, EventArgs e)
        {
            if(player_fast.Visible)
            {
                MessageBox.Show("please close the movie first");
            }
            else
            {
                panelReviewList.Visible = true;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = false;
                player_fast.SendToBack();
                panel_display_movie.SendToBack();
            } 
        }

        private void panel_rate_me_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxChooseMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_display_movie_Paint(object sender, PaintEventArgs e)
        {

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
            comboBoxChooseMovie.SelectedIndex = -1;
        }

        private void buttonRateMovieFromReview_Click(object sender, EventArgs e)
        {
            panelLeaveReview.Visible = false;
            panel_rate_me.Visible = true;
            comboBoxMovieToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonCloseReview_Click(object sender, EventArgs e)
        {
            panelLeaveReview.Visible = false;
            comboBoxMovieToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonLeaveReview_Click(object sender, EventArgs e)
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the movie first");
            }
            else
            {
                player_fast.SendToBack();
                panel_display_movie.SendToBack();
                panelLeaveReview.Visible = true;
            }
        }

        private void buttonConfirmReview_Click(object sender, EventArgs e)
        {
            if (comboBoxMovieToReview.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a movie to review first");
            }
            else
            {
                string movie = comboBoxMovieToReview.Text;
                string review = textBoxReview.Text;
                panelLeaveReview.Visible = false;
                comboBoxMovieToReview.SelectedIndex = -1;
                textBoxReview.Text = string.Empty;
                ContentController.addMovieReviews(movie, review);
            }
        }

        private void buttonCloseReviewList_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = false;
            listViewReview.Clear();
            comboBoxChooseMovieToReviewList.SelectedIndex = -1;
        }

        private void buttonViewReview_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseMovieToReviewList.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a movie to view first");
            }
            else
            {
                string movie = comboBoxChooseMovieToReviewList.Text;
                foreach (KeyValuePair<string, Content> content in Content._contents)
                {
                    if (content.Value._name == movie)
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
            
           
        }

        private void buttonLeaveReviewFromList_Click(object sender, EventArgs e)
        {
            panelReviewList.Visible = false;
            panelReviewList.SendToBack();
            panelLeaveReview.Visible = true;
            listViewReview.Clear();
            comboBoxChooseMovieToReviewList.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movies three_300 = Content._contents["300"] as Movies;
            if (three_300 == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(three_300);
                labelDescription.Text += " King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movies ted = Content._contents["Ted"] as Movies;
            if (ted == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(ted);
                labelDescription.Text += " A man whose childhood wish of bringing his teddy bear to life came true";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Movies jump_street = Content._contents["21 Jump street"] as Movies;
            if (jump_street == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(jump_street);
                labelDescription.Text += " A pair of underachieving cops are sent back to a local high school to blend in";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Movies frozen = Content._contents["Frozen"] as Movies;
            if (frozen == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(frozen);
                labelDescription.Text += " Queen Elsa accidentally uses her power to turn things into ice to curse her home in infinite winter";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Movies friendswithbenefits = Content._contents["Friends with Benefits"] as Movies;
            if (friendswithbenefits == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(friendswithbenefits);
                labelDescription.Text += " A young man and woman decide to take their friendship to the next level without becoming a couple";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Movies titanic = Content._contents["Titanic"] as Movies;
            if (titanic == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(titanic);
                labelDescription.Text += " The movie tells the well known and dramatic story of the Titanic";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Movies The_godfather = Content._contents["The Godfather"] as Movies;
            if (The_godfather == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(The_godfather);
                labelDescription.Text += "Head of a mafia family, decides to hand over his empire to his youngest son";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Movies shrek = Content._contents["Shrek"] as Movies;
            if (shrek == null)
            {
                MessageBox.Show("ERROR");
            }
            else
            {
                play_movie(shrek);
                labelDescription.Text += "A marvelous fairy tale, with a thrilling quest and a happily-ever-after ending";
            }
        }
        static int count = 0;
        private void comboBoxChooseMovieToReviewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            if(count>1)
            {
                listViewReview.Items.Clear();
            }
        }

        private void player_fast_Enter_1(object sender, EventArgs e)
        {

        }

        private void buttonAddToFav_Click(object sender, EventArgs e)
        {

        }
    }
}
