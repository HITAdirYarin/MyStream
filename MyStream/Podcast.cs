using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class Podcast : Content
    {
        private int _episodeAmount { get; set; }
        private string _host { get; set; }
        private string _guest { get; set; }
        private Dictionary<int, PodcastsEpisode> _episode;

        public Podcast(int contentID, string name, string date,string genre, int episodeAmount, string host, string guest) 
    
        {
            _episode = new Dictionary<int, PodcastsEpisode>();
            _episodeAmount = episodeAmount;
            _host = host;
            _guest = guest;
        }
        public PodcastsEpisode GetEpisode(int numOf)
        {
            return _episode[numOf];
        }
    }
}
