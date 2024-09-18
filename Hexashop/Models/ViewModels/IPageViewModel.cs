using Hexashop.Models.Pages;

namespace Hexashop.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; set; }
    }

}
