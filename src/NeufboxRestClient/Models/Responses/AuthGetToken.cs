using System.Xml.Serialization;

namespace NeufboxRestClient.Models.Responses
{
    /// <summary>
    /// Response to <see cref="Requests.AuthGetToken"/>.
    /// </summary>
    [XmlRoot("auth")]
    public class AuthGetToken
    {
        /// <summary>
        /// The token provided by the box.
        /// </summary>
        [XmlAttribute("token")]
        public string Token { get; set; }

        /// <summary>
        /// The authentication method.
        /// </summary>
        [XmlAttribute("method")]
        public AuthMethod Method { get; set; }
    }

    /// <summary>
    /// The known authentication methods.
    /// </summary>
    public enum AuthMethod
    {
        /// <summary>
        /// Authentication require password.
        /// </summary>
        [XmlEnum("passwd")]
        Password,

        /// <summary>
        /// Authentication require physically pushing the WPS button of the box.
        /// </summary>
        [XmlEnum("button")]
        Button,

        /// <summary>
        /// Authentication can be done using <see cref="Password"/> or <see cref="Button"/> scenario.
        /// </summary>
        [XmlEnum("all")]
        All,
    }
}
