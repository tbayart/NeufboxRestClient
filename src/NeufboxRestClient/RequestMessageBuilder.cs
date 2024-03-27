using NeufboxRestClient.Interfaces;
using NeufboxRestClient.Internal;
using System.Reflection;
using Toolbox;

namespace NeufboxRestClient
{
    /// <summary>
    /// Provide <see cref="HttpRequestMessage"/> generation.
    /// </summary>
    public class RequestMessageBuilder : IRequestMessageBuilder
    {
        #region fields
        private delegate HttpRequestMessage BuildRequestMessageDelegate(QueryString queryString, IEnumerable<KeyValuePair<string, string>> parameters);
        #endregion fields

        #region IRequestMessageBuilder
        /// <summary>
        /// Build a <see cref="HttpRequestMessage"/> instance from <paramref name="request"/>.
        /// </summary>
        /// <typeparam name="TRequest">The request type.</typeparam>
        /// <param name="request">The request instance.</param>
        /// <returns>A <see cref="HttpRequestMessage"/> instance.</returns>
        public HttpRequestMessage Build<TRequest>(TRequest request)
        {
            var typeRequest = typeof(TRequest);
            var attribute = typeRequest.GetCustomAttribute<ApiRequestAttribute>();
            var queryString = new QueryString("method", attribute.ApiMethod);

            BuildRequestMessageDelegate messageBuilder = attribute.HttpVerb switch
            {
                HttpVerb.GET => BuildGetRequestMessage,
                HttpVerb.POST => BuildPostRequestMessage,
                _ => throw new NotImplementedException($"HttpVerb {attribute.HttpVerb}")
            };

            var parameters = typeRequest.GetProperties()
                .ToDictionary(o => o.Name.ToLower(), o => o.GetValue(request))
                .Where(o => o.Value != null)
                .ToDictionary(o => o.Key, o => o.Value.ToString());
            var httpRequestMessage = messageBuilder(queryString, parameters);

            return httpRequestMessage;
        }
        #endregion IRequestMessageBuilder

        #region methods
        private HttpRequestMessage BuildGetRequestMessage(QueryString queryString, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            foreach (var parameter in parameters)
            {
                queryString.Add(parameter.Key, parameter.Value);
            }
            var uri = new Uri(queryString.Value, UriKind.Relative);
            return new HttpRequestMessage(HttpMethod.Get, uri);
        }

        private HttpRequestMessage BuildPostRequestMessage(QueryString queryString, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            var content = new FormUrlEncodedContent(parameters);
            var uri = new Uri(queryString.Value, UriKind.Relative);
            return new HttpRequestMessage(HttpMethod.Get, uri) { Content = content };
        }
        #endregion methods
    }
}
