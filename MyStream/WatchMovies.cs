using AxWMPLib;
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
using WMPLib;

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
            labelDirector.Text = "Director(s):";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Content fast9 = Content._contents["Fast and Furious 9"];
            panel_display_movie.SendToBack();
            player_fast.Size = new Size(1045, 645);
            player_fast.Visible = true;
            panel_display_movie.Visible = false;
            player_fast.URL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YouTubeContents", fast9._path);
            labelName.Text += fast9._name;
            labelRelease.Text += fast9._date;
            labelDirector.Text += fast9._director;
            labelGanre.Text += fast9._genre;
            labelRate.Text += fast9._rateAvg +"/5";
            labelDescription.Text += " a good movie!";
            player_fast.Show();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonRateMe_Click(object sender, EventArgs e)
        {
            ContentController.addRate(3, "Fast and Furious 9");

        }
    }
}
