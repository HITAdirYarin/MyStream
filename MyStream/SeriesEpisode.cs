using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class SeriesEpisode
    {
        public int _numOf { get; set; }
        public int _length { get; set; }
        
        public SeriesEpisode()
        {
            _numOf = 0;
            _length = 0;
        }
        public SeriesEpisode(int numOf, int length)
        {
            _numOf = numOf;
            _length = length;
        }
    }
}
