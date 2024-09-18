using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    [ContentType(
        GUID = "2FB93CE4-6BDF-4A1B-94EC-E8161F62E547",
        GroupName = Globals.GroupNames.Products)]
    public class ProductPage : SitePageData
    {
        [CultureSpecific]
        [Display(Order = 10)]
        [Required]
        [UIHint(UIHint.Image)]
        public virtual string ProductName { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            this.ProductName = "product 123";

            base.SetDefaultValues(contentType);
        }

    }
}