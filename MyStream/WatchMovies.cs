﻿using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Content fast9 = Content._contents["Fast and Furious 9"];
            panel_display_movie.SendToBack();
            player_fast.Size = new Size(1045, 645);
            player_fast.Visible = true;
            panel_display_movie.Visible = false;
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YouTubeMovies", fast9._path));
            if (File.Exists(fullPath))
            {
                player_fast.URL = fullPath;
            }
            else
            {
                MessageBox.Show("There is an error with playing the movie");
            }
            labelName.Text += " "+fast9._name;
            labelRelease.Text += " " + fast9._date;
            labelDirector.Text += " " + fast9._director;
            labelGanre.Text += " " + fast9._genre;
            string rate = fast9._rateAvg.ToString("0.0");
            labelRate.Text += " " + rate +"/5";
            labelDescription.Text += " Dominic and his team are working againts the time to foil a plot, which threatens the entire civilization.";
            player_fast.Show();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonRateMe_Click(object sender, EventArgs e)
        {
            ContentController.addRate(5, "Fast and Furious 9");

        }
    }
}
