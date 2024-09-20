using EPiServer.Find.UnifiedSearch;
using Hexashop.Models.Pages;

namespace Hexashop.Models.ViewModels
{
    public class ProductCategoryPageViewModel: PageViewModel<ProductCategoryPage>
    {
        public ProductCategoryPageViewModel(ProductCategoryPage currentPage)
           : base(currentPage)
        {
        }

        public string SearchQuery { get; set; } 
        public UnifiedSearchResults Results { get; set; }
    }
}
