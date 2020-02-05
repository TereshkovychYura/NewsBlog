using MVC_Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Models
{
    public class NewsViewModel
    {
        public IEnumerable<News> allNews { get; set; }
    }
}
