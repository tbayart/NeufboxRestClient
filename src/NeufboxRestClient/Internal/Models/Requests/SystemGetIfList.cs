using NeufboxRestClient.Constants;

namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// system.getIfList request.
    /// </summary>
    [ApiRequest(ApiMethod.System.GetIfList, HttpVerb.GET)]
    public class SystemGetIfList : AuthenticatedRequest
    {
    }
}
