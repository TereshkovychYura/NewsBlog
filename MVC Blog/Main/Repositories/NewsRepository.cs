using MVC_Blog.Entities;
using MVC_Blog.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Main.Repositories
{
    public class NewsRepository : IAllNews
    {
        private readonly DBContent dbContent;
        public NewsRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<News> News => dbContent.News;
    }
}
