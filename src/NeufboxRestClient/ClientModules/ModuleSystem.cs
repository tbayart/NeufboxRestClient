using NeufboxRestClient.Interfaces;
using NeufboxRestClient.Internal.Models.Requests;
using NeufboxRestClient.Models;
using NeufboxRestClient.Toolbox;
using System.Globalization;

namespace NeufboxRestClient
{
    /// <summary>
    /// <see cref="INeufboxModuleSystem"/> implementation for System related APIs.
    /// </summary>
    public partial class NeufboxClient : INeufboxModuleSystem
    {
        /// <summary>
        /// Provide system information.
        /// </summary>
        /// <returns>A <see cref="SystemInformation"/> instance containing all information.</returns>
        public async Task<SystemInformation> GetInformationAsync()
        {
            var response = await SendRequestAsync<SystemGetInfo, Internal.Models.Responses.SystemGetInfo>(new SystemGetInfo());
            if (response.IsSuccess == false)
                return null;

            // data convertion
            response.Data.NetworkMode.CastByName(out NetworkMode networkMode);
            response.Data.NetworkInfrastructure.CastByName(out NetworkInfrastructure networkInfrastructure);
            var uptime = TimeSpan.FromSeconds(response.Data.Uptime);
            DateTime.TryParseExact(response.Data.CurrentDatetime, "yyyyMMddHHmm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var currentDateTime);
            var powerVoltage = response.Data.PowerVoltage * 0.001f;
            var temperature = response.Data.Temperature * 0.001f;

            return new SystemInformation(
                response.Data.ProductId, response.Data.MacAddress, networkMode, networkInfrastructure, uptime,
                response.Data.VersionMainFirmware, response.Data.VersionRescueFirmware, response.Data.VersionBootloader, response.Data.VersionDslDriver,
                currentDateTime, response.Data.ClientReference, response.Data.NetworkIdentifier, powerVoltage, temperature, response.Data.SerialNumber);
        }

        /// <summary>
        /// Provide a list of network interfaces.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        /// <returns>All network interfaces.</returns>
        public async Task<NetworkInterface[]> GetInterfaceListAsync()
        {
            var response = await SendRequestAsync<SystemGetIfList, Internal.Models.Responses.SystemGetIfList>(new SystemGetIfList());
            if (response.IsSuccess == false)
                return null;

            return response.Data.Interfaces;
        }

        /// <summary>
        /// Get the WPA key.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        /// <returns>The WPA key.</returns>
        public async Task<string> GetWpaKeyAsync()
        {
            var response = await SendRequestAsync<SystemGetWpaKey, Internal.Models.Responses.SystemGetWpaKey>(new SystemGetWpaKey());
            if (response.IsSuccess == false)
                return null;

            return response.Data.WpaKey;
        }

        /// <summary>
        /// Reboot the box.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        public async Task RebootAsync()
        {
            await SendRequestAsync<SystemReboot, Internal.Models.Responses.SystemReboot>(new SystemReboot());
        }

        /// <summary>
        /// Change the network mode of the box.
        /// </summary>
        /// <param name="networkMode">The network mode to set.</param>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        public async Task SetNetworkModeAsync(NetworkMode networkMode)
        {
            EnumHelpers.CastByName(networkMode, out Internal.Models.NetworkMode mode);
            await SendRequestAsync<SystemSetNetMode, Internal.Models.Responses.SystemSetNetMode>(new SystemSetNetMode { NetworkMode = mode });
        }

        /// <summary>
        /// Set the client reference.
        /// </summary>
        /// <exception cref="UnauthorizedException">The Login was not done before calling the method.</exception>
        public Task SetClientReferenceAsync(string clientReference)
        {
            throw new NotImplementedException();
        }
    }
}
