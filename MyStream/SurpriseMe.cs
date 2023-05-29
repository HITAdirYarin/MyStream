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
    public partial class SurpriseMe : Form
    {
        public string _username { get; set; }
        public SurpriseMe()
        {
            InitializeComponent();

        }

        public SurpriseMe(string username , string ContentName, string path)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // set full screen
            _username = username;
            playRandomContent(ContentName, path);
        }

        private void buttonBeckToMain_Click(object sender, EventArgs e)
        {
            Main main = new Main(_username);
            setInfo(null);
            this.Close();
            main.Show();
        }

        private void playRandomContent(string ContentName , string path) //activate a random content that user selected
        {
            Content content = Content._contents[ContentName];
            setInfo(content);
            string fullPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, content._name, path));
            if (File.Exists(fullPath))
            {
               
                player_fast.Size = new Size(1042, 650);
                player_fast.Visible = true;
                player_fast.URL = fullPath;
                player_fast.Show();
            }
            else
            {
                MessageBox.Show("There is an error with playing the episode");
            }
        }

        private void setInfo(Content content)
        {
            if (content != null)
            {
                labelName.Text += " " + content._name;
                labelRelease.Text += " " + content._date;
                labelGanre.Text += " " + content._genre;
                string rate = content._rateAvg.ToString("0.0");
                labelRate.Text += " " + rate + "/5";
            }
            else
            {
                labelName.Text = "Name:";
                labelRelease.Text = "Release date:";
                labelGanre.Text = "Ganere:";
                labelRate.Text = "Rate:";
            }
        } // set the info for the picked series
    }
}
