using NeufboxRestClient.Models;

namespace NeufboxRestClient.Interfaces
{
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
