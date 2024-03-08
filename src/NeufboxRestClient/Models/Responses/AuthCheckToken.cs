using System.Xml.Serialization;

namespace NeufboxRestClient.Models.Responses
{
    /// <summary>
    /// Response to <see cref="Requests.AuthCheckToken"/>.
    /// </summary>
    [XmlRoot("auth")]
    public class AuthCheckToken
    {
        /// <summary>
        /// The validated authentication token.
        /// </summary>
        [XmlAttribute("token")]
        public string Token { get; set; }
    }
}
