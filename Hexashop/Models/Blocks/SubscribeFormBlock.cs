using EPiServer.Forms.Implementation.Elements;
using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Blocks
{
    [ContentType(DisplayName = "Subscribe Form Block", 
        GUID = "82cd474b-bcb4-455c-ba5d-98c274ef2a13")]
    public class SubscribeFormBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string FormTitle { get; set; }

        [AllowedTypes(typeof(FormContainerBlock))]
        public virtual ContentReference FormRef { get; set; }

    }
}