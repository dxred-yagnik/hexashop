using EPiServer.Shell.Navigation;

namespace Hexashop.Business.Extends
{
    [MenuProvider]
    public class HexashopMenuProvider : IMenuProvider
    {
        private string menuLocation = "/global";
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
            var ratings = new UrlMenuItem("Product Ratings", $"{menuLocation}/hexashop/ratings", "/HexashopDashboard/ratings")
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
                ratings,
                help
            ];
        }
    }

}
