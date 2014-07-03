using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public   class Article
    {
        public int articleid { get; set; }
        public int typeid { get; set; }
        public int classid { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime datetime { get; set; }
        public string truename { get; set; }
        public int hits { get; set; }
    }
}
