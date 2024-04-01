using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models
{
    /// <summary>
    /// The known network infrastructures.
    /// </summary>
    public enum NetworkInfrastructure
    {
        /// <summary>
        /// Infrastructure is ADSL.
        /// </summary>
        [XmlEnum("adsl")]
        ADSL,

        /// <summary>
        /// Infrastructure is FTTH.
        /// </summary>
        [XmlEnum("ftth")]
        FFTH,

        /// <summary>
        /// Infrastructure is GPRS.
        /// </summary>
        [XmlEnum("gprs")]
        GPRS,
    }
}
