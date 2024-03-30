namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Login return codes.
    /// </summary>
    public enum LoginResult : int
    {
        /// <summary>
        /// Login successful
        /// </summary>
        Success = 200,

        /// <summary>
        /// Session doen't exists or already authenticated.
        /// </summary>
        InvalidSession = 201,

        /// <summary>
        /// Token expired before beeing validated.
        /// </summary>
        Timeout = 202,

        /// <summary>
        /// Push button not pushed.
        /// </summary>
        PushFailed = 203,

        /// <summary>
        /// Invalid login and/or password.
        /// </summary>
        InvalidCredentials = 204,

        /// <summary>
        /// Authentication disabled.
        /// </summary>
        Disabled = 205,

        /// <summary>
        /// Undocumented error (check logs).
        /// </summary>
        Error = 500,
    }
}
