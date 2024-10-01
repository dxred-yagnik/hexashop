using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    [ContentType(DisplayName = "Blog Archive Page", 
        GUID = "6ebd0145-9186-4956-9dc7-296ce1431a90", Description = "")]
    [AvailableContentTypes(
        Include = [typeof(BlogPostPage)])]
    public class BlogArchivePage : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}
