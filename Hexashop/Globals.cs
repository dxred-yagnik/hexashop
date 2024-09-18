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
            [Display(Name = "SEO", Order = 10)]
            public const string SEO = "SEO";
        }
    }
}
