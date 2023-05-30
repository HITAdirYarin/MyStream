using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace MyStream
{
    public abstract class UserHendler
    {
        public static bool saveUser(User user) // The function recieve a new user and serialize it
        {
            string json = JsonSerializer.Serialize(user);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine(json);
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERORR: " + e);
                return false;
            }
            return true;
        } 
        public static bool updateUser(User newUser) //The function update a user's details and serialize it
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.txt");
            bool userUpdated = false;
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    User temp = JsonSerializer.Deserialize<User>(lines[i]);
                    if (newUser._userId == temp._userId)
                    {                     
                        lines[i]= JsonSerializer.Serialize(newUser);
                        File.WriteAllLines(filePath, lines);
                        userUpdated = true;
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("ERORR: " + e);
                return false;
            }
            return userUpdated;
        }
        public static bool loadUser() // The function loads all users from file to RAM
        {
            string dataFile;
            User a = new User();
            try
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.txt"));
                dataFile = reader.ReadLine();
                while (dataFile != null)
                {
                    a = JsonSerializer.Deserialize<User>(dataFile);
                    User._users.Add(a._userId, a);
                    dataFile = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERORR: " + e);
                return false;

            }
            return true;
        }
        public static void deleteUser(string userName) // deleting a user from the file by Deserialize
        {
            int userId;
            foreach (KeyValuePair<int, User> user in User._users)
            {
                if (userName == user.Value._UserName)
                {
                    User._users.Remove(user.Value._userId);
                    break;
                }
            }
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.txt");
            string[] lines = File.ReadAllLines(filePath);
            List<string> linesList = new List<string>();
            for(int i = 0; i < lines.Length; i++)
            {
                linesList.Add(lines[i]);
            }
            User temp = new User();
            for (int i = 0; i < linesList.Count; i++)
            {
                temp = JsonSerializer.Deserialize < User>(linesList[i]);
                if (temp._UserName==userName)
                {
                    linesList.Remove(linesList[i]);
                    File.WriteAllLines(filePath,linesList);
                    break;
                }
            }
        }
        public static bool saveUsersCount() // The function saves the number of users that exist (useful to give a new user an appropriate id number)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "numOfUsers.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(User._countUsers);
                    writer.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool getUserCount() // The function returns the number of users that exist
        {
            try
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "numOfUsers.txt"));
                string line = reader.ReadLine();
                User._countUsers = int.Parse(line);
                reader.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static User LoadOneUser(string username) // The function recieves a username and return the appropriate User
        {
            string dataFile;
            User a = new User();
            try 
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.txt"));
                dataFile = reader.ReadLine();
                foreach (KeyValuePair<int, User> user in User._users)
                {
                    if (username == user.Value._UserName)
                    {
                        a = user.Value;
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : " + e.Message);
                return null;

            }
            return a;
        } 

    }
}
