using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    [ContentType(DisplayName = "Blog Post Page", 
        GUID = "bb22fe92-d2c5-428e-9ce2-6fb9a4fb4c99", 
        Description = "")]
    [AvailableContentTypes(
        IncludeOn = [typeof(BlogArchivePage)])]
    public class BlogPostPage : PageData
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
