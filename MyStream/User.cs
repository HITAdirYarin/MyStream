using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyStream
{
    public class User
    {
        public int _userId { get; set; }
        public string _UserName { get; set; }
        public string _Email { get; set; }
        public string _Password { get; set; }
        public static int _countUsers = 1;

        public List<string> _fav { get; set; }
        public List<string> _rates { get; set; }
        public static Dictionary<int,User> _users = new Dictionary<int,User>();
        

        public User()
        {
            _userId = 0;
            _UserName = "none";
            _Email = "none";
            _Password = "none";
            _rates= new List<string>(); 
            _fav = new List<string>();
        }
        public User(string userName, string email, string password)
        {
            _UserName = userName;
            _Email = email;
            _Password = password;
            _rates = new List<string>();
            _fav = new List<string>();
        }

        public void SetValues(string userName, string email, string password) // set values for the constructor
        {
            _UserName = userName;
            _Email = email;
            _Password = password;
        }
        public bool Register(string userName, string email, string password) // define the user id, and call setValues
        {
            this._userId = _countUsers;
            _countUsers++;
            UserHendler.saveUsersCount();
            SetValues(userName, email, password);
            return true;
        }

        public static bool ChangePassword(string password,string username) // change password and seriliaze the update user
        {
            int userId;
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._UserName == username)
                {
                    user.Value._Password = password;
                    userId = user.Value._userId;
                    User newUser = user.Value;
                    if (UserHendler.updateUser(userId, newUser))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool IsValidGmailAddress(string email) //checks if the given email is Gmail account
        {
            string temp = email;
            if(temp.Length>=email.Length && temp.Substring(temp.Length-10) == "@gmail.com"){
                return true;
            }
            else
            {
                return false;
            }

        }
       public static bool isPasswordsValid(string password1, string password2) //checks if passwords are valid and are both the same
        {
            if (password1.Length < 7 || password1 != password2)
            {
                return false;
            }
            return true;
        }
        public static  bool isUserNameValid(string userName ) //checks if the user name is valid
        {
            return userName.Length >= 6;
        }
        public static bool ChangeEmail(string email, string username) // change email and seriliaze the update user
        {
            int userId;
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._UserName == username)
                {
                    user.Value._Email = email;
                   userId=user.Value._userId;
                    User newUser = user.Value;
                    if (UserHendler.updateUser( userId,newUser))
                    {
                        return true;  
                    }                 
                }
            }
            return false;
            

        }
        public static User getUserByEmail(string email) // receive an email address and returns its user
        {
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._Email == email)
                {
                    return user.Value;
                }
            }
            return null;
        }
          
        public static bool ChangeUsername(string newUserName,string oldUserName) // change usrname and seriliaze the update user
        {
            int userId;
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (user.Value._UserName == oldUserName)
                {
                    user.Value._UserName = newUserName;
                    userId = user.Value._userId;
                    User newUser = user.Value;
                    if (UserHendler.updateUser(userId, newUser))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
