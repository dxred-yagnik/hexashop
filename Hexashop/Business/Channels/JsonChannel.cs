using EPiServer.Web;

namespace Hexashop.Business.Channels;

/// <summary>
/// Defines the 'Web' content channel
/// </summary>
public class JsonChannel : DisplayChannel
{
    public override string ChannelName => "json";

    public override bool IsActive(HttpContext context)
    {
        return context.Request.Query["json"] == "true";
    }
}
