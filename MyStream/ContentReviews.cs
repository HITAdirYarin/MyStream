using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
   public class ContentReviews
    {
        public string _name { get; set; }
        public List<String> _review { get; set; }

        public ContentReviews(string name) 
        {
            _name = name;
            _review = new List<string>();
        }
 
    }
  

}
