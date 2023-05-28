using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class Podcast : Content
    {
        public string _host { get; set; }
        public string _guest { get; set; }
        public string _path { get; set; }
       
        public Podcast()
        {
            _host = "no host";
            _guest = "no guest";
            _path = "no path";
            _review.Add("no reviews");
        }
        public Podcast(string name,string path, string date,string host, string guest, string genre,string type)     
        {
            _name = name;
            _path = path;
            _date = date;
            _host=host;
            _guest = guest;
            _genre = genre;
            _type = type;
            _review.Add("no reviews");
        }
      
    }
}
