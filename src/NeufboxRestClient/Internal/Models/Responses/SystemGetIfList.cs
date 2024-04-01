using NeufboxRestClient.Models;
using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models.Responses
{
    /// <summary>
    /// Response to <see cref="Requests.SystemGetIfList"/>.
    /// </summary>
    [XmlRoot("system")]
    public class SystemGetIfList
    {
        /// <summary>
        /// The list of network interfaces.
        /// </summary>
        [XmlArray("interface")]
        public NetworkInterface[] Interfaces { get; set; }
    }
}
