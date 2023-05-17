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
        public string _creator { get; set; }
        public int _partNum { get; set; }

        //methods
        public Stream() 
        { 
            _creator = "no name";
            _partNum = 0;
        }

        public Stream(string creator, int partNum)
        {
            _creator = creator;
            _partNum = partNum;
        }

    
    }
}
