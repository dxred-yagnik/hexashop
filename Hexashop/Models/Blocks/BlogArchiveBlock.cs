using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Hexashop.Models.Pages;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Blocks
{
    [ContentType(DisplayName = "BlogArchiveBlock", GUID = "e5acc780-43c0-42ab-9757-20b3da35e331", Description = "")]
    public class BlogArchiveBlock : BlockData
    {
        [AllowedTypes(typeof(BlogArchivePage))]
        public virtual ContentReference BlogArchivePage { get; set; }

    }
}