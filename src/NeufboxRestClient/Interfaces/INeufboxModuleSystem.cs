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
        /// 
        /// </summary>
        /// <exception cref="UnauthorizedException" />
        /// <returns></returns>
        Task<NetworkInterface[]> GetInterfaceListAsync();

        /// <summary>
        /// Get the WPA key.
        /// </summary>
        /// <exception cref="UnauthorizedException" />
        Task<string> GetWpaKeyAsync();

        /// <summary>
        /// Reboot the box.
        /// </summary>
        /// <exception cref="UnauthorizedException" />
        Task RebootAsync();

        /// <summary>
        /// Change the network mode of the box.
        /// </summary>
        Task SetNetworkModeAsync(NetworkMode networkMode);

        /// <summary>
        /// Set the client reference.
        /// </summary>
        Task<string> SetClientReferenceAsync(string clientReference);
    }
}
