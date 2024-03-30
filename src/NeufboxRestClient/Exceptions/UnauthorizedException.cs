namespace NeufboxRestClient
{
    /// <summary>
    /// The exception that is thrown when a private method is called with a client not logged in.
    /// </summary>
    public class UnauthorizedException : Exception
    {
        /// <summary>
        /// Default exception message.
        /// </summary>
        public const string defaultMessage = "The client is not logged in"; 

        /// <summary>
        /// Creates a new <see cref="UnauthorizedException"/> with its message string set to a default message explaining the client is not logged in.
        /// </summary>
        public UnauthorizedException()
            : this(defaultMessage)
        {
        }

        /// <summary>
        /// Creates a new <see cref="UnauthorizedException"/> with a provided message string.
        /// </summary>
        /// <param name="message">The message string.</param>
        public UnauthorizedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="UnauthorizedException"/> with a provided message string and a inner exception.
        /// </summary>
        /// <param name="message">The message string.</param>
        /// <param name="innerException">The inner exception.</param>
        public UnauthorizedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
