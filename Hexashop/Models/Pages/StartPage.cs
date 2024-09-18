using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    [ContentType(
        DisplayName = "Start Page",
        GUID = "929ce3fa-ffc6-4ef8-b64c-e2091db320eb",
        Description = "Website start page")]
    [AvailableContentTypes(
        Exclude = [typeof(StartPage)])]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Logo Url",
            Description = "Select website logo",
            GroupName = Globals.GroupNames.Layout,
            Order = 10)]
        [Required]
        [UIHint(UIHint.Image)]
        public virtual Url LogoUrl { get; set; }

        [CultureSpecific]
        [Display(
           GroupName = Globals.GroupNames.Layout,
           Order = 20)]
        [Required]
        public virtual LinkItemCollection Navigation { get; set; }

    }
}
