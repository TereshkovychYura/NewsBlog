using MVC_Blog.Entities;
using MVC_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Main.Interfaces
{
    public interface IAllNews
    {
         IEnumerable<NewsViewModel> News { get; }
    }
}
