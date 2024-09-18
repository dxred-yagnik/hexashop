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
    }
}

