using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        //public DateTime Published { get; set; }
    }
}