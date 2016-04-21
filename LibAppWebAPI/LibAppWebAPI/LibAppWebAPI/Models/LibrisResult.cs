using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibAppWebAPI.Models
{
    public class LibrisResult
    {

        public class Rootobject
        {
            public Xsearch xsearch { get; set; }
        }

        public class Xsearch
        {
            public int from { get; set; }
            public int to { get; set; }
            public int records { get; set; }
            public List[] list { get; set; }
        }

        public class List
        {
            public string identifier { get; set; }
            public string title { get; set; }
            public string creator { get; set; }
            public string[] isbn { get; set; }
            public string type { get; set; }
            public string publisher { get; set; }
            public string date { get; set; }
            public string language { get; set; }
            public string description { get; set; }
            public string relation { get; set; }
            public Urls urls { get; set; }
        }

        public class Urls
        {
            public object[][] Mtm { get; set; }
        }

    }
}