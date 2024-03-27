using System.Xml.Serialization;

namespace NeufboxRestClient.Internal
{
    /// <summary>
    /// The status codes returned by the API.
    /// </summary>
    public enum StatusCode
    {
        /// <summary>
        /// Success status code returned when the request is successful.
        /// </summary>
        [XmlEnum("ok")]
        Success,

        /// <summary>
        /// Failed status code returned when the request is not successful.
        /// </summary>
        [XmlEnum("fail")]
        Failed,
    }
}
