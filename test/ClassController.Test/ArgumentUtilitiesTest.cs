namespace ClassController.Test
{
    /// <summary>
    /// Test for <see cref="ArgumentUtilities"/>.
    /// </summary>
    [TestClass]
    public class ArgumentUtilitiesTest
    {
        /// <summary>
        /// Parses the string to int should parse the integer.
        /// </summary>
        [TestMethod]
        public void ParseStringToIntShouldParseTheInteger()
        {
            // Arrange
            var parse = "3";

            // Act
            var result = ArgumentUtilities.ParseStringToInt(parse);

            // Assert
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Parses the string to int should return null.
        /// </summary>
        [TestMethod]
        public void ParseStringToIntShouldReturnNull()
        {
            // Arrange
            var input = "*";

            // Act
            var result = ArgumentUtilities.ParseStringToInt(input);

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Parses the string to bigger int should return null.
        /// </summary>
        [TestMethod]
        public void ParseStringToBiggerIntShouldReturnNull()
        {
            // Arrange
            var input = "2147483649";

            // Act
            var result = ArgumentUtilities.ParseStringToInt(input);

            // Assert
            Assert.IsNull(result);
        }
    }
}
