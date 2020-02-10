using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog.Main.Interfaces;
using MVC_Blog.Models;

namespace MVC_Blog.Controllers
{
    public class AdminController : Controller
    {
        private INewsRepository _newsRep;
        public AdminController(INewsRepository newsRep)
        {
            _newsRep = newsRep;
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult PostEditor(int postID)
        {
            return View();
        }
        [HttpGet]
        public ViewResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(BlogModel post)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}