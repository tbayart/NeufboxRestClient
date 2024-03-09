using System.Xml.Serialization;

namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Model used to deserialize API response.
    /// </summary>
    [XmlRoot("rsp")]
    public class ApiResponse
    {
        /// <summary>
        /// The response status.
        /// </summary>
        [XmlAttribute("stat")]
        public StatusCode Status { get; set; }

        /// <summary>
        /// The API version.
        /// </summary>
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
