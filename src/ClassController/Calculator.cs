using ClassController.Interfaces;

namespace ClassController
{
    /// <summary>
    /// Calculator operations implementation.
    /// </summary>
    /// <seealso cref="ClassController.Interfaces.ICalculator" />
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Divs the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        public decimal Div(int input1, int input2)
        {
            /*if (input2 == 0)
            {
                return 0;
            }
            */
            return input1 / input2;
        }

        /// <summary>
        /// Mults the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns></returns>
        public int Mult(int input1, int input2)
        {
            return input1 * input2;
        }

        /// <summary>
        /// Sums the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        /// input1 + input2
        /// </returns>
        public int Sum(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
