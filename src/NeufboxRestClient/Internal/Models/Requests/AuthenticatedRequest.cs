namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// The base for authentication required requests.
    /// </summary>
    public abstract class AuthenticatedRequest
    {
        /// <summary>
        /// The token provided by <see cref="AuthGetToken"/> request.
        /// </summary>
        public string Token { get; set; }
    }
}
