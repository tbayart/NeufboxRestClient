using NeufboxRestClient.Constants;

namespace NeufboxRestClient.Models.Requests
{
    /// <summary>
    /// auth.checkToken request.
    /// </summary>
    [ApiRequest(ApiMethod.Auth.CheckToken, HttpVerb.GET, false)]
    public class AuthCheckToken
    {
        /// <summary>
        /// The token provided by <see cref="AuthGetToken"/> request.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// The hash calculated using a <see cref="Interfaces.IHashProcessor"/> instance.
        /// </summary>
        public string Hash { get; set; }
    }
}
