using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.Framework.Statistics;
using EPiServer.Find.UnifiedSearch;
using EPiServer.Web.Mvc;
using Hexashop.Models.Pages;
using Hexashop.Models.ViewModels;
using MailKit.Search;
using Microsoft.AspNetCore.Mvc;

namespace Hexashop.Controllers
{
    public class ProductCategoryPageController : PageController<ProductCategoryPage>
    {
        public IActionResult Index(ProductCategoryPage currentPage)
        {
            var model = new ProductCategoryPageViewModel(currentPage);
            model.SearchQuery = "boy";

            var query = SearchClient.Instance.UnifiedSearchFor(model.SearchQuery)
                .UsingSynonyms()
                .Track();

            query = query.ApplyBestBets();

            var hitSpec = new HitSpecification
            {
                HighlightExcerpt = true,
                HighlightTitle = true,
                EncodeExcerpt = true,
                EncodeTitle = true,
            };

            model.Results = query.GetResult(hitSpec);

            return View(model);
        }
    }
}
