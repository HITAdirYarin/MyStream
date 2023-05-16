using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class Series
    {
        // Data Members
        public int _episodeAmount { get; set; }
        private Dictionary<int, SeriesEpisode> _episode;

        // Methods

        public Series(int episodeAmount)
        {
            _episodeAmount = episodeAmount;
            _episode = new Dictionary<int, SeriesEpisode>();
        }
    }
}
