using NeufboxRestClient.Interfaces;
using System.Security.Cryptography;
using System.Text;
using Toolbox;

namespace NeufboxRestClient
{
    /// <summary>
    /// Hashing functionality implementation.
    /// </summary>
    public class HashProcessor : IHashProcessor
    {
        /// <summary>
        /// Hash a <paramref name="username"/> and a <paramref name="password"/>
        /// with a <paramref name="token"/> and generate a resulting hash value.
        /// </summary>
        /// <param name="token">The token used for hashing.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>The resulting hash value.</returns>
        public string ComputeHash(string token, string username, string password)
        {
            var key = Encoding.ASCII.GetBytes(token);
            username = ComputeHash(key, username);
            password = ComputeHash(key, password);
            return string.Concat(username, password);
        }

        /// <summary>
        /// Hash a value with a key.
        /// </summary>
        /// <param name="key">The key for HMAC hashing.</param>
        /// <param name="value">The value to hash.</param>
        /// <returns>The resulting hash value.</returns>
        internal string ComputeHash(byte[] key, string value)
        {
            var value_bytes = Encoding.ASCII.GetBytes(value);
            var hash_bytes = SHA256.HashData(value_bytes);
            var hash = hash_bytes.ArrayToHex();
            hash_bytes = Encoding.ASCII.GetBytes(hash);
            return HMACSHA256.HashData(key, hash_bytes).ArrayToHex();
        }
    }
}
