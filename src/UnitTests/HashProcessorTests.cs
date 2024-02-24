using FluentAssertions;
using NeufboxRestClient;

namespace UnitTests
{
    /// <summary>
    /// Tests related to <see cref="HashProcessor"/> class.
    /// </summary>
    public class HashProcessorTests
    {
        /// <summary>
        /// Test token from API reference.
        /// </summary>
        private const string token = "43f6168e635b9a90774cc4d3212d5703c11c9302";

        /// <summary>
        /// Username used in test.
        /// </summary>
        private const string username = "admin";

        /// <summary>
        /// Password used in test.
        /// </summary>
        private const string password = "admin";

        /// <summary>
        /// Expected resulting hash.
        /// </summary>
        private const string expectedHash = "7aa3e8b3ed7dfd7796800b4c4c67a0c56c5e4a66502155c17a7bcef5ae945ffa7aa3e8b3ed7dfd7796800b4c4c67a0c56c5e4a66502155c17a7bcef5ae945ffa";

        /// <summary>
        /// Unit test for <see cref="HashProcessor.ComputeHash(string, string, string)"/>.
        /// </summary>
        [Fact]
        public void ComputeHashTest()
        {
            var hashProcessor = new HashProcessor();
            var hash = hashProcessor.ComputeHash(token, username, password);
            hash.Should().HaveLength(128);
            hash.Should().Be(expectedHash);
        }
    }
}
