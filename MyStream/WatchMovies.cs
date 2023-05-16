using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            panel_display_movie.SendToBack();
            player_fast.Size = new Size(1045, 645);
            player_fast.Visible = true;
            panel_display_movie.Visible = false;
            player_fast.URL = "C:\\Users\\HP\\OneDrive\\Desktop\\photos_project\\YouTubeContents\\Fast&Furious9.mp4";
            labelName.Text += " Fast9";
            labelRelease.Text += " 25/09/22";
            labelDirector.Text += " yarin";
            labelGanre.Text += " action";
            labelRate.Text += " 87";
            labelDescription.Text += " a good movie!";
            player_fast.Show();
        }
    }
}
