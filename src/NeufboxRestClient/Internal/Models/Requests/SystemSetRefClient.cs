using NeufboxRestClient.Constants;
using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// system.setRefClient request.
    /// </summary>
    [ApiRequest(ApiMethod.System.SetRefClient, HttpVerb.POST)]
    public class SystemSetRefClient : AuthenticatedRequest
    {
        /// <summary>
        /// The client reference to set.
        /// </summary>
        [XmlAttribute("refClient")]
        public string ClientReference { get; set; }
    }
}
