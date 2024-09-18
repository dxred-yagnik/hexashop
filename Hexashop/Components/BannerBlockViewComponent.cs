using EPiServer.Web.Mvc;
using Hexashop.Models.Blocks;
using Microsoft.AspNetCore.Mvc;


namespace Hexashop.Components
{
    public class BannerBlockViewComponent : BlockComponent<BannerBlock>
    {
        public BannerBlockViewComponent()
        {
        }

        protected override IViewComponentResult InvokeComponent(BannerBlock currentContent)
        {
            return View(currentContent);
        }
    }
}
