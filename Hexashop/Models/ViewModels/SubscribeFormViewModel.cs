using EPiServer.Forms.Implementation.Elements;
using EPiServer.ServiceLocation;
using Hexashop.Models.Blocks;

namespace Hexashop.Models.ViewModels
{
    public class SubscribeFormViewModel
    {
        private readonly Injected<IContentLoader> _contentLoader;

        public SubscribeFormViewModel(SubscribeFormBlock _subscribeBlock)
        {
            BlockData = _subscribeBlock;
            FormContainer = _contentLoader.Service.Get<FormContainerBlock>(_subscribeBlock.FormRef);
        }

        public SubscribeFormBlock BlockData { get; set; }

        public FormContainerBlock FormContainer { get; set; }
    }
}
