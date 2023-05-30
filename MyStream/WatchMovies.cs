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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyStream
{
    public partial class WatchMovies : Form
    {
        public string _username { get; set; }
        private bool buttonClicked = false;
        static int count = 0;
        public WatchMovies() // basic constructor
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
        }

        public WatchMovies(string username) // advanced constructor
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
            _username = username;
        }

        private void buttonClosePlayer_Click(object sender, EventArgs e) // close the active player at this time
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

        private void buttonBeckToMain_Click_1(object sender, EventArgs e) // close this form - returns to main form
        {
            Main main = new Main(_username);
            this.Close();
            main.Show();
        }

        private void play_movie(Movies movie) //activate the movie that user selected
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
        private void button1_Click(object sender, EventArgs e) // play the movie "Fast and Furious 9"
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

        private void buttonRateMe_Click(object sender, EventArgs e) //open the rate  panel
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
                panelAddToFav.Visible = false;
                panelLeaveReview.Visible = false;
                panelReviewList.Visible = false;
            } 
        }

        private void pb_star_5_Click(object sender, EventArgs e) // set 5 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.yellow_star;
            pb_star_5.Image = Resources.yellow_star;
            label_rating_input.Text = "5";
            labelrating1.Text = "/5";
        }

        private void button_close_rate_win_Click(object sender, EventArgs e) // close the rate panel
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

        private void pb_star_4_Click(object sender, EventArgs e) // set 4 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.yellow_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "4";
            labelrating1.Text = "/5";
        }

        private void pb_star_3_Click(object sender, EventArgs e) // set 3 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.yellow_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "3";
            labelrating1.Text = "/5";
        }

        private void pb_star_2_Click(object sender, EventArgs e) // set 2 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.yellow_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "2";
            labelrating1.Text = "/5";
        }

        private void pb_star_1_Click(object sender, EventArgs e) // set 1 star in the rating panel
        {
            pb_star_1.Image = Resources.yellow_star;
            pb_star_2.Image = Resources.grey_star;
            pb_star_3.Image = Resources.grey_star;
            pb_star_4.Image = Resources.grey_star;
            pb_star_5.Image = Resources.grey_star;
            label_rating_input.Text = "1";
            labelrating1.Text = "/5";
        }

        private void button_confirm_rate_Click(object sender, EventArgs e) // confirm the rate add update the avg for this content
        {
          
            if (comboBoxChooseMovie.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a movie to rate first");
            }
            else
            {
                panel_rate_me.Visible = false;
                int rate = int.Parse(label_rating_input.Text);
                string movie_name = comboBoxChooseMovie.Text;
                foreach (KeyValuePair<int, User> user in User._users)
                {
                    bool userFound = false;
                    if (_username == user.Value._UserName)
                    {
                        userFound = true;
                        bool rated = false; 
                        foreach (string item in user.Value._rates)
                        {
                            if (item == movie_name)
                            {
                                rated = true;
                                MessageBox.Show("You can rate each content only once!");
                                break;
                            }
                          }
                        if (!rated)
                        {
                            ContentController.addRate(rate, movie_name);
                            user.Value._rates.Add(movie_name);
                            UserHendler.updateUser(user.Value._userId, user.Value);
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
                comboBoxChooseMovie.SelectedIndex = -1;
            }
        }

        private void buttonViewReviews_Click(object sender, EventArgs e) // open the reviews panel
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
                panelAddToFav.Visible = false;
                player_fast.SendToBack();
                panel_display_movie.SendToBack();
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
            comboBoxChooseMovie.SelectedIndex = -1;
        }

        private void buttonRateMovieFromReview_Click(object sender, EventArgs e) // transfer the user from leave review panel to the rate panel
        {
            panelLeaveReview.Visible = false;
            panel_rate_me.Visible = true;
            comboBoxMovieToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonCloseReview_Click(object sender, EventArgs e) // close the leave review panel
        {
            panelLeaveReview.Visible = false;
            comboBoxMovieToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
        }

        private void buttonLeaveReview_Click(object sender, EventArgs e) // open the leave review panel
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the movie first");
            }
            else
            {
                player_fast.SendToBack();
                panel_display_movie.SendToBack();
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = true;
                panel_rate_me.Visible = false;
                panelAddToFav.Visible = false;
            }
        }

        private void buttonConfirmReview_Click(object sender, EventArgs e) // confirm the review that the user enter
        {
            if (comboBoxMovieToReview.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a movie to review first");
            }
            if (String.IsNullOrWhiteSpace(textBoxReview.Text))
            {
                MessageBox.Show("You cannot leave an empty review !");
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

        private void buttonCloseReviewList_Click(object sender, EventArgs e) // close the review list panel
        {
            panelReviewList.Visible = false;
            listViewReview.Clear();
            comboBoxChooseMovieToReviewList.SelectedIndex = -1;
        }

        private void buttonViewReview_Click(object sender, EventArgs e) // open the list view and show all the review for this content
        {
            if (!buttonClicked)
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
            comboBoxChooseMovieToReviewList.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e) // play the movie "300"
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

        private void button3_Click(object sender, EventArgs e) // play the movie "ted"
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

        private void button4_Click(object sender, EventArgs e) // play the movie "21 Jump street"
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

        private void button5_Click(object sender, EventArgs e) // play the movie "Frozen"
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

        private void button6_Click(object sender, EventArgs e) // play the movie "Friends with Benefits"
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

        private void button7_Click(object sender, EventArgs e) // play the movie "Titanic"
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

        private void button8_Click(object sender, EventArgs e) // play the movie "The Godfather"
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

        private void button9_Click(object sender, EventArgs e)  // play the movie "Shrek"
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

        
        private void comboBoxChooseMovieToReviewList_SelectedIndexChanged(object sender, EventArgs e) // ensure that the view list will generate only once
        {
            count++;
            if(count>1)
            {
                listViewReview.Items.Clear();
            }
            buttonClicked = false;
        }

        private void buttonAddToFav_Click(object sender, EventArgs e) // open the add to favorite panel
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the podcast first");
            }
            else
            {
                panelReviewList.Visible = false;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = false;
                panelAddToFav.Visible = true;
                panel_display_movie.SendToBack();
            }
        }

        private void buttonConfirmFav_Click(object sender, EventArgs e) // adding this content into the favorite list
        {
            if (comboBoxPickMovieToFav.SelectedIndex == -1)
            {
                MessageBox.Show("please choose a movie to add first");
            }


            else
            {
                string contentName = comboBoxPickMovieToFav.Text;
                if (ContentController.addFav(_username, contentName))
                {
                    MessageBox.Show("The content has been added to your favorites list");
                }
                else { MessageBox.Show("Theres been a problem adding this content into your favorite list"); }
                panelAddToFav.Visible = false;
                comboBoxPickMovieToFav.SelectedIndex = -1;
            }
        }

        private void buttonClosePickFav_Click(object sender, EventArgs e) // close favorite list panel
        {
            panelAddToFav.Visible = false;
            comboBoxPickMovieToFav.SelectedIndex = -1;
        }
    }
}
