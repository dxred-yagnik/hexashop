using EPiServer.Shell.Navigation;

namespace Hexashop.Business.Extends
{
    [MenuProvider]
    public class HexashopMenuProvider : IMenuProvider
    {
        private string menuLocation = "/global/cms/admin";

        public IEnumerable<MenuItem> GetMenuItems()
        {
            // parent
            var hexashopSection = new UrlMenuItem("HEXASHOP", $"{menuLocation}/hexashop", "/HexashopDashboard")
            {
                IsAvailable = (request) => true
            };

            var overview = new UrlMenuItem("Overview", $"{menuLocation}/hexashop/overview", "/HexashopDashboard")
            {
                IsAvailable = (request) => true,
                SortIndex = 100
            };
            var reports = new UrlMenuItem("Reports", $"{menuLocation}/hexashop/reports", "/HexashopDashboard/reports")
            {
                IsAvailable = (request) => true,
                SortIndex = 200
            };
            var help = new UrlMenuItem("Help", $"{menuLocation}/hexashop/help", "https://world.optimizely.com")
            {
                IsAvailable = (request) => true,
                SortIndex = 300
            };

            return [
                hexashopSection,
                overview,
                reports,
                help
            ];
        }
    }

}
