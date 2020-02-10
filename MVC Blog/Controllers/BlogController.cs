using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog.Entities;
using MVC_Blog.Main.Interfaces;
using MVC_Blog.Models;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        private readonly INewsRepository _newsRepository;
        public BlogController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        [Route("Blog/Post/{id}")]
        public IActionResult Post( int id)
        {
            var post = _newsRepository.GetPostById(id);
            return View(post);
        }

        public IActionResult Blog()
        {
            var posts = _newsRepository.GetAllNews().ToList();
            return View(posts);
        }

        [HttpPost]
        public ViewResult Edit()
        {
            return View();
        }
    }
}