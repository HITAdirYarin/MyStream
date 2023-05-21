
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
            Movies a = new Movies("Fast and Furious 9", "Fast and Furious 9.mp4","Rob Cohen", "25/06/2021", "Action", "movie",0,0);
            ContentHendler.saveMovie(a);
            Movies b = new Movies("Ted", "Ted.mp4", "Seth MacFarlane", "09/08/2012", "Comedy", "movie",0, 0);
            ContentHendler.saveMovie(b);
            Movies c = new Movies("300", "300.mp4", "Zack Snyder", "09/03/2007", "Action", "movie", 0, 0);
            ContentHendler.saveMovie(c);
            Movies d = new Movies("Frozen", "Frozen.mp4","Jennifer Lee", "28/11/2013", "Family", "movie", 0, 0);
            ContentHendler.saveMovie(d);
            Movies e = new Movies("Friends with Benefits", "Will Gluck", "friendswithbenefits.mp4", "10/06/2012", "Comedy", "movie", 0, 0);
            ContentHendler.saveMovie(e);
            Movies f = new Movies("Titanic", "Titanic.mp4", "James Cameron", "09/01/1997", "Drama", "movie", 0, 0);
            ContentHendler.saveMovie(f);
            Movies g = new Movies("SpongeBob", "SpongeBob.mp4", "Stephen Hillenburg", "30/08/2011", "Family", "movie", 0, 0);
            ContentHendler.saveMovie(g);
            Movies h = new Movies("Shrek", "Shrek.mp4","Vicky Jenson", "09/11/2012", "Family", "movie", 0, 0);
            ContentHendler.saveMovie(h);
            Movies i = new Movies("21 Jump street", "JumpStreet.mp4","Phil Lord", "19/03/2010", "Comedy", "movie", 0, 0);
            ContentHendler.saveMovie(i);
            Movies j= new Movies("The godfather", "TheGodfather.mp4", "Francis Ford Coppola", "14/02/2000", "Action", "movie", 0, 0);
            ContentHendler.saveMovie(j);
        }
        public static void addRate(int choose,string name)
        {
            Content.addRate(choose, name);
        }
        public static void addReviews(string name,string review)
        {
            Content a = Content._contents[name];
            if (a._review[0] == "no reviews")
            {
                a._review[0] = review;
            }
            else
            {
                a.addReview(review);
            }
            ContentHendler.updateMovie( a);
        }
    }
}
