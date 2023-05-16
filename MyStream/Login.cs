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
        public Login()
        {
            InitializeComponent();
        }

        private void headline_Click(object sender, EventArgs e)
        {

        } // empty

        private void label1_Click(object sender, EventArgs e)
        {

        } // empty

        private void forms_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        } // empty

        private void signup_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            
        }

        private void SignIn_Click(object sender, EventArgs e)
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

        public bool isValidUser(string email, string password)
        {
            foreach (KeyValuePair<int, User> item in User._users)
            {
                if (item.Value._Email == email_text.Text && item.Value._Password == password_text.Text)
                {
                    return true;
                }

            }
            return false;
        } // check if user is valid

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void email_text_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.Checked) 
            {
                password_text.UseSystemPasswordChar = true;
            }
            else
                password_text.UseSystemPasswordChar = false;
        } // check if to show password or not

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void textBox_password1_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void textBox_password2_TextChanged(object sender, EventArgs e)
        {

        } // empty

        private void checkBoxShowPasswordRegist_CheckedChanged(object sender, EventArgs e)
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

        private void button_register_Click(object sender, EventArgs e)
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

        public bool isUserExist(string email, string username)
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

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_username.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_password1.Text = string.Empty;
            textBox_password2.Text = string.Empty;
        }

        private void button_backToLogin_Click(object sender, EventArgs e)
        {
           panelRegister.Visible = false;
          
        }
    }
}
