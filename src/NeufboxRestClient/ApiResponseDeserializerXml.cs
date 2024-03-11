using NeufboxRestClient.Interfaces;
using NeufboxRestClient.Models;
using System.Xml.Serialization;

namespace NeufboxRestClient
{
    /// <summary>
    /// Implementation of <see cref="ApiResponse"/> deserialization from XML data.
    /// </summary>
    public class ApiResponseDeserializerXml : IApiResponseDeserializer
    {
        /// <summary>
        /// Deserialize the XML data string to the specified .NET type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to</typeparam>
        /// <param name="value">The XML to deserialize</param>
        /// <param name="rootName">Optional root name in XML</param>
        /// <returns>The deserialized object from the XML string</returns>
        public T DeserializeObject<T>(string value, string rootName = null)
        {
            var serializer = rootName == null
                ? new XmlSerializer(typeof(T))
                : new XmlSerializer(typeof(T), new XmlRootAttribute(rootName));

            using var reader = new StringReader(value);
            return (T)serializer.Deserialize(reader);
        }

        /// <summary>
        /// Deserialize the API response to requested type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The result type in the response.</typeparam>
        /// <param name="apiResponseXml">The xml response from the API.</param>
        /// <returns></returns>
        public ApiResult<T> Deserialize<T>(string apiResponseXml)
        {
            var apiResponse = DeserializeObject<ApiResponse>(apiResponseXml);
            return apiResponse.Status == StatusCode.Success
                ? ApiResult<T>.Success(DeserializeObject<T>(apiResponse.Result.OuterXml))
                : ApiResult<T>.Failure(DeserializeObject<ApiError>(apiResponse.Result.OuterXml));
        }
    }
}
