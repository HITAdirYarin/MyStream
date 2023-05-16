
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyStream
{
   
    public abstract class ContentHendler
    {
        public static bool saveContent(Content content)
        {
            string json = JsonSerializer.Serialize(content);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "contents.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath,append: true))
                {
                    writer.WriteLine(json);
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR :" + e.Message);
                return false;
            }  
            return true;
        } // save this content via json to file
        public static  bool loadContents()
        {
            string dataFile;
            Content a = new Content();
            try
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "contents.txt"));
                dataFile = reader.ReadLine();
                while (dataFile != null)
                {
                    a = JsonSerializer.Deserialize<Content>(dataFile);
                    Content._contents.Add(a._contentID, a);
                    dataFile = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : " + e.Message);
                return false;

            }
            foreach(KeyValuePair<int, Content> item in Content._contents)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Name: " + item.Value._name);
                Console.WriteLine("Released on: " + item.Value._date);
                Console.WriteLine("Genre: " + item.Value._genre);
                Console.WriteLine("*******************");
            }
            return true;
        } // load all contents using json from fils to RAM
    }
}
