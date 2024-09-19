using EPiServer.Cms.Shell.UI.Components;
using EPiServer.Shell;
using EPiServer.Shell.ViewComposition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hexashop.Controllers
{
    [Authorize(Roles = "WebAdmins")]
    public class HexashopDashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reports()
        {
            return View("Index");
        }
    }
}
