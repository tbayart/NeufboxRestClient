using NeufboxRestClient.Constants;

namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// system.reboot request.
    /// </summary>
    [ApiRequest(ApiMethod.System.Reboot, HttpVerb.POST)]
    public class SystemReboot : AuthenticatedRequest
    {
    }
}
