using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAppWebAPI.Models
{
    public class Book
    {
        public Book()
        {
            Authors = new List<Author>();
        }

        public string Title { get; set; }
        public int ISBN { get; set; }
        public List<Author> Authors { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
    }
}