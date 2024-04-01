using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models
{
    /// <summary>
    /// The known network modes.
    /// </summary>
    public enum NetworkMode
    {
        /// <summary>
        /// Box works in router mode.
        /// </summary>
        [XmlEnum("router")]
        Router,

        /// <summary>
        /// Box works in bridge mode.
        /// </summary>
        [XmlEnum("bridge")]
        Bridge,
    }
}
