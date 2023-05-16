using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Net;
using System.Diagnostics;
using CefSharp;
using CefSharp.WinForms;


namespace MyStream
{
    public partial class Main : Form
    {
        public string Username;
        public Main()
        {
            InitializeComponent();
           
        }

        public Main(string username)
        {
            this.WindowState = FormWindowState.Maximized; // set full screen
            Username = username;
            InitializeComponent();
            label_hello.Text = "Hello, " + Username;
           // CefSettings settings = new CefSettings();
           // Cef.Initialize(settings);


        }

        private void Main_Load(object sender, EventArgs e)
        {
           
            

        }

        private void buttonWatchContent_Click(object sender, EventArgs e)
        {
            button_movie.Visible = true;
            button_series.Visible = true;
            buttonPodcast.Visible = true;
            button_backToMain_content.Visible = true;
            buttonFavList.Visible = false;
            buttonRandom.Visible = false;
        }

        private void button_backToMain_Click(object sender, EventArgs e)
        {
            button_movie.Visible = false;
            button_series.Visible = false;
            buttonPodcast.Visible = false;
            button_backToMain_content.Visible = false;
            buttonFavList.Visible = true;
            buttonRandom.Visible = true;
        }

        private void label_hello_Click(object sender, EventArgs e)
        {       

        } // empty

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Are you sure you want to LogOut?" ,"LogOut", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                User temp = new User();
                foreach (KeyValuePair<int, User> user in User._users)
                {
                    if (Username == user.Value._UserName)
                    {
                       temp = user.Value; break;
                    }
                }
                Login login = new Login();
                Close();
                login.Show();
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            buttonWatchContent.Visible = false;
            buttonFavList.Visible = false;
            buttonRandom.Visible = false;
            buttonSetting.Visible = false;
            buttonBackToMainGenral.Visible = true;
            buttonChangePassword.Visible = true;
            buttonChangeEmail.Visible = true;
            buttonChangeUserName.Visible = true;
            labelheadline.Text = "Settings";
        }

        private void buttonBackToMainGenral_Click(object sender, EventArgs e)
        {
            buttonBackToMainGenral.Visible = false;
            buttonChangePassword.Visible = false;
            buttonChangeEmail.Visible = false;
            buttonChangeUserName.Visible = false;
            buttonWatchContent.Visible = true;
            buttonFavList.Visible = true;
            buttonRandom.Visible = true;
            buttonSetting.Visible = true;
            labelheadline.Text = "Main Menu";
        }

        private void labelheadline_Click(object sender, EventArgs e)
        {

        } // empty
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            panelPassword.Visible = true;
            panelEmail.Visible = false;
            panelUsername.Visible = false;
        }

        private void buttonChangeEmail_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = true;
            panelPassword.Visible = false;
            panelUsername.Visible = false;
        }

        private void buttonChangeUserName_Click(object sender, EventArgs e)
        {
            panelUsername.Visible = true;
            panelPassword.Visible = false;
            panelEmail.Visible = false;
        }

        private void button_backToMain_Click_1(object sender, EventArgs e)
        {
            panelPassword.Visible=false;
            
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBox_password2.UseSystemPasswordChar = true;
                textBox_password1.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_password2.UseSystemPasswordChar = false;
                textBox_password1.UseSystemPasswordChar = false;
            }
        }

        private void textBox_password2_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_password1.Text = string.Empty;
            textBox_password2.Text = string.Empty;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (isPasswordsValid(textBox_password1.Text, textBox_password2.Text))
            {
                UserController.ChangePassword(textBox_password1.Text ,Username);
                MessageBox.Show("Password changed succsfuly");
                panelPassword.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid fields! password must be 7 charecters at least, make sure your password are the same");
            }
        }

        private bool isPasswordsValid(string password1, string password2)
        {
            if (password1.Length < 7 || password1 != password2)
            {
                return false;
            }
            return true;
        }

        private void buttonBackToMainFromEmail_Click(object sender, EventArgs e)
        {
            panelEmail.Visible = false;
        }

        private void buttonClearEmail_Click(object sender, EventArgs e)
        {
            textBoxChangeEmail1.Text = string.Empty;
            textBoxChangeEmail2.Text = string.Empty;
        }

        private void buttonConfirmEmail_Click(object sender, EventArgs e)
        {
           if(textBoxChangeEmail1.Text==textBoxChangeEmail2.Text)
            {
                if (UserController.ChangeEmail(textBoxChangeEmail1.Text, Username))
                {

                    MessageBox.Show("Email changed succsfuly");
                    panelEmail.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid field! email must contain '@gmail.com'");
                }
            }
           else
                MessageBox.Show("Emails are not the same!");

        }

        private void textBoxChangeEmail_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void panelPodcast_Paint(object sender, PaintEventArgs e)
        {

        } // empty

        private void buttonBack_Click(object sender, EventArgs e) // back from podcast
        {
            panelPodcast.Visible = false;
        }

        private void button_series_Click(object sender, EventArgs e)
        {
            panelWatchSeries.Visible = true;
            panelPodcast.Visible = false;
        }

        private void button_movie_Click(object sender, EventArgs e)
        {
            WatchMovies movies = new WatchMovies(Username);
            movies.Show();
            this.Hide();
            panelWatchSeries.Visible =false;
            panelPodcast.Visible = false;
        }

        private void buttonPodcast_Click(object sender, EventArgs e)
        {
            panelPodcast.Visible = true;
            panelWatchSeries.Visible = false;
        }

        private void buttonBackFromMovies_Click(object sender, EventArgs e)
        {
        }

        private void buttonBackFromSeries_Click(object sender, EventArgs e)
        {
        }

        private void panelEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBackFromFav_Click(object sender, EventArgs e)
        {
            panelFavList.Visible=false;
        }

        private void panelFavList_Paint(object sender, PaintEventArgs e)
        {

        } // empty

        private void buttonFavList_Click(object sender, EventArgs e)
        {
            panelFavList.Visible = true;
            panelEmail.Visible = false;
            panelPassword.Visible = false;
            panelPodcast.Visible = false;
            panelWatchSeries.Visible = false;
        }

        private void panelPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonConfirmUsername_Click(object sender, EventArgs e)
        {
            if(textBoxNewUsername.Text == textBoxOldUsername.Text)
                MessageBox.Show(" Old username is the same as the new one");
            else 
            {
                if (UserController.ChangeUserName(textBoxNewUsername.Text, textBoxOldUsername.Text))
                {

                    MessageBox.Show("Username changed succssfuly");
                    panelUsername.Visible = false;
                    Username = textBoxNewUsername.Text;
                    label_hello.Text = "Hello, " + textBoxNewUsername.Text;
                }
            }
        }

        private void buttonClearUsername_Click(object sender, EventArgs e)
        {
            textBoxNewUsername.Text = string.Empty;
            textBoxOldUsername.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUsername.Visible = false;
        }

        private void textBoxOldUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewUsername_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void chromiumWebBrowser1_LoadingStateChanged_1(object sender, LoadingStateChangedEventArgs e)
        {
           // ChromiumWebBrowser browser = new ChromiumWebBrowser("https://youtu.be/8iDt45kWUdI");
           // this.Controls.Add(browser);
           // browser.Dock = DockStyle.Fill;
        }

        private void buttonAddContent_Click(object sender, EventArgs e)
        {
        }

        private void buttonBackFromAddCont_Click(object sender, EventArgs e) //back from add content to main menu
        {
        }

        private void buttonBrowes_Click(object sender, EventArgs e) // browes the content that the user add - not working!
        {
            //ChromiumWebBrowser browser = new ChromiumWebBrowser(textBoxLinkAddCont.Text);
            //chromiumWebBrowserAddCont=browser;
            //this.Controls.Add(chromiumWebBrowserAddCont);
            //chromiumWebBrowserAddCont.Dock = DockStyle.Fill;
        }

        private void buttonSave_Click(object sender, EventArgs e) // save content that user add - need to apply
        {
            //ContentController.addContent(); // need to wrap it like we did in user
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
