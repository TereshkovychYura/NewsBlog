using MVC_Blog.Entities;
using MVC_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Main.Interfaces
{
    public interface INewsRepository
    { 
        BlogModel GetPostById(int id);

        IEnumerable<BlogModel> GetAllNews();

        BlogModel CreatePost(BlogModel post);

        BlogModel UpdatePost(BlogModel newPost);

        BlogModel DeletePost(int Id);
    }
}
