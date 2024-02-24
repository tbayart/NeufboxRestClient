namespace NeufboxRestClient.Interfaces
{
    /// <summary>
    /// Provide hashing functionality.
    /// </summary>
    public interface IHashProcessor
    {
        /// <summary>
        /// Hash a <paramref name="username"/> and a <paramref name="password"/>
        /// with a <paramref name="token"/> and generate a resulting hash value.
        /// </summary>
        /// <param name="token">The token used for hashing.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>The resulting hash value.</returns>
        string ComputeHash(string token, string username, string password);
    }
}
