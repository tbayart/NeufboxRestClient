using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models
{
    /// <summary>
    /// Model used to deserialize API response when an error is returned.
    /// </summary>
    [XmlRoot("err")]
    public class ApiError
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [XmlAttribute("code")]
        public int Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [XmlAttribute("message")]
        public string Message { get; set; }
    }
}
