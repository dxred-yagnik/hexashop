using Hexashop.Models.Media;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Blocks
{
    [ContentType(
        DisplayName = "Banner Block", 
        GUID = "0402efb9-434e-4eaf-ac76-1e8fbd347e9f", Description = "")]
    public class BannerBlock : BlockData
    {
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes(typeof(ImageFile))]
        public virtual ContentReference BannerImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString Descrition { get; set; }

    }
}