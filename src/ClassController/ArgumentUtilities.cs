namespace ClassController
{
    /// <summary>
    /// Class for utilities related to argument handling.
    /// </summary>
    public static class ArgumentUtilities
    {
        /// <summary>
        /// Parses the string to int.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static int? ParseStringToInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
