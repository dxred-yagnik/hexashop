using EPiServer.Web.Mvc;
using Hexashop.Models.Blocks;
using Hexashop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hexashop.Components
{
    public class SubscribeFormBlockViewComponent : BlockComponent<SubscribeFormBlock>
    {
        protected override IViewComponentResult InvokeComponent(SubscribeFormBlock currentContent)
        {
            var model = new SubscribeFormViewModel(currentContent);

            return View(model);
        }
    }
}
