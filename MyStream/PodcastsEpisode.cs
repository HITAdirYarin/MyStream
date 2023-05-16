using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class PodcastsEpisode
    {
        public int _numOf { get; set; }
        public int _length { get; set; }

        public PodcastsEpisode()
        {
            _numOf = 0;
            _length = 0;
        }
        public PodcastsEpisode(int numOf, int length)
        {
            _numOf = numOf;
            _length = length;
        }
    }
    
}
