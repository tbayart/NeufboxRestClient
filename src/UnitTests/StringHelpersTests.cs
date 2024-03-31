using FluentAssertions;
using Toolbox;

namespace UnitTests
{
    /// <summary>
    /// Tests related to <see cref="StringHelpers"/> class.
    /// </summary>
    public class StringHelpersTests
    {
        /// <summary>
        /// Byte array version of data.
        /// </summary>
        public static readonly byte[] expectedResultHexArray = [
            0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b,
            0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x21, 0x32, 0x43, 0x54, 0x65, 0x76, 0x87,
            0x98, 0xa9, 0xba, 0xcb, 0xdc, 0xed, 0xfe, 0xff, 0xee, 0xdd, 0xcc, 0xbb,
            0xaa, 0x99, 0x88, 0x77, 0x66, 0x55, 0x44, 0x33, 0x22, 0x11, 0x00, 0xff
        ];

        /// <summary>
        /// String representation of previous byte array.
        /// </summary>
        public const string expectedResultHexString =
            "000102030405060708090a0b0c0d0e0f102132435465768798a9bacbdcedfeffeeddccbbaa99887766554433221100ff";

        /// <summary>
        /// Unit test for <see cref="StringHelpers.ArrayToHex(byte[], bool)"/> with default lower casing.
        /// </summary>
        [Fact]
        public void ArrayToHexTest()
        {
            var result = expectedResultHexArray.ArrayToHex();
            result.Should().Be(expectedResultHexString);
        }

        /// <summary>
        /// Unit test for <see cref="StringHelpers.HexToArray(string)"/> with default lower casing.
        /// </summary>
        [Fact]
        public void HexToArrayTest()
        {
            var result = expectedResultHexString.HexToArray();
            result.Should().BeEquivalentTo(expectedResultHexArray, options => options.WithStrictOrdering());
        }

        /// <summary>
        /// Unit test for <see cref="StringHelpers.ArrayToHex(byte[], bool)"/> with upper casing.
        /// </summary>
        [Fact]
        public void ArrayToHexUpperCaseTest()
        {
            var result = expectedResultHexArray.ArrayToHex(true);
            result.Should().Be(expectedResultHexString.ToUpper());
        }

        /// <summary>
        /// Unit test for <see cref="StringHelpers.HexToArray(string)"/> with upper casing.
        /// </summary>
        [Fact]
        public void HexToArrayUpperCaseTest()
        {
            var result = expectedResultHexString.ToUpper().HexToArray();
            result.Should().BeEquivalentTo(expectedResultHexArray, options => options.WithStrictOrdering());
        }
    }
}
