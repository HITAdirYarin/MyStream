using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public partial class Login : Form
    {
        public Login() //basic constructor
        {
            InitializeComponent();
        }
        private void forms_Load(object sender, EventArgs e) // load login form
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void signup_Click(object sender, EventArgs e) // show the panel for the signup
        {
            panelRegister.Visible = true;
            
        }
        private void SignIn_Click(object sender, EventArgs e) //log the user in
        {
            if (isValidUser(email_text.Text, password_text.Text))
            {
                User user = User.getUserByEmail(email_text.Text);
                string username = user._UserName;
                Main main = new Main(username);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        public bool isValidUser(string email, string password) //check if the user is valid
        {
            foreach (KeyValuePair<int, User> item in User._users)
            {
                if (item.Value._Email == email_text.Text && item.Value._Password == password_text.Text)
                {
                    return true;
                }

            }
            return false;
        } 
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked) 
            {
                password_text.UseSystemPasswordChar = true;
            }
            else
                password_text.UseSystemPasswordChar = false;
        } // check if to show password or not
        private void checkBoxShowPasswordRegist_CheckedChanged(object sender, EventArgs e) // check if to show password or not
        {
            if (checkBoxShowPasswordRegist.Checked)
            {
                textBox_password1.UseSystemPasswordChar = true;
                textBox_password2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_password1.UseSystemPasswordChar = false;
                textBox_password2.UseSystemPasswordChar = false;
            }
        }

        private void button_register_Click(object sender, EventArgs e) // check if can register and then bring the user to login again 
        {
            if (User.isPasswordsValid(textBox_password1.Text, textBox_password2.Text) && User.IsValidGmailAddress(textBox_email.Text)
                && User.isUserNameValid(textBox_username.Text))
            {
                if (isUserExist(textBox_email.Text, textBox_username.Text))
                {
                    MessageBox.Show("Email or password are already taken, please enter new one.");
                }
                else
                {
                    UserController.register(textBox_username.Text, textBox_email.Text, textBox_password1.Text);
                    Login login = new Login();
                    MessageBox.Show("Register succsfuly ! Please login");
                    login.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid fields! password must be 7 charecters at least,email must contain '@gmail.com' ," +
                    " and user name must be 6 charecters at list");
            }
        }

        public bool isUserExist(string email, string username) // checks if the user exist in the system
        {
            foreach (KeyValuePair<int, User> item in User._users)
            {
                if (item.Value._Email == email || item.Value._UserName == username)
                {
                    return true;
                }

            }
            return false;
        }

        private void button_clear_Click(object sender, EventArgs e) //clear user info that he wrote
        {
            textBox_username.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_password1.Text = string.Empty;
            textBox_password2.Text = string.Empty;
        }

        private void button_backToLogin_Click(object sender, EventArgs e) // back to login , close this panel
        {
           panelRegister.Visible = false;
          
        }
    }
}
