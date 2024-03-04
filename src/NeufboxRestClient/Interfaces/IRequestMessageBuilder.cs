namespace NeufboxRestClient.Interfaces
{
    /// <summary>
    /// Provide <see cref="HttpRequestMessage"/> generation.
    /// </summary>
    public interface IRequestMessageBuilder
    {
        /// <summary>
        /// Build a <see cref="HttpRequestMessage"/> instance from <paramref name="request"/>.
        /// </summary>
        /// <typeparam name="TRequest">The request type.</typeparam>
        /// <param name="request">The request instance.</param>
        /// <returns>A <see cref="HttpRequestMessage"/> instance.</returns>
        HttpRequestMessage Build<TRequest>(TRequest request);
    }
}
