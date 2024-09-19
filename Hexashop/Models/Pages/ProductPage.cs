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

        [Display(Order = 20)]
        public virtual int Price { get; set; }

        [Display(Order = 30)]
        [Required]
        [UIHint(UIHint.Image)]
        public virtual Url Image { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            this.Price = 90;
            base.SetDefaultValues(contentType);
        }
    }
}