using NeufboxRestClient.Internal.Models;

namespace NeufboxRestClient.Interfaces
{
    /// <summary>
    /// API response deserialization definition.
    /// </summary>
    public interface IApiResponseDeserializer
    {
        /// <summary>
        /// Deserialize the API response to requested type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The result type in the response.</typeparam>
        /// <param name="apiResponse">The response from the API.</param>
        /// <returns></returns>
        ApiResult<T> Deserialize<T>(string apiResponse);
    }
}
