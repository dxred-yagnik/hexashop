using EPiServer;
using EPiServer.Core;
using EPiServer.Core.Internal;
using EPiServer.Filters;
using EPiServer.Web.Mvc;
using Hexashop.Models.Blocks;
using Hexashop.Models.Pages;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace Hexashop.Components
{
    public class BlogArchiveBlockComponent : BlockComponent<BlogArchiveBlock>
    {
        private readonly IContentLoader _contentLoader;
      
        public BlogArchiveBlockComponent(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        protected override IViewComponentResult InvokeComponent(BlogArchiveBlock currentContent)
        {
            var blogPages = _contentLoader.GetChildren<BlogPostPage>(currentContent.BlogArchivePage);

            return View();
        }
    }
}
