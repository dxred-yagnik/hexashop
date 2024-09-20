using EPiServer.Framework.DataAnnotations;
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


    [TemplateDescriptor(
        Inherited = true,
        Tags = new[] { "mobile" },
        AvailableWithoutTag = false)]
    public class StartPageMobileController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model = PageViewModel.Create(currentPage);
            return View("~/Views/StartPage/mobile.cshtml", model);
        }
    }

    [TemplateDescriptor(
       Inherited = true,
       Tags = new[] { "json" },
       AvailableWithoutTag = false)]
    public class HomePageJsonController : PageController<StartPage>
    {
        public JsonResult Index(StartPage currentPage)
        {
            dynamic Data = new { Name = currentPage.Name };

            return Json(Data);
        }
    }
}
