using NeufboxRestClient.Models;

namespace NeufboxRestClient.Interfaces
{
    /// <summary>
    /// Neufbox client interface for System related APIs.
    /// </summary>
    public interface INeufboxModuleSystem
    {
        /// <summary>
        /// Provide system information.
        /// </summary>
        /// <returns>A <see cref="SystemInformation"/> instance containing all information.</returns>
        Task<SystemInformation> GetInformationAsync();

        /// <summary>
        /// Provide a list of network interfaces.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        /// <returns>All network interfaces.</returns>
        Task<NetworkInterface[]> GetInterfaceListAsync();

        /// <summary>
        /// Get the WPA key.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        /// <returns>The WPA key.</returns>
        Task<string> GetWpaKeyAsync();

        /// <summary>
        /// Reboot the box.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        Task RebootAsync();

        /// <summary>
        /// Change the network mode of the box.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        Task SetNetworkModeAsync(NetworkMode networkMode);

        /// <summary>
        /// Set the client reference.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        Task SetClientReferenceAsync(string clientReference);
    }
}
