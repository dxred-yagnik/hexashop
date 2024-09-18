using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Hexashop.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Hexashop.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class DefaultPageController : PageController<SitePageData>
    {
        public ViewResult Index(SitePageData currentPage)
        {
            var model = currentPage;// CreateModel(currentPage);
            return View($"~/Views/{currentPage.GetOriginalType().Name}/Index.cshtml", model);
        }

        /// <summary>
        /// Creates a PageViewModel where the type parameter is the type of the page.
        /// </summary>
        /// <remarks>
        /// Used to create models of a specific type without the calling method having to know that type.
        /// </remarks>
        //private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        //{
        //    var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
        //    return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        //}
    }
}
