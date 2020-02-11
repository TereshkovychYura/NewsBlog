using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MVC_Blog.Main.Interfaces;
using MVC_Blog.Models;
using MVC_Blog.ViewModel;

namespace MVC_Blog.Controllers
{
    public class AdminController : Controller
    {
        private INewsRepository _newsRep;
        private IHostingEnvironment hostingEnvironment;

        public AdminController(INewsRepository newsRep, IHostingEnvironment hostingEnvironment)
        {
            _newsRep = newsRep;
            this.hostingEnvironment = hostingEnvironment;
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
        public IActionResult CreatePost(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqFileName = null;
                if (model.img != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    model.img.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                BlogModel newPost = new BlogModel
                {
                    author = model.author,
                    title = model.title,
                    prew = model.prew,
                    fulltext = model.fulltext,
                    img = uniqFileName
                };
                _newsRep.CreatePost(newPost);
                return RedirectToRoute( new { controller = "Blog", action = "Post", Id = newPost.id });
            }
            return View();
        }
    }
}