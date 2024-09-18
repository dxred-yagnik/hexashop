using Hexashop.Models.Blocks;

namespace Hexashop.Models.Pages
{
    [ContentType(DisplayName = "Test Page", 
        GUID = "b9cab21e-97f8-4cd4-9345-a8be98bee35a",
        Description = "")]
    public class TestPage : SitePageData
    {
        public virtual CallToActionBlock ReadMore { get; set; }

        [AllowedTypes(typeof(CallToActionBlock))]
        public virtual ContentReference ReadMoreBlock { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
        }

    }
}
