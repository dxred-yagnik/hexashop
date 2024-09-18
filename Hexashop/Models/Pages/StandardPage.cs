using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    [ContentType(
        DisplayName = "Standard Page", 
        GUID = "274CC8D7-53FE-4E37-AC1F-4E3B61112826", 
        Description = "Standard content page")]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = Globals.GroupNames.SEO,
            Order = 10)]
        public virtual string Heading { get; set; }

    }
}
