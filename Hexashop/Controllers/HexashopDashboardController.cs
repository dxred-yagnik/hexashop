using EPiServer.Data.Dynamic;
using Hexashop.Business.DataStore;
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

        public ActionResult Ratings()
        {
            var _dataStore = DynamicDataStoreFactory.Instance
               .CreateStore(typeof(ProductRating));

            var model = _dataStore
                .Items<ProductRating>().ToList();
            return View("Ratings", model);
        }
    }
}
