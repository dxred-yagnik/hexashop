using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using Hexashop.Models.Pages;

namespace Hexashop.Business.Initialization
{
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class ContentEventInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var events = ServiceLocator.Current.GetInstance<IContentEvents>();
            events.SavingContent += Events_SavingContent;            
        }

        private void Events_SavingContent(object sender, ContentEventArgs e)
        {
            if (e.Content is ProductPage productPage)
            {
                if (productPage.Price == 0)
                {
                    productPage.Price = 100;
                }
            }
        }
        public void Uninitialize(InitializationEngine context)
        {
            var events = ServiceLocator.Current.GetInstance<IContentEvents>();
            events.SavingContent -= Events_SavingContent;
        }
    }
}