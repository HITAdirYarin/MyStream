
using CefSharp.DevTools.CSS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyStream
{
    public  class Content
    {
        // Data members
        public string _name { get; set; }
        public string _path { get; set; }
        public string _date { get; set; }
        public string _genre { get; set; }
        public string _type { get; set; }
        public double _rateAvg { get; set; }
        public int _rateCount { get; set; }
        public List<String> _review { get; set; } 

        //Static
        public static Dictionary<string, Content> _contents = new Dictionary<string, Content>();

        // Methods
        public Content()
        {
            _name = "no name";
            _path = "no path";
            _date = "no date";
            _genre = "no genre";
            _type = "no type";
            _rateCount = 0;
            _rateAvg = 0;
            _review = new List<string>();
        }
        public Content( string name,string path, string date,string genre,string type,int rateCount,double rate)
        {
            _name = name;
            _path = path;         
            _date = date;
            _genre = genre;
            _type = type;
            _rateCount = rateCount;
            _rateAvg = rate;
        }

        public void addReview(string review)
        {
            _review.Add(review);          
        }
      
        public static void addRate(int rate,string name)
        {
            double sum;
            foreach (KeyValuePair<string, Content> content in Content._contents)
            {
                if (content.Value._name == name)
                {
                    sum = content.Value._rateAvg * content.Value._rateCount;
                    sum += rate;
                    content.Value._rateCount++;
                    content.Value._rateAvg = getAvgRate(sum, content.Value._rateCount);
                    ContentHendler.updateMovie( content.Value);
                    break;
                }
            }
        }
        public static double getAvgRate(double rate_sum,int amount)
        {
            return rate_sum / amount;
        }
    }
}
