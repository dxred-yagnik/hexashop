using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Hexashop.Models.Pages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Hexashop.Controllers
{
    public class BlogArchivePageController : PageController<BlogArchivePage>
    {
        private readonly IContentLoader _contentLoader;

        public BlogArchivePageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }
        public IActionResult Index(BlogArchivePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            var blogPages = _contentLoader.GetChildren<BlogPostPage>(currentPage.ContentLink);
            return View(currentPage);
        }
    }
}
