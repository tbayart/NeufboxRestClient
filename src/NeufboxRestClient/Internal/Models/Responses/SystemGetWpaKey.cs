using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models.Responses
{
    /// <summary>
    /// Response to <see cref="Requests.SystemGetWpaKey"/>.
    /// </summary>
    [XmlRoot("system")]
    public class SystemGetWpaKey
    {
        /// <summary>
        /// The validated authentication token.
        /// </summary>
        [XmlAttribute("wpa_key")]
        public string WpaKey { get; set; }
    }
}
