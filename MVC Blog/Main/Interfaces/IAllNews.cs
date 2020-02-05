using MVC_Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Main.Interfaces
{
    public interface IAllNews
    {
         IEnumerable<News> News { get; }
    }
}
