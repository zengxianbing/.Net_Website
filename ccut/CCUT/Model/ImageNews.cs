using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public  class ImageNews
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string title { get; set; }
        public int articleid { get; set; }
        public DateTime time { get; set; }
    }
}
