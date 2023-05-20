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
            _director = "no name";
        }

        public Stream(string director)
        {
            _director = director;
        }

    
    }
}
