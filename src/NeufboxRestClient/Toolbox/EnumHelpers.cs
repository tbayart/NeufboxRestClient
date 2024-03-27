namespace NeufboxRestClient.Toolbox
{
    /// <summary>
    /// Helper methods to work with enums.
    /// </summary>
    public static class EnumHelpers
    {
        /// <summary>
        /// Convert an enum value to another enum type sharing the same value name.
        /// </summary>
        /// <typeparam name="TSource">The source enum type.</typeparam>
        /// <typeparam name="TResult">The resulting enum type.</typeparam>
        /// <param name="source">The original value to convert.</param>
        /// <returns>The converted value.</returns>
        public static TResult CastByName<TSource, TResult>(this TSource source)
            where TSource : Enum
            where TResult : Enum
        {
            return (TResult)Enum.Parse(typeof(TResult), source.ToString());
        }

        /// <summary>
        /// Convert an enum value to another enum type sharing the same value name.
        /// </summary>
        /// <typeparam name="TSource">The source enum type.</typeparam>
        /// <typeparam name="TResult">The resulting enum type.</typeparam>
        /// <param name="source">The original value to convert.</param>
        /// <param name="result">To store the converted value.</param>
        public static void CastByName<TSource, TResult>(this TSource source, out TResult result)
            where TSource : Enum
            where TResult : Enum
        {
            result = source.CastByName<TSource, TResult>();
        }
    }
}
