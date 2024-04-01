using NeufboxRestClient.Constants;
using System.Xml.Serialization;

namespace NeufboxRestClient.Internal.Models.Requests
{
    /// <summary>
    /// system.setNetMode request.
    /// </summary>
    [ApiRequest(ApiMethod.System.SetNetMode, HttpVerb.POST)]
    public class SystemSetNetMode
    {
        /// <summary>
        /// The network mode of the box.
        /// </summary>
        [XmlAttribute("mode")]
        public NetworkMode NetworkMode { get; set; }
    }
}
