using System.Text;
using System.Text.Encodings.Web;

namespace Toolbox
{
    /// <summary>
    /// Handles a query string.
    /// </summary>
    public class QueryString
    {
        #region fields
        /// <summary>
        /// Root character of query string.
        /// </summary>
        private const char prefixRoot = '?';

        /// <summary>
        /// Character used to separate query string parameters.
        /// </summary>
        private const char prefixSeparator = '&';

        /// <summary>
        /// Character to separate parameter's name from it's value.
        /// </summary>
        private const char equal = '=';

        /// <summary>
        /// The next prefix to use on append.
        /// </summary>
        private char prefix;

        /// <summary>
        /// Internal buffer to store the query string value.
        /// </summary>
        private StringBuilder _value;
        #endregion fields

        #region ctor
        /// <summary>
        /// Initializes an empty QueryString instance.
        /// </summary>
        public QueryString()
        {
            Clear();
        }

        /// <summary>
        /// Initializes a QueryString instance with a parameter.
        /// </summary>
        public QueryString(string name, string value)
            : this()
        {
            Add(name, value);
        }
        #endregion ctor

        #region properties
        /// <summary>
        /// Provide the query string value.
        /// </summary>
        public string Value => _value.ToString();
        #endregion properties

        #region methods
        /// <summary>
        /// Append a new parameter to the end of the query string.
        /// </summary>
        /// <param name="name">The parameter's name. This value cannot be null or empty.</param>
        /// <param name="value">The parameter value.</param>
        /// <returns>The current instance to allow chaining calls.</returns>
        /// <exception cref="ArgumentNullException">The <paramref name="name"/> is mandatory and cannot be null.</exception>
        public QueryString Add(string name, string value)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            _value.Append(prefix)
                .Append(UrlEncoder.Default.Encode(name))
                .Append(equal)
                .Append(UrlEncoder.Default.Encode(value));
            prefix = prefixSeparator;

            return this;
        }

        /// <summary>
        /// Clear the query string.
        /// </summary>
        /// <returns>The current instance to allow chaining calls.</returns>
        public QueryString Clear()
        {
            prefix = prefixRoot;
            _value = new StringBuilder();
            return this;
        }

        /// <summary>
        /// Provide the query string value.
        /// </summary>
        /// <returns>The query string value.</returns>
        public override string ToString()
        {
            return Value;
        }
        #endregion methods
    }
}
