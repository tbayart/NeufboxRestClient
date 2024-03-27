namespace NeufboxRestClient.Models
{
    /// <summary>
    /// The system information.
    /// </summary>
    /// <param name="ProductId">The product ID: $(NB)-$(HARD)-$(HARD_VERSION).</param>
    /// <param name="MacAddress">The MAC address of the box.</param>
    /// <param name="NetworkMode">The network mode of the box.</param>
    /// <param name="NetworkInfrastructure">How the box is connected to the Internet.</param>
    /// <param name="Uptime">The uptime of the box.</param>
    /// <param name="VersionMainFirmware">The box's main firmware version: $(NB)-MAIN-R$(VERSION).</param>
    /// <param name="VersionRescueFirmware">The box's rescue firmware version.</param>
    /// <param name="VersionBootloader">The box's bootloader version.</param>
    /// <param name="VersionDslDriver">The box's DSL driver version.</param>
    /// <param name="CurrentDateTime">The current date and time.</param>
    /// <param name="ClientReference">The client reference.</param>
    /// <param name="NetworkIdentifier">The unique network identifier.</param>
    /// <param name="PowerVoltage">The box's power voltage (Volts).</param>
    /// <param name="Temperature">The box's temperature (Celcius).</param>
    /// <param name="SerialNumber">The serial number.</param>
    public record SystemInformation(string ProductId, string MacAddress, NetworkMode NetworkMode,
        NetworkInfrastructure NetworkInfrastructure, TimeSpan Uptime, string VersionMainFirmware,
        string VersionRescueFirmware, string VersionBootloader, string VersionDslDriver,
        DateTime CurrentDateTime, string ClientReference, string NetworkIdentifier,
        float PowerVoltage, float Temperature, string SerialNumber);

    /// <summary>
    /// The known network modes.
    /// </summary>
    public enum NetworkMode
    {
        /// <summary>
        /// Box works in router mode.
        /// </summary>
        Router,

        /// <summary>
        /// Box works in bridge mode.
        /// </summary>
        Bridge,
    }

    /// <summary>
    /// The known network infrastructures.
    /// </summary>
    public enum NetworkInfrastructure
    {
        /// <summary>
        /// Infrastructure is ADSL.
        /// </summary>
        ADSL,

        /// <summary>
        /// Infrastructure is FFTH.
        /// </summary>
        FFTH,

        /// <summary>
        /// Infrastructure is GPRS.
        /// </summary>
        GPRS,
    }
}
