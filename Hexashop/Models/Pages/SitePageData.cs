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

        [CultureSpecific]
        [Display(
            Name = "Meta Keywords",
            Description = "Used for search engine.",
            GroupName = Globals.GroupNames.SEO,
            Order = 20)]
        public virtual IList<string> MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Sections",
           GroupName = SystemTabNames.Content,
           Description = "Add website sections",
           Order = 999)]
        public virtual ContentArea Sections { get; set; }
    }
}
