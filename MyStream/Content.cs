
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyStream
{
    public  class Content
    {
        // Data members
        public int _contentID { get; set; }
        public string _name { get; set; }
        public string _date { get; set; }
        public string _genre { get; set; }
        public string _type { get; set; }
        protected string _summary;
        protected int _rateSum;
        protected int _rateCount;
        protected List<String> _opinion;

        //Static
        public static Dictionary<int, Content> _contents = new Dictionary<int, Content>();

     // Methods
       public Content()
        {
            _contentID = 0;
            _name = "no name";
            _date = "no date";
            _genre = "no genre";
            _type = "no type";
        }
        public Content(int contentID, string name, string date,string genre,string type)
        {
            _contentID = contentID;
            _name = name;
            _date = date;
            _genre = genre;
            _type = type;
            _rateCount = 0;
            _rateSum = 0;
            _opinion = new List <String>();
        }

        public void writeOpinion()
        {
            string input = Console.ReadLine();
            _opinion.Add(input);
           
        }
        public void printOpinion()
        {
            foreach (String item in _opinion)
            {
                Console.WriteLine(item);
            }
        }
        public void addRate(int rate)
        {
            _rateSum += rate;
            _rateCount++;
        }
        public double getAvgRate()
        {
            return (double)_rateSum / _rateCount;
        }
    }
}
