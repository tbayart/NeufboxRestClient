namespace Toolbox
{
    /// <summary>
    /// Helper methods to manipulate strings.
    /// </summary>
    public static class StringHelpers
    {
        #region hexadecimal convertion
        /// <summary>
        /// Used to convert a numeric value to its lower case character representation.
        /// </summary>
        private static string hexTableLowerCase = "0123456789abcdef";

        /// <summary>
        /// Used to convert a numeric value to its upper case character representation.
        /// </summary>
        private static string hexTableUpperCase = "0123456789ABCDEF";

        /// <summary>
        /// Used to convert a character to its numeric value.
        /// </summary>
        private static Dictionary<char, byte> charToByte = new Dictionary<char, byte> {
            {'0', 0x00 }, {'1', 0x01 }, {'2', 0x02 }, {'3', 0x03 },
            {'4', 0x04 }, {'5', 0x05 }, {'6', 0x06 }, {'7', 0x07 },
            {'8', 0x08 }, {'9', 0x09 }, {'a', 0x0a }, {'b', 0x0b },
            {'c', 0x0c }, {'d', 0x0d }, {'e', 0x0e }, {'f', 0x0f },
            {'A', 0X0A }, {'B', 0X0B }, {'C', 0X0c }, {'D', 0X0D },
            {'E', 0X0E }, {'F', 0X0F }
        };

        /// <summary>
        /// Convert a string containing HEX values to a byte array
        /// </summary>
        /// <param name="source">The string containing HEX values</param>
        /// <returns>The resulting byte array</returns>
        public static byte[] HexToArray(this string source)
        {
            var result = new byte[source.Length >> 1];
            var indexSource = 0;
            var indexResult = 0;
            while (indexSource < source.Length)
            {
                var value = charToByte[source[indexSource++]];
                value <<= 4;
                value += charToByte[source[indexSource++]];
                result[indexResult++] = value;
            }
            return result;
        }

        /// <summary>
        /// Convert a byte array to a string containing HEX values
        /// </summary>
        /// <param name="source">The byte array</param>
        /// <param name="toUpperCase">True to get an upper case output, false otherwise.</param>
        /// <returns>The resulting string containing HEX values</returns>
        public static string ArrayToHex(this byte[] source, bool toUpperCase = false)
        {
            var hexTable = toUpperCase ? hexTableUpperCase : hexTableLowerCase;
            var hex = new char[source.Length * 2];
            var index = 0;
            foreach (byte b in source)
            {
                hex[index++] = hexTable[b >> 4];
                hex[index++] = hexTable[b & 0x0F];
            }
            return new string(hex);
        }
        #endregion hexadecimal convertion
    }
}
