using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;
using Hexashop.Models.Properties;

namespace Hexashop.Business.UIDescriptors
{
    [EditorDescriptorRegistration(TargetType = typeof(CategoryList))]
    public class CityEditorDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata,
            IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(ProductCategorySelectionFactory);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor";
            base.ModifyMetadata(metadata, attributes);
        }
    }
}
