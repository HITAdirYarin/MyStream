
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MyStream
{
   
    public abstract class ContentHendler
    {
        //****************//
        //Movies:
        public static bool saveMovie(Movies movie) //The function recieve a movie and serialize it
        {
            string json = JsonSerializer.Serialize(movie);
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
        } 
        public static void updateMovie(Content movie) // The function updates moviee's details(useful to update rates and reviews)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "movies.txt");
            string[] lines = File.ReadAllLines(filePath);
            for(int i = 0; i < lines.Length; i++)
            {
                Content temp = JsonSerializer.Deserialize<Content>(lines[i]);
                if (movie._name == temp._name)
                {
                    lines[i] = JsonSerializer.Serialize(movie);
                    File.WriteAllLines(filePath, lines);
                    break;
                }
            }         
        }
        public static  bool loadMovies() // The function loads the movies from the file to the program's RAM 
        {
            string dataFile;
           Movies a = new Movies();
            try
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "movies.txt"));
                dataFile = reader.ReadLine();
                while (dataFile != null)
                {
                    a = JsonSerializer.Deserialize<Movies>(dataFile);
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
        public static void addReview(ContentReviews item) // The function updates the list of the reviews and serialize it
        {
            string json = JsonSerializer.Serialize(item);
            string filePath= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "contentsReviews.txt");
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
                Console.WriteLine("ERROR :" + e.Message);
            }
        }
        public static List<string> loadReview(string name) // The function recieves the name of the movie, and returns list of its reviews
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "contentsReviews.txt");
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                ContentReviews content = JsonSerializer.Deserialize<ContentReviews>(lines[i]);
                if (content._name == name)
                {
                    return content._review;
                }
            }
            return null;
        }
        //***************************
    }
}
