﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MVC_Blog.Entities;
using MVC_Blog.Main.Interfaces;
using MVC_Blog.Models;
using MVC_Blog.ViewModel;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        private readonly INewsRepository _newsRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        public BlogController(INewsRepository newsRepository, IHostingEnvironment hostingEnvironment)
        {
            _newsRepository = newsRepository;
            _hostingEnvironment = hostingEnvironment;
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

        [HttpGet]
        public ViewResult Edit(int id)
        {
            BlogModel post = _newsRepository.GetPostById(id);
            PostEditViewModel postEditViewModel = new PostEditViewModel
            {
                Id = post.id,
                title = post.title,
                author = post.author,
                prew = post.prew,
                fulltext = post.fulltext,
                ExistImgPath = post.img
            };
            return View(postEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PostEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                BlogModel post = _newsRepository.GetPostById(model.Id);
                post.author = model.author;
                post.title = model.title;
                post.prew = model.prew;
                post.fulltext = model.fulltext;

                if (model.img != null)
                {
                    if (model.ExistImgPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "img", model.ExistImgPath);
                        System.IO.File.Delete(filePath);
                    }
                    post.img = UploadedFile(model);
                }

                _newsRepository.UpdatePost(post);
                return RedirectToAction("Blog");
            }
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            BlogModel post = _newsRepository.GetPostById(id);
            return View(post);
        }

        [HttpPost]
        public IActionResult Delete(PostDeleteViewModel model)
        {
                BlogModel post = _newsRepository.GetPostById(model.Id);
                _newsRepository.DeletePost(post.id);
                return RedirectToAction("Blog");
        }


        private string UploadedFile(PostEditViewModel model)
        {
            string uniqFileName = null;
            if (model.img != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.img.CopyTo(fileStream);
                }
            }

            return uniqFileName;
        }
    }
}