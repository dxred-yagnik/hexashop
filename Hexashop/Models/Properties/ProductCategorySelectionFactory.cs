using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using Hexashop.Models.Pages;

namespace Hexashop.Models.Properties
{
    public class ProductCategorySelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var productCategories = contentLoader.GetChildren<ProductCategoryPage>(ContentReference.StartPage);
            foreach (var category in productCategories)
            {
                yield return new SelectItem() { Text = category.Name, Value = category.ContentLink.ID };
            }
        }
    }
}
