using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class MoviesParts
    {
        public int _numOfPart { get; set; }
        public int _length { get; set;}

        public MoviesParts()
        {
            _numOfPart = 0; 
            _length = 0;
        }
        public MoviesParts(int numOfPart, int length)
        {
            _numOfPart = numOfPart;
            _length = length;
        }
    }
}
