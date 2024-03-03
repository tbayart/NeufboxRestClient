namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Used to store the <see cref="NeufboxClient"/> settings.
    /// </summary>
    public class NeufboxSettings
    {
        /// <summary>
        /// The box's default host.
        /// </summary>
        public const string defaultHost = "192.168.1.1";

        /// <summary>
        /// The host or ip address of the box.
        /// </summary>
        /// <example></example>
        public string Host { get; set; } = defaultHost;
    }
}
