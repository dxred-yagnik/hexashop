using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Meta title",
            Description = "Used for search engine.",
            GroupName = Globals.GroupNames.SEO,
            Order = 10)]
        public virtual string MetaTitle { get; set; }
    }
}
