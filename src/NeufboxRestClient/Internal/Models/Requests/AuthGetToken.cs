using NeufboxRestClient.Constants;

namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// auth.getToken request.
    /// </summary>
    [ApiRequest(ApiMethod.Auth.GetToken, HttpVerb.GET, false)]
    public class AuthGetToken
    {
    }
}
