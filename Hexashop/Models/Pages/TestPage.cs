using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using Hexashop.Business.Validation;
using Hexashop.Models.Blocks;
using Hexashop.Models.Media;
using Hexashop.Models.Properties;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Pages
{
    [ContentType(DisplayName = "Test Page", 
        GUID = "b9cab21e-97f8-4cd4-9345-a8be98bee35a",
        Description = "")]
    public class TestPage : SitePageData
    {
        public virtual BannerBlock Banner { get; set; }
        public virtual CallToActionBlock ReadMore { get; set; }

        [AllowedTypes(typeof(CallToActionBlock))]
        public virtual ContentReference ReadMoreBlock { get; set; }

        public virtual IList<CallToActionBlock> ActionsList { get; set; }

        [AllowedTypes(typeof(CallToActionBlock))]
        public virtual ContentArea ActionsContentArea { get; set; }


        [SelectOne(SelectionFactoryType = typeof(ProductCategorySelectionFactory))]
        public virtual int ProductCategoryID { get; set; }

        [SelectMany(SelectionFactoryType = typeof(ProductCategorySelectionFactory))]
        public virtual string ProductCategories { get; set; }

       
        [AllowedTypes(typeof(ImageFile))]
        public virtual ContentArea Sliders1 { get; set; }

        [UIHint(UIHint.Image)]
        public virtual IList<ContentReference> Sliders2
        {
            get;
            set;
        }

        [CheckBadValidator]
        public virtual string? Heading { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
        }

    }
}
