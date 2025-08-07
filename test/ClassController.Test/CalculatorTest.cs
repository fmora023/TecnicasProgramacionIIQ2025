namespace ClassController.Test
{
    /// <summary>
    /// Test for <see cref="Calculator"/>.
    /// </summary>
    [TestClass]
    public class CalculatorTest
    {
        /// <summary>
        /// Tests the sum.
        /// </summary>
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 5;
            var input2 = 10;

            // Act
            var result = calculator.Sum(input1, input2);

            // Assert
            Assert.AreEqual(15, result);
        }

        /// <summary>
        /// Tests the mult.
        /// </summary>
        [TestMethod]
        public void TestMult()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 5;
            var input2 = 10;

            // Act
            var result = calculator.Mult(input1, input2);

            // Assert
            Assert.AreEqual(50, result);
        }

        /// <summary>
        /// Tests the mult with negative numbers.
        /// </summary>
        [TestMethod]
        public void TestMultWithNegativeNumbers()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = -5;
            var input2 = 10;

            // Act
            var result = calculator.Mult(input1, input2);
            // Assert
            Assert.AreEqual(-50, result);
        }

        /// <summary>
        /// Tests the div.
        /// </summary>
        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 10;
            var input2 = 2;

            // Act
            var result = calculator.Div(input1, input2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestDivByZero()
        {
            // Arrange
            var calculator = new Calculator();
            var input1 = 10;
            var input2 = 0;
            
            // Act 
            // var result = calculator.Div(input1, input2);
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Div(input1, input2));

            // Assert
            //Assert.AreEqual(0, result);
        }
    }
}
