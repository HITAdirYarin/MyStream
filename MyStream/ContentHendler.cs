
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MyStream
{
   
    public abstract class ContentHendler
    {
        public static bool saveMovie(Content content)
        {
            string json = JsonSerializer.Serialize(content);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "movies.txt");
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
        } // save this content via json to file"
        public static void updateMovie(string name,Content movie)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "movies.txt");
            string[] lines = File.ReadAllLines(filePath);
            for(int i = 0; i < lines.Length; i++)
            {         
                if (movie._name == name)
                {
                    lines[i] = JsonSerializer.Serialize(movie);
                    File.WriteAllLines(filePath, lines);
                    break;
                }
            }         
        }
        public static  bool loadMovies()
        {
            string dataFile;
            Content a = new Movies();
            try
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "movies.txt"));
                dataFile = reader.ReadLine();
                while (dataFile != null)
                {
                    a = JsonSerializer.Deserialize<Content>(dataFile);
                    Content._contents.Add(a._name, a);
                    dataFile = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR : " + e.Message);
                return false;

            }
            return true;
        } // load all contents using json from fils to RAM
    }
}
