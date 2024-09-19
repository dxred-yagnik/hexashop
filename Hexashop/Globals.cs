using System.ComponentModel.DataAnnotations;

namespace Hexashop
{
    public class Globals
    {
        /// <summary>
        /// Group names for content types and properties
        /// </summary>
        [GroupDefinitions]
        public static class GroupNames
        {
            [Display(Name = "SEO", Order = 0)]
            public const string SEO = "SEO";

            [Display(Name = "Layout", Order = 20)]
            public const string Layout = "Layout";

            [Display(Name = "Products", Order = 20)]
            public const string Products = "Products";
        }

        /// <summary>
        /// Tags to use for the main widths used in the Bootstrap HTML framework
        /// </summary>
        public static class ContentAreaTags
        {
            public const string FullWidth = "full";
            public const string WideWidth = "wide";
            public const string HalfWidth = "half";
            public const string NarrowWidth = "narrow";
            public const string NoRenderer = "norenderer";
        }
    }
}

