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
        public static bool saveUser(User user)
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
        } //save this user via json to file
        public static bool updateUser(int userId,User newUser)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "users.txt");
            bool userUpdated = false;
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                   // User user = JsonSerializer.Deserialize<User>(lines[i]);
                    if (newUser._userId == userId)
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
        public static bool loadUser()
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
        } // load all users using json from file to RAM

        public static bool saveUsersCount()
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
        public static bool getUserCount()
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
        public static User LoadOneUser(string username)
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
        } //load only ONE USER by the givven username - need to check if work!

    }
}
