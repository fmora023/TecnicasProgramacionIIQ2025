namespace ClassController.Test
{
    /// <summary>
    /// Test for <see cref="Examples"/>.
    /// </summary>
    [TestClass]
    public class ExamplesTest
    {
        /// <summary>
        /// Tests the elements sum.
        /// </summary>
        [TestMethod]
        public void TestElementsSum()
        {
            // Arrange
            var elements = "1, 2, 3, 4, 5";
        
            // Act
            var result = Examples.ElementsSum(elements);
            
            // Assert
            Assert.AreEqual(15, result);
        }

        /// <summary>
        /// Tests the elements sum finishing with comma.
        /// </summary>
        [TestMethod]
        public void TestElementsSumFinishingWithComma()
        {
            // Arrange
            var elements = "1, 2, 3, 4, 5,6,";
        
            // Act
            var result = Examples.ElementsSum(elements);
            
            // Assert
            Assert.AreEqual(21, result);
        }
    }
}
