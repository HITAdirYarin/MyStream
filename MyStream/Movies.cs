using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class Movies : Stream
    {
        private Dictionary<int,MoviesParts > _part;

        public Movies() 
        {
            _part = new Dictionary<int, MoviesParts>();
        }

        public MoviesParts GetMovie(int numOfPart)
        {
            return _part[numOfPart];
        }
    }
}
