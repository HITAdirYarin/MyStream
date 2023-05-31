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
        public static int count = 0;
        public Main() // basic constructor
        {
            InitializeComponent();
           
        }

        public Main(string username) // advanced constructor
        {
            this.WindowState = FormWindowState.Maximized; // set full screen
            Username = username;
            InitializeComponent();
            label_hello.Text = "Hello, " + Username;
        }

        private void buttonWatchContent_Click(object sender, EventArgs e) // open the options for watching content in main form
        {
            count = 0;
            panelFavList.Visible = false;
            listViewFav.Clear();
            button_movie.Visible = true;
            button_series.Visible = true;
            buttonPodcast.Visible = true;
            button_backToMain_content.Visible = true;
            buttonFavList.Visible = false;
            buttonRandom.Visible = false;
        }

        private void button_backToMain_Click(object sender, EventArgs e) // close the options for watching content in main form
        {
            button_movie.Visible = false;
            button_series.Visible = false;
            buttonPodcast.Visible = false;
            button_backToMain_content.Visible = false;
            buttonFavList.Visible = true;
            buttonRandom.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e) // returns the user back to login form
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

        private void buttonSetting_Click(object sender, EventArgs e) // open the options to adjust setting
        {
            buttonWatchContent.Visible = false;
            buttonFavList.Visible = false;
            buttonRandom.Visible = false;
            buttonSetting.Visible = false;
            buttonBackToMainGenral.Visible = true;
            buttonChangePassword.Visible = true;
            buttonChangeEmail.Visible = true;
            buttonChangeUserName.Visible = true;
            buttonDeleteUser.Visible = true;
            labelheadline.Text = "Settings";
        }

        private void buttonBackToMainGenral_Click(object sender, EventArgs e) // close the options to adjust setting
        {
            buttonBackToMainGenral.Visible = false;
            buttonChangePassword.Visible = false;
            buttonChangeEmail.Visible = false;
            buttonChangeUserName.Visible = false;
            buttonDeleteUser.Visible = false;
            buttonWatchContent.Visible = true;
            buttonFavList.Visible = true;
            buttonRandom.Visible = true;
            buttonSetting.Visible = true;
            labelheadline.Text = "Main Menu";
        }
        private void buttonChangePassword_Click(object sender, EventArgs e) // open the panel to change password
        {
            panelPassword.Visible = true;
            panelEmail.Visible = false;
            panelUsername.Visible = false;
            panelDeleteUser.Visible = false;
            panelFavList.Visible = false;
        }

        private void buttonChangeEmail_Click(object sender, EventArgs e) // open the panel to change Email
        {
            panelEmail.Visible = true;
            panelPassword.Visible = false;
            panelUsername.Visible = false;
            panelDeleteUser.Visible = false;
            panelFavList.Visible = false;
        }

        private void buttonChangeUserName_Click(object sender, EventArgs e) // open the panel to change username
        {
            panelUsername.Visible = true;
            panelPassword.Visible = false;
            panelEmail.Visible = false;
            panelDeleteUser.Visible = false;
            panelFavList.Visible = false;
        }

        private void button_backToMain_Click_1(object sender, EventArgs e) // close change password panel
        {
            panelPassword.Visible=false;
            
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e) //checks if the password are the same
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

        private void button_clear_Click(object sender, EventArgs e) // clear the text user wrote
        {
            textBox_password1.Text = string.Empty;
            textBox_password2.Text = string.Empty;
        }

        private void button_Confirm_Click(object sender, EventArgs e) // confirm and save the password change
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

        private bool isPasswordsValid(string password1, string password2) // check if the password is valid
        {
            if (password1.Length < 7 || password1 != password2)
            {
                return false;
            }
            return true;
        }

        private void buttonBackToMainFromEmail_Click(object sender, EventArgs e) // close change Email panel
        {
            panelEmail.Visible = false;
        }

        private void buttonClearEmail_Click(object sender, EventArgs e) // clear the text user wrote
        {
            textBoxChangeEmail1.Text = string.Empty;
            textBoxChangeEmail2.Text = string.Empty;
        }

        private void buttonConfirmEmail_Click(object sender, EventArgs e) // confirm and save the Email change
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

        private void button_series_Click(object sender, EventArgs e) // get the user to watchseries form
        {
            WatchSeries series = new WatchSeries(Username);
            series.Show();
            this.Hide();
        }

        private void button_movie_Click(object sender, EventArgs e) // get the user to watchmovie form
        {
            WatchMovies movies = new WatchMovies(Username);
            movies.Show();
            this.Hide();
           
        }

        private void buttonPodcast_Click(object sender, EventArgs e) // get the user to watchpodcast form
        {
            ListenPodcast podcast = new ListenPodcast(Username);
            podcast.Show();
            this.Hide();
        }

        private void buttonBackFromFav_Click(object sender, EventArgs e) // close change fav panel
        {
            count = 0;
            panelFavList.Visible=false;
            listViewFav.Clear();
        }

        private void buttonFavList_Click(object sender, EventArgs e) // open change fav panel , and load the listView with the liked content
        {
            count++;
            if (count == 1)
            {
                panelFavList.Visible = true;
                panelEmail.Visible = false;
                panelPassword.Visible = false;
                panelDeleteUser.Visible = false;
                panelUsername.Visible = false;

                foreach (KeyValuePair<int, User> user in User._users)
                {
                    if (user.Value._UserName == Username)
                    {
                        foreach (string fav in user.Value._fav)
                        {
                            listViewFav.Items.Add(fav);
                        }
                        break;
                    }
                }
            }
        }

        private void buttonConfirmUsername_Click(object sender, EventArgs e) // confirm change username 
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
                    textBoxNewUsername.Text = string.Empty;
                    textBoxOldUsername.Text = string.Empty;
                }
            }
        }

        private void buttonClearUsername_Click(object sender, EventArgs e) // clear the text user wrote
        {
            textBoxNewUsername.Text = string.Empty;
            textBoxOldUsername.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e) // open change username panel
        {
            panelUsername.Visible = false;
        }

        private void buttonClearDelete_Click(object sender, EventArgs e) // clear the text user wrote
        {
            textBoxPassword_delete.Text = string.Empty;
            textBoxUsername_delete.Text = string.Empty;
        }

        private void buttonConfirmDelete_Click(object sender, EventArgs e) // confirm delete user
        {
            bool verify = false;
            foreach(KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._UserName == Username)
                {
                    if (textBoxPassword_delete.Text == user.Value._Password && textBoxUsername_delete.Text==user.Value._UserName)
                    {
                        verify = true;                      
                    }
                    break;
                }
            }
            if (!verify)
            {
                MessageBox.Show("Invalid password or username");
            }
            else
            {
                DialogResult a = MessageBox.Show("Are you sure you want to Delete your User?\nall of your file will be lost", "DeleteUser", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    UserController.deleteUser(textBoxUsername_delete.Text);
                    MessageBox.Show("User deleted succssfuly");
                    panelDeleteUser.Visible = false;
                    textBoxPassword_delete.Text = string.Empty;
                    textBoxUsername_delete.Text = string.Empty;
                    Login login = new Login();
                    Close();
                    login.Show();
                }
            }
        }

        private void buttonCloseDelete_Click(object sender, EventArgs e) // close delete user panel
        {
            panelDeleteUser.Visible=false;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e) // open delete user panel
        {
            panelDeleteUser.Visible = true;
            panelPassword.Visible = false;
            panelEmail.Visible = false;
            panelUsername.Visible = false;
            panelFavList.Visible = false;
        }

        private void buttonRandom_Click(object sender, EventArgs e) // activated the random steam 
        {
            count = 0;
            panelFavList.Visible = false;
            listViewFav.Clear();
            string[] content = new string[14];
            int i = 0;
            foreach (KeyValuePair<string, Content> item in Content._contents)
            {
                if (item.Value._type != "podcast")
                {
                    content[i++] = item.Value._name;
                }
            }
            Random random = new Random();
            int randomIndex = random.Next(0, 14);
            Content chosen = Content._contents[content[randomIndex]];
            if (chosen._type == "movie") {
                SurpriseMe Random = new SurpriseMe(Username,chosen._name, "YouTubeMovies", chosen._name+".mp4");
                Random.Show();
                this.Hide();
            }
            else
            {
                Series series = chosen as Series;
                randomIndex = random.Next(series._episodeAmount);
                SurpriseMe Random = new SurpriseMe(Username, series._name, series._name, series._episodes[randomIndex]);
                Random.Show();
                this.Hide();
            }

             
        }

        private void removeFav_Click(object sender, EventArgs e) // open a mini panel that allow the user to remove content frmfavorite list
        {
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._UserName == Username)
                {
                    comboBoxPickContentToDel.Items.AddRange(user.Value._fav.ToArray());
                    break;
                }
            }
            labelAddToFav.Visible = true;
            labelChooseContent.Visible = true;
            comboBoxPickContentToDel.Visible = true;
            buttonConfirmDel.Visible = true;
            buttonCloseDelMiniPanel.Visible = true;
        }

        private void buttonCloseDelMiniPanel_Click(object sender, EventArgs e) // close the mini panel 
        {
            labelAddToFav.Visible = false;
            labelChooseContent.Visible = false;
            comboBoxPickContentToDel.Visible = false;
            buttonConfirmDel.Visible = false;
            buttonCloseDelMiniPanel.Visible = false;
            comboBoxPickContentToDel.SelectedIndex = -1;
            comboBoxPickContentToDel.Items.Clear();
        }

        private void buttonConfirmDel_Click(object sender, EventArgs e) // confirm the delete of the content from favorite list
        {
            ContentController.removeFav(Username, comboBoxPickContentToDel.Text);
            MessageBox.Show("The content has been deleted from your list");
            labelAddToFav.Visible = false;
            labelChooseContent.Visible = false;
            comboBoxPickContentToDel.Visible = false;
            buttonConfirmDel.Visible = false;
            buttonCloseDelMiniPanel.Visible = false;
            comboBoxPickContentToDel.SelectedIndex = -1;
            comboBoxPickContentToDel.Items.Clear();
            listViewFav.Items.Clear();
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._UserName == Username)
                {
                    foreach (string fav in user.Value._fav)
                    {
                        listViewFav.Items.Add(fav);
                    }
                    break;
                }
            }
        }
    }
}
