using MVC_Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Models
{
    public class NewsViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string prew { get; set; }
        public string fulltext { get; set; }
        public string img { get; set; }
        public string author { get; set; }
    }
}
