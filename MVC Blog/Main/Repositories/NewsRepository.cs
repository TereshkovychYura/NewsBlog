using Microsoft.EntityFrameworkCore;
using MVC_Blog.Entities;
using MVC_Blog.Main.Interfaces;
using MVC_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Main.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly DBContext context;
        public NewsRepository(DBContext context)
        {
            this.context = context;
        }

        public BlogModel CreatePost(BlogModel post)
        {
            context.News.Add(post);
            context.SaveChanges();
            return post;
        }

        public BlogModel DeletePost(int Id)
        {
            BlogModel post = context.News.Find(Id);
            if (post != null)
            {
                context.News.Remove(post);
                context.SaveChanges();
            }
            return post;
        }

        public IEnumerable<BlogModel> GetAllNews()
        {
            return context.News;
        }

        public BlogModel GetPostById(int Id)
        {
            return context.News.Find(Id);
        }

        public BlogModel UpdatePost(BlogModel newPost)
        {
            var post = context.News.Attach(newPost);
            post.State = EntityState.Modified;
            context.SaveChanges();
            return newPost;
        }
    }
}
