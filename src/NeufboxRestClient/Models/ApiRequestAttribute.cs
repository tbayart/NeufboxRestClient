namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Attribute used to describe a API request.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiRequestAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new <see cref="ApiRequestAttribute"/> instance.
        /// </summary>
        /// <param name="apiMethod"></param>
        /// <param name="httpVerb"></param>
        public ApiRequestAttribute(string apiMethod, HttpVerb httpVerb)
        {
            ApiMethod = apiMethod;
            HttpVerb = httpVerb;
        }

        /// <summary>
        /// The API method from the API specifications.
        /// </summary>
        public string ApiMethod { get; init; }

        /// <summary>
        /// The http verb to use for this API method.
        /// </summary>
        public HttpVerb HttpVerb { get; init; }
    }
}
