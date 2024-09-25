using EPiServer.SpecializedProperties;
using Hexashop.Models.Pages;

namespace Hexashop.Models.ViewModels
{
    public class LayoutModel
    {
        public Url LogoUrl { get; set; }

        //public IList<SitePageData> MenuItems { get; set;}
        public LinkItemCollection MenuItems { get; set; }

        public IDictionary<string,string> Languages { get; set; }
    }
}
