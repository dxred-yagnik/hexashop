namespace Hexashop.Models.Pages
{
    [ContentType(
        DisplayName = "Start Page",
        GUID = "929ce3fa-ffc6-4ef8-b64c-e2091db320eb",
        Description = "Website start page")]
    [AvailableContentTypes(
        Availability = Availability.Specific, 
        Include = [typeof(StandardPage)])]
    public class StartPage : SitePageData
    {
    }
}
