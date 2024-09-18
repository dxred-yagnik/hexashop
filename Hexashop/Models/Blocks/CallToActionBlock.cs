namespace Hexashop.Models.Blocks
{
    [ContentType(
        DisplayName = "Call To Action Block",
        GUID = "814fa736-f57b-4cab-9eeb-3319e737ec82")]
    public class CallToActionBlock : BlockData
    {
        public virtual string ButtonName { get; set; }

        public virtual Url ButtonLink { get; set; }
    }
}