using EPiServer.SpecializedProperties;

namespace Hexashop.Models.Blocks
{
    [ContentType(DisplayName = "Menu Item Block",
        GUID = "6469f879-c8f9-4268-ba2f-fc916b5a7143",
        Description = "",
        AvailableInEditMode = false)]
    public class MenuItemBlock : BlockData
    {
        public virtual Url MainMenuItem { get; set; }

        public virtual LinkItemCollection SubMenuItems { get; set; }

    }
}