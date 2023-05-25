using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class Movies : Stream 
    {
        public string _path { get; set; }
        public Movies()
        {
            _name = "no name";
            _path = "no path";
            _director = "no director";
            _date = "no date";
            _genre = "no genre";
            _type = "no type";
            _rateCount = 0;
            _rateAvg = 0;
            _review = new List<string>();
            _review.Add("no reviews");
        }
       public Movies(string name, string path,string director, string date, string genre, string type,int rateCount,double rate)
        {
            _name = name;
            _path = path;
            _director = director;
            _date = date;
            _genre = genre;
            _type = type;
            _rateCount = rateCount;
            _rateAvg = rate;
            _review = new List<string>();
            _review.Add("no reviews");
        }
    }
}
