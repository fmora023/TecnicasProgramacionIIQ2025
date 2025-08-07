using System.Security.Cryptography.X509Certificates;

namespace ClassController.Interfaces
{
    /// <summary>
    /// Interface for a simple calculator.
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Sums the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>input1 + input2</returns>
        public int Sum(int input1, int input2);

        /// <summary>
        /// Mults the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        public int Mult(int input1, int input2);

        /// <summary>
        /// Divs the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        public decimal Div(int input1, int input2);
    }
}
