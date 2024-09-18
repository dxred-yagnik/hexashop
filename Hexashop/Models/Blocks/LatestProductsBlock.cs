using Hexashop.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Blocks
{
    [ContentType(DisplayName = "Latest Products Blockcs",
        GUID = "34159ba7-640b-4355-ac84-668944114d94", Description = "")]
    public class LatestProductsBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [AllowedTypes(typeof(ProductPage))]
        public virtual ContentArea Products { get; set; }

    }
}