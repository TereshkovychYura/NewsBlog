using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog.Entities;
using MVC_Blog.Models;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        DBContent content;
        public BlogController(DBContent _content)
        {
            content = _content;
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post( int id)
        {
            ViewBag.Title = "Post";
            var query = content.News.AsQueryable();

            var blogs = query.Where(post=>post.id== id).Select(p => new NewsViewModel
            {
                id = p.id,
                title = p.title,
                author = p.author,
                fulltext = p.fulltext,
                img = p.img,
                prew = p.prew
            }).SingleOrDefault();
            return View(blogs);
        }

        public IActionResult Blog()
        {
            List<NewsViewModel> posts = content.News.ToList();
            return View(posts);
        }
    }
}