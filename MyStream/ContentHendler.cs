
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
      
        public static void updateMovie(Movies movie) // The function updates moviee's details(useful to update rates and reviews)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "movies.txt");
            string[] lines = File.ReadAllLines(filePath);
            for(int i = 0; i < lines.Length; i++)
            {
                Movies temp = JsonSerializer.Deserialize<Movies>(lines[i]);
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
        } 

        //***************************
        //Series:
        public static bool saveSeries(Series series)
        {
            string json = JsonSerializer.Serialize(series);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "series.txt");
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
                return false;
            }
            return true;
        }
        public static void updateSeries(Series series) // The function updates moviee's details(useful to update rates and reviews)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "series.txt");
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                Series temp = JsonSerializer.Deserialize<Series>(lines[i]);
                if (series._name == temp._name)
                {
                    lines[i] = JsonSerializer.Serialize(series);
                    File.WriteAllLines(filePath, lines);
                    break;
                }
            }
        }
        public static bool loadSeries() // The function loads the series from the file to the program's RAM 
        {
            string dataFile;
            Series a = new Series();
            try
            {
                StreamReader reader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "series.txt"));
                dataFile = reader.ReadLine();
                while (dataFile != null)
                {
                    a = JsonSerializer.Deserialize<Series>(dataFile);
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
        } 
    }
}
