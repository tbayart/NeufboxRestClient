using NeufboxRestClient.Models;

namespace NeufboxRestClient.Interfaces
{
    /// <summary>
    /// Neufbox client API interface.
    /// </summary>
    public interface INeufboxClient
    {
        /// <summary>
        /// Login API to authenticate the client and allow access to private APIs.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>A task instance to provide the asynchronous Login result.</returns>
        Task<LoginResult> LoginAsync(string username, string password);

        /// <summary>
        /// Access to System module methods.
        /// </summary>
        INeufboxModuleSystem System { get; }
    }
}
