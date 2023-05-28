
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class ContentController
    {
        public static void addMovies()
        {
            Movies a = new Movies("Fast and Furious 9", "Fast and Furious 9.mp4", "Rob Cohen", "25/06/2021", "Action", "movie", 0, 0);
            ContentHendler.saveMovie(a);
            Movies b = new Movies("Ted", "Ted.mp4", "Seth MacFarlane", "09/08/2012", "Comedy", "movie", 0, 0);
            ContentHendler.saveMovie(b);
            Movies c = new Movies("300", "300.mp4", "Zack Snyder", "09/03/2007", "Action", "movie", 0, 0);
            ContentHendler.saveMovie(c);
            Movies d = new Movies("Frozen", "Frozen.mp4", "Jennifer Lee", "28/11/2013", "Family", "movie", 0, 0);
            ContentHendler.saveMovie(d);
            Movies e = new Movies("Friends with Benefits", "Friends with Benefits.mp4", "Will Gluck", "10/06/2012", "Comedy", "movie", 0, 0);
            ContentHendler.saveMovie(e);
            Movies f = new Movies("Titanic", "Titanic.mp4", "James Cameron", "09/01/1997", "Drama", "movie", 0, 0);
            ContentHendler.saveMovie(f);
            Movies h = new Movies("Shrek", "Shrek.mp4", "Vicky Jenson", "09/11/2012", "Family", "movie", 0, 0);
            ContentHendler.saveMovie(h);
            Movies i = new Movies("21 Jump street", "Jump Street.mp4", "Phil Lord", "19/03/2010", "Comedy", "movie", 0, 0);
            ContentHendler.saveMovie(i);
            Movies j = new Movies("The Godfather", "The Godfather.mp4", "Francis Ford Coppola", "14/02/2000", "Action", "movie", 0, 0);
            ContentHendler.saveMovie(j);
        }
        public static void addSeries()
        {
            Series a = new Series("Avatar", 3, "20/06/2007", "family", "series", 0, 0);
            a._episodes.Add("Episode_1.mp4");
            a._episodes.Add("Episode_2.mp4");
            a._episodes.Add("Episode_3.mp4");
            ContentHendler.saveSeries(a);
            a = new Series("Bridgerton", 3, "30/3/2010", "drama", "series", 0, 0);
            a._episodes.Add("Episode_1.mp4");
            a._episodes.Add("Episode_2.mp4");
            a._episodes.Add("Episode_3.mp4");
            ContentHendler.saveSeries(a);
            a = new Series("Brooklyn 99", 5, "12/05/2013", "comedy", "series", 0, 0);
            a._episodes.Add("Episode_1.mp4");
            a._episodes.Add("Episode_2.mp4");
            a._episodes.Add("Episode_3.mp4");
            a._episodes.Add("Episode_4.mp4");
            a._episodes.Add("Episode_5.mp4");
            ContentHendler.saveSeries(a);
            a = new Series("The Walking Dead", 3, "1/07/2015", "horror", "series", 0, 0);
            a._episodes.Add("Episode_1.mp4");
            a._episodes.Add("Episode_2.mp4");
            a._episodes.Add("Episode_3.mp4");
            ContentHendler.saveSeries(a);
            a = new Series("Vikings", 4, "4/04/2012", "action", "series", 0, 0);
            a._episodes.Add("Episode_1.mp4");
            a._episodes.Add("Episode_2.mp4");
            a._episodes.Add("Episode_3.mp4");
            a._episodes.Add("Episode_4.mp4");
            ContentHendler.saveSeries(a);
        }
        public static void addPodcasts()
        {
            Podcast a = new Podcast("Android Over Iphone", "Android Over Iphone.mp3", "23/11/2022", "Ben simany", "Gal touti", "Technology","podcast");
            ContentHendler.savePod(a);
            a = new Podcast("Deep Web", "Deep Web.mp3", "13/07/2021", "Tal golan", "Nili ezra", "Technology", "podcast");
            ContentHendler.savePod(a);
            a = new Podcast("Harsh Reality Of Dating", "Harsh Reality Of Dating.mp3", "30/07/2019", "David levi", "Bat-sheva levi", "Life", "podcast");
            ContentHendler.savePod(a);
            a = new Podcast("Reason ipads With USB-C", "Reason ipads With USB-C.mp3", "19/05/2018", "Adir kandabi", "Yarin ozeri", "Technology", "podcast");
            ContentHendler.savePod(a);
            a = new Podcast("What Do Girls Want From Men", "What Do Girls Want From Men.mp3", "19/01/2015", "Lior morali", "Omer levi", "Technology", "podcast");
            ContentHendler.savePod(a);

        }
        public static void addRate(int choose, string name)
        {
            Content.addRate(choose, name);
        }
        public static void addMovieReviews(string name, string review)
        {
            Movies a = Content._contents[name] as Movies;
            if (a._review[0] == "no reviews")
            {
                a._review[0] = review;
            }
            else
            {
                a.addReview(review);
            }
            ContentHendler.updateMovie(a);
        }
        public static void addSeriesReviews(string name, string review)
        {
            Series a = Content._contents[name] as Series;
            if (a._review[0] == "no reviews")
            {
                a._review[0] = review;
            }
            else
            {
                a.addReview(review);
            }
            ContentHendler.updateSeries(a);
        }
    }
}
