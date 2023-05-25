using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStream
{
    public class UserController
    {
        public static bool register(string userName, string email,string password)
        {
            User a = new User();
           if(!a.Register(userName,email, password))
            {
                return false;
            }
            if (!UserHendler.saveUser(a))
            {
                return false;
            }
            User._users.Add(a._userId, a);
            return true;
        }
        public static void deleteUser(string userName)
        {
            UserHendler.deleteUser(userName);
        }
        public static bool ChangePassword(string password , string username) 
        {
            return User.ChangePassword(password, username);
            
        }
        public static bool ChangeUserName(string newUserName,string oldUserName)
        {
            if (!User.isUserNameValid(newUserName))
            {
                return false;
            }
            return User.ChangeUsername(newUserName, oldUserName);
        }
        public static bool ChangeEmail(string email,string userName)
        {
            if(!User.IsValidGmailAddress(email))
            {
                return false;
            }
            return User.ChangeEmail(email, userName);

        }
    }
}
