using System.ComponentModel.DataAnnotations;

namespace Hexashop.Models.Blocks
{
    [ContentType(DisplayName = "Social Media Block",
        GUID = "0c869064-b7e2-410f-b702-fc28c894d0ab", Description = "")]
    public class SocialMediaBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }
    }
}