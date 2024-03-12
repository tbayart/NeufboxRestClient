using NeufboxRestClient.Models;

namespace NeufboxRestClient.Interfaces
{
    /// <summary>
    /// Neufbox client API interface.
    /// </summary>
    public interface INeufboxClient : INeufboxClientPublic, INeufboxClientPrivate
    {
        /// <summary>
        /// Login API to authenticate the client and allow access to private APIs.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>A task instance to provide the asynchronous Login result.</returns>
        Task<ApiResult> LoginAsync(string username, string password);
    }

    /// <summary>
    /// Neufbox client interface with public APIs accessible without authentication.
    /// </summary>
    public interface INeufboxClientPublic
    {
    }

    /// <summary>
    /// Neufbox client interface with private APIs requiring authentication.
    /// </summary>
    public interface INeufboxClientPrivate
    {

    }
}
