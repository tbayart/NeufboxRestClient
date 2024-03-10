namespace NeufboxRestClient.Models
{
    /// <summary>
    /// Attribute used to describe a API request.
    /// </summary>
    /// <remarks>
    /// Initializes a new <see cref="ApiRequestAttribute"/> instance.
    /// </remarks>
    /// <param name="apiMethod">The API method this model is mapped to.</param>
    /// <param name="httpVerb">The http verb to use with the method.</param>
    /// <param name="isPrivate">True if the method is private (require authentication), false otherwise.</param>
    [AttributeUsage(AttributeTargets.Class)]
    public class ApiRequestAttribute(string apiMethod, HttpVerb httpVerb, bool isPrivate) : Attribute
    {
        /// <summary>
        /// The API method from the API specifications.
        /// </summary>
        public string ApiMethod { get; init; } = apiMethod;

        /// <summary>
        /// The http verb to use for this API method.
        /// </summary>
        public HttpVerb HttpVerb { get; init; } = httpVerb;

        /// <summary>
        /// True if the method is private, false otherwise.
        /// A private method require authentication to be performed successfully prior the API method call.
        /// </summary>
        public bool IsPrivate { get; init; } = isPrivate;
    }
}
