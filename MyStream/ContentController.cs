
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStream
{
    public class ContentController
    {
        public static bool init()
        {
            ContentHendler.loadContents();
            return true;
        }
        public static Content  getContent(int contentID)
        {
            return Content._contents[contentID];
        }

        public static bool addContent(int contentID, string name, string date, string genre,string type)
        {
            Content a = new Content(contentID, name, date, genre,type);
            Content._contents.Add(contentID, a);
            ContentHendler.saveContent(a); 
            return true;
        }
    }
}
