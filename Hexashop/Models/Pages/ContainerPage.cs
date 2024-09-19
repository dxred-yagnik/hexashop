using Hexashop.Business.Rendering;

namespace Hexashop.Models.Pages
{
    /// <summary>
    /// Used to logically group pages in the page tree
    /// </summary>
    [ContentType(
        GUID = "D178950C-D20E-4A46-90BD-5338B2424745")]
    [ImageUrl("/gfx/page-type-thumbnail.png")]
    public class ContainerPage : SitePageData, IContainerPage
    {
    }
}
