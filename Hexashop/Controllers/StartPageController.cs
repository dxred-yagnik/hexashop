using EPiServer.Web.Mvc;
using Hexashop.Models.Pages;
using Hexashop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hexashop.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);


            return View(model);
        }
    }
}
