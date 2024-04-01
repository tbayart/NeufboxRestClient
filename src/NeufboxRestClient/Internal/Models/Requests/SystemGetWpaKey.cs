using NeufboxRestClient.Constants;

namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// system.getInfo request.
    /// </summary>
    [ApiRequest(ApiMethod.System.GetWpaKey, HttpVerb.GET)]
    public class SystemGetWpaKey : AuthenticatedRequest
    {
    }
}
