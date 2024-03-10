namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Used to store the <see cref="NeufboxClient"/> settings.
    /// </summary>
    public class NeufboxSettings
    {
        /// <summary>
        /// The box's default scheme.
        /// </summary>
        public const string defaultScheme = "http";

        /// <summary>
        /// The box's default host.
        /// </summary>
        public const string defaultHost = "192.168.1.1";

        /// <summary>
        /// The API's default path.
        /// </summary>
        public const string defaultApiPath = "/api/1.0";

        /// <summary>
        /// The scheme to call the API.
        /// Defaulted to http
        /// </summary>
        public string Scheme { get; set; } = defaultScheme;

        /// <summary>
        /// The host or ip address of the box.
        /// Default is 192.168.1.1
        /// </summary>
        public string Host { get; set; } = defaultHost;

        /// <summary>
        /// The path to request the API.
        /// Default is /api/1.0
        /// </summary>
        public string ApiPath { get; set; } = defaultApiPath;
    }
}
