using MyStream.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
        }

        private void buttonRateMe_Click(object sender, EventArgs e)
        {
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the episode first");
            }
            else
            {
                player_fast.SendToBack();
                panel_display_Series.SendToBack();
                panel_rate_me.Visible = true;
            }
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
            ContentController.addRate(rate, Series_name); // problem - need to build or update addRate function (build update series func)!
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
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the episode first");
            }
            else
            {
                panelReviewList.Visible = true;
                panelLeaveReview.Visible = false;
                panel_rate_me.Visible = false;
                player_fast.SendToBack();
                panel_display_Series.SendToBack();
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
            if (player_fast.Visible)
            {
                MessageBox.Show("please close the episode first");
            }
            else
            {
                player_fast.SendToBack();
                panel_display_Series.SendToBack();
                panelLeaveReview.Visible = true;
            }
        }

        private void buttonConfirmReview_Click(object sender, EventArgs e)
        {
            string movie = comboBoxSeriesToReview.Text;
            string review = textBoxReview.Text;
            panelLeaveReview.Visible = false;
            comboBoxSeriesToReview.SelectedIndex = -1;
            textBoxReview.Text = string.Empty;
            //ContentController.addReviews(movie, review); // problem - need to build or update addReview function (build update series func)!
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
                setInfo(null);
                Series Brooklyn_99 = Content._contents["Brooklyn_99"] as Series;
                if (Brooklyn_99 == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    setInfo(Brooklyn_99);
                    labelDescription.Text += " The premise revolves around seven New York City Police detectives";
                    panelBrooklyn.Visible = true;
                    panelBridgerton.Visible = false;
                    panelAvatar.Visible = false;
                    panelWalkingDead.Visible = false;
                    panelVikings.Visible = false;
                }
                    
            }
            else { panelBrooklyn.Visible = false; setInfo(null); }
        }

        private void buttonAvatar_Click(object sender, EventArgs e)
        {
            countAvatar++;
            if (countAvatar % 2 == 1) 
            {
                setInfo(null);
                Series Avatar = Content._contents["Avatar"] as Series;
                if (Avatar == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    setInfo(Avatar);
                    labelDescription.Text += " In a war-torn world of elemental magic, a boy need to fulfill his destiny as the Avatar";
                    panelBrooklyn.Visible = false;
                    panelBridgerton.Visible = false;
                    panelAvatar.Visible = true;
                    panelWalkingDead.Visible = false;
                    panelVikings.Visible = false;
                }
            }
            else { panelAvatar.Visible = false; setInfo(null); }
        }

        private void buttonBridgerton_Click(object sender, EventArgs e)
        {
            countBridgerton++;
            if (countBridgerton % 2 == 1) 
            {
                setInfo(null);
                Series Bridgerton = Content._contents["Bridgerton"] as Series;
                if (Bridgerton == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    setInfo(Bridgerton);
                    labelDescription.Text += " Wealth, lust, and betrayal set against the backdrop of Regency-era England";
                    panelBrooklyn.Visible = false;
                    panelBridgerton.Visible = true;
                    panelAvatar.Visible = false;
                    panelWalkingDead.Visible = false;
                    panelVikings.Visible = false;
                }
            }
            else { panelBridgerton.Visible = false; setInfo(null); }
        }

        private void buttonWalkingDead_Click(object sender, EventArgs e)
        {
            
            countWalkingDead++;
            if(countWalkingDead%2 == 1) 
            {
                setInfo(null);
                Series The_Walking_Dead = Content._contents["The_Walking_Dead"] as Series;
                if (The_Walking_Dead == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    setInfo(The_Walking_Dead);
                    labelDescription.Text += " survivors of a zombie apocalypse trying to stay alive";
                    panelBrooklyn.Visible = false;
                    panelBridgerton.Visible = false;
                    panelAvatar.Visible = false;
                    panelWalkingDead.Visible = true;
                    panelVikings.Visible = false;
                }
            }
            else { panelWalkingDead.Visible=false; setInfo(null); }
        }

        private void buttonVikings_Click(object sender, EventArgs e)
        {
            countVikings++;
            if(countVikings%2== 1) 
            {
                setInfo(null);
                Series Vikings = Content._contents["Vikings"] as Series;
                if (Vikings == null)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    setInfo(Vikings);
                    labelDescription.Text += " follows Ragnar's quest to become Earl, and his desire to raid England";
                    panelBrooklyn.Visible = false;
                    panelBridgerton.Visible = false;
                    panelAvatar.Visible = false;
                    panelWalkingDead.Visible = false;
                    panelVikings.Visible = true;
                }
            }
            else { panelVikings.Visible = false; setInfo(null); }
        }

        private void buttonViewReview_Click(object sender, EventArgs e) // need to fix "updateSeries" for this!
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

        private void play_Episode(Series series , string path) //activate the episode that user selected
        {
            series._path = path;
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, series._name, series._path));
            if (File.Exists(fullPath))
            {
                panel_display_Series.SendToBack();
                player_fast.Size = new Size(1042, 650);
                player_fast.Visible = true;
                panel_display_Series.Visible = false;
                player_fast.URL = fullPath;
                player_fast.Show();
            }
            else
            {
                MessageBox.Show("There is an error with playing the movie");
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {
          
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Series Brooklyn_99 = Content._contents["Brooklyn_99"] as Series;
            play_Episode(Brooklyn_99 , Brooklyn_99._episodes[0]);
        } //episode 1 - brooklyn

        private void setInfo(Series series)
        {
            if(series!=null)
            {
                labelName.Text += " " + series._name;
                labelRelease.Text += " " + series._date;
                labelEpNum.Text += " " + series._episodeAmount;
                labelGanre.Text += " " + series._genre;
                string rate = series._rateAvg.ToString("0.0");
                labelRate.Text += " " + rate + "/5";
            }
            else
            {
                labelName.Text = "Name:";
                labelRelease.Text = "Release date:";
                labelEpNum.Text = "Episode number:";
                labelGanre.Text = "Ganere:";
                labelRate.Text = "Rate:";
                labelDescription.Text = "Description:";
            }
        } // set the info for the picked series

        private void button7_Click(object sender, EventArgs e)
        {
            Series Brooklyn_99 = Content._contents["Brooklyn_99"] as Series;
            play_Episode(Brooklyn_99, Brooklyn_99._episodes[1]);
        } //episode 2 - brooklyn

        private void button6_Click(object sender, EventArgs e)
        {
            Series Brooklyn_99 = Content._contents["Brooklyn_99"] as Series;
            play_Episode(Brooklyn_99, Brooklyn_99._episodes[2]);
        } //episode 3 - brooklyn

        private void button9_Click(object sender, EventArgs e)
        {
            Series Brooklyn_99 = Content._contents["Brooklyn_99"] as Series;
            play_Episode(Brooklyn_99, Brooklyn_99._episodes[3]);
        } //episode 4 - brooklyn

        private void button10_Click(object sender, EventArgs e) //episode 5 - brooklyn
        {
            Series Brooklyn_99 = Content._contents["Brooklyn_99"] as Series;
            play_Episode(Brooklyn_99, Brooklyn_99._episodes[4]);
        }

        private void buttonEP1Avatar_Click(object sender, EventArgs e)
        {
            Series Avatar = Content._contents["Avatar"] as Series;
            play_Episode(Avatar, Avatar._episodes[0]);
        }

        private void buttonEP2Avatar_Click(object sender, EventArgs e)
        {
            Series Avatar = Content._contents["Avatar"] as Series;
            play_Episode(Avatar, Avatar._episodes[1]);
        }

        private void buttonEP3Avatar_Click(object sender, EventArgs e)
        {
            Series Avatar = Content._contents["Avatar"] as Series;
            play_Episode(Avatar, Avatar._episodes[2]);
        }

        private void buttonBridgertonEp1_Click(object sender, EventArgs e)
        {
            Series Bridgerton = Content._contents["Bridgerton"] as Series;
            play_Episode(Bridgerton, Bridgerton._episodes[0]);
        }

        private void buttonBridgertonEp2_Click(object sender, EventArgs e)
        {
            Series Bridgerton = Content._contents["Bridgerton"] as Series;
            play_Episode(Bridgerton, Bridgerton._episodes[1]);
        }

        private void buttonBridgertonEp3_Click(object sender, EventArgs e)
        {
            Series Bridgerton = Content._contents["Bridgerton"] as Series;
            play_Episode(Bridgerton, Bridgerton._episodes[2]);
        }

        private void button13_Click(object sender, EventArgs e) //episode 1 - walking dead
        {
            Series The_Walking_Dead = Content._contents["The_Walking_Dead"] as Series;
            play_Episode(The_Walking_Dead, The_Walking_Dead._episodes[0]);
        }

        private void button12_Click(object sender, EventArgs e) //episode 2 - walking dead
        {
            Series The_Walking_Dead = Content._contents["The_Walking_Dead"] as Series;
            play_Episode(The_Walking_Dead, The_Walking_Dead._episodes[1]);
        }

        private void button11_Click(object sender, EventArgs e) //episode 3 - walking dead
        {
            Series The_Walking_Dead = Content._contents["The_Walking_Dead"] as Series;
            play_Episode(The_Walking_Dead, The_Walking_Dead._episodes[2]);
        }

        private void buttonEP1Vikings_Click(object sender, EventArgs e)
        {
            Series Vikings = Content._contents["Vikings"] as Series;
            play_Episode(Vikings, Vikings._episodes[0]);
        }

        private void buttonEP2Vikings_Click(object sender, EventArgs e)
        {
            Series Vikings = Content._contents["Vikings"] as Series;
            play_Episode(Vikings, Vikings._episodes[1]);
        }

        private void buttonEP3Vikings_Click(object sender, EventArgs e)
        {
            Series Vikings = Content._contents["Vikings"] as Series;
            play_Episode(Vikings, Vikings._episodes[2]);
        }

        private void buttonEP4Vikings_Click(object sender, EventArgs e)
        {
            Series Vikings = Content._contents["Vikings"] as Series;
            play_Episode(Vikings, Vikings._episodes[3]);
        }
    }
    
}
