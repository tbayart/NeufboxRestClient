using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models.Responses
{
    /// <summary>
    /// Response to <see cref="Requests.SystemGetInfo"/>.
    /// </summary>
    [XmlRoot("system")]
    public class SystemGetInfo
    {
        /// <summary>
        /// The product ID: $(NB)-$(HARD)-$(HARD_VERSION).
        /// </summary>
        [XmlAttribute("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// The MAC address of the box.
        /// </summary>
        [XmlAttribute("mac_addr")]
        public string MacAddress { get; set; }

        /// <summary>
        /// The network mode of the box.
        /// </summary>
        [XmlAttribute("net_mode")]
        public NetworkMode NetworkMode { get; set; }

        /// <summary>
        /// How the box is connected to the Internet.
        /// </summary>
        [XmlAttribute("net_infra")]
        public NetworkInfrastructure NetworkInfrastructure { get; set; }

        /// <summary>
        /// The uptime of the box (seconds).
        /// </summary>
        [XmlAttribute("uptime")]
        public int Uptime { get; set; }

        /// <summary>
        /// The box's main firmware version: $(NB)-MAIN-R$(VERSION).
        /// </summary>
        [XmlAttribute("version_mainfirmware")]
        public string VersionMainFirmware { get; set; }

        /// <summary>
        /// The box's rescue firmware version.
        /// </summary>
        [XmlAttribute("version_rescuefirmware")]
        public string VersionRescueFirmware { get; set; }

        /// <summary>
        /// The box's bootloader version.
        /// </summary>
        [XmlAttribute("version_bootloader")]
        public string VersionBootloader { get; set; }

        /// <summary>
        /// The box's DSL driver version.
        /// </summary>
        /// <remarks>Unavailable for NB5.</remarks>
        [XmlAttribute("version_dsldriver")]
        public string VersionDslDriver { get; set; }

        /// <summary>
        /// The current date and time.
        /// </summary>
        [XmlAttribute("current_datetime")]
        public string CurrentDatetime { get; set; }

        /// <summary>
        /// The client reference.
        /// </summary>
        [XmlAttribute("refclient")]
        public string ClientReference { get; set; }

        /// <summary>
        /// The unique network identifier.
        /// </summary>
        [XmlAttribute("idur")]
        public string NetworkIdentifier { get; set; }

        /// <summary>
        /// The box's power voltage (mV).
        /// </summary>
        [XmlAttribute("alimvoltage")]
        public int PowerVoltage { get; set; }

        /// <summary>
        /// The box's temperature (m°C).
        /// </summary>
        [XmlAttribute("temperature")]
        public int Temperature { get; set; }

        /// <summary>
        /// The serial number.
        /// </summary>
        [XmlAttribute("serial_number")]
        public string SerialNumber { get; set; }
    }
}
