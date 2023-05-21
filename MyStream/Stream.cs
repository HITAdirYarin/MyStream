using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public abstract class Stream : Content
    {
        //data members
        public string _director { get; set; }

        //methods
        public Stream() 
        {
            _name = "no name";
            _path = "no path";
            _director = "no director";
            _date = "no date";
            _genre = "no genre";
            _type = "no type";
            _rateCount = 0;
            _rateAvg = 0;
        }

        public Stream(string director)
        {
            _director = director;
        }

    
    }
}
