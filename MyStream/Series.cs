using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace MyStream
{
    public class Series: Stream
    {
        // Data Members
        public int _episodeAmount { get; set; }
        public List<string> _episodes { get; set; }

        // Methods
        public Series() // basic constructor
        {
            _name = "no name";
            _episodeAmount = 0;
            _date = "no date";
            _genre = "no genre";
            _type = "no type";
            _rateCount = 0;
            _rateAvg = 0;
            _episodes = new List<string>();
            _review = new List<string>();
            _review.Add("no reviews");
        }
        public Series(string name, int episodeAmount,string date,string genre,string type,int rateCount,int rateAvg) // advanced constructor
        {
            _name = name;
            _episodeAmount = episodeAmount;
            _date = date;
            _genre = genre;
            _type = type;
            _rateCount = rateCount;
            _rateAvg = rateAvg;
            _episodes = new List<string>();
            _review.Add("no reviews");
        }
    }
}
