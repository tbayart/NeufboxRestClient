namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Represents a network interface.
    /// </summary>
    /// <param name="Name">The interface name.</param>
    /// <param name="Mac">The interface MAC Address.</param>
    public record NetworkInterface(string Name, string Mac);
}
