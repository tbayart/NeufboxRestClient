using Microsoft.Extensions.Logging;
using NeufboxRestClient.Interfaces;
using NeufboxRestClient.Internal.Models;
using NeufboxRestClient.Internal.Models.Requests;
using NeufboxRestClient.Models;

namespace NeufboxRestClient
{
    /// <summary>
    /// Implementation of <see cref="INeufboxClient"/> to request Neufbox API.
    /// </summary>
    public partial class NeufboxClient : INeufboxClient
    {
        #region fields
        private readonly ILogger _logger;
        private readonly HttpClient _httpClient;
        private readonly IHashProcessor _hashProcessor;
        private readonly IApiResponseDeserializer _apiResponseDeserializer;
        private readonly IRequestMessageBuilder _requestMessageBuilder;
        #endregion fields

        #region ctor
        /// <summary>
        /// Initialize a new <see cref="NeufboxClient"/> instance.
        /// </summary>
        /// <param name="logger">A <see cref="ILogger"/> instance.</param>
        /// <param name="httpClientFactory">A <see cref="IHttpClientFactory"/> instance.</param>
        /// <param name="hashProcessor">A <see cref="IHashProcessor"/> instance.</param>
        /// <param name="requestMessageBuilder">A <see cref="IRequestMessageBuilder"/> instance.</param>
        /// <param name="apiResponseDeserializer">A <see cref="IApiResponseDeserializer"/> instance.</param>
        public NeufboxClient(ILogger<NeufboxClient> logger, IHttpClientFactory httpClientFactory,
            IHashProcessor hashProcessor, IRequestMessageBuilder requestMessageBuilder,
            IApiResponseDeserializer apiResponseDeserializer)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient("NeufboxClient");
            _requestMessageBuilder = requestMessageBuilder;
            _hashProcessor = hashProcessor;
            _apiResponseDeserializer = apiResponseDeserializer;
        }
        #endregion ctor

        #region INeufboxClient
        /// <summary>
        /// The authentication token.
        /// </summary>
        public string AuthToken { get; private set; }

        /// <summary>
        /// Authenticate the client to allow access to private methods.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>A task instance to provide the asynchronous Login result.</returns>
        public async Task<LoginResult> LoginAsync(string username, string password)
        {
            var getTokenResult = await SendRequestAsync<AuthGetToken, Internal.Models.Responses.AuthGetToken>(new AuthGetToken());
            if (getTokenResult.IsSuccess == false)
                return LoginResultError(getTokenResult.Error);

            var hash = _hashProcessor.ComputeHash(getTokenResult.Data.Token, username, password);
            var checkToken = new AuthCheckToken { Token = getTokenResult.Data.Token, Hash = hash };
            var checkTokenResult = await SendRequestAsync<AuthCheckToken, Internal.Models.Responses.AuthCheckToken>(checkToken);
            if (checkTokenResult.IsSuccess == false)
                return LoginResultError(checkTokenResult.Error);

            AuthToken = checkTokenResult.Data.Token;
            return LoginResult.Success;
        }

        /// <summary>
        /// Neufbox client interface for System related APIs.
        /// </summary>
        public INeufboxModuleSystem System => this;
        #endregion INeufboxClient

        #region methods
        private async Task<ApiResult<TResult>> SendRequestAsync<TRequest, TResult>(TRequest requestModel)
        {
            if (requestModel is AuthenticatedRequest privateMethod)
            {
                if (string.IsNullOrEmpty(AuthToken))
                    throw new UnauthorizedException();
                privateMethod.Token = AuthToken;
            }

            var handler = _requestMessageBuilder.Build(requestModel);
            var response = await _httpClient.SendAsync(handler);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                _logger.Log(LogLevel.Trace, "response {resultType}: {content}", typeof(TResult).Name, responseContent);
                return _apiResponseDeserializer.Deserialize<TResult>(responseContent);
            }
            return ApiResult<TResult>.Failure((int)response.StatusCode, response.ReasonPhrase);
        }

        /// <summary>
        /// Convert <see cref="ApiError"/> to <see cref="LoginResult"/>.
        /// </summary>
        /// <param name="error">The <see cref="ApiError"/> instance.</param>
        /// <returns>A <see cref="LoginResult"/> value.</returns>
        private static LoginResult LoginResultError(ApiError error)
        {
            try { return (LoginResult)error.Code; }
            catch { return LoginResult.Error; }
        }
        #endregion methods
    }
}
