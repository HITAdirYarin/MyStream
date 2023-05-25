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
        public string _director { get; set; }

        //methods
        public Stream() 
        {
            _name = "no name";
            _date = "no date";
            _genre = "no genre";
            _type = "no type";
            _rateCount = 0;
            _rateAvg = 0;
        }

   

    
    }
}
