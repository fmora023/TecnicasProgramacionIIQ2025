using ClassController.Interfaces;

namespace ClassController
{
    public class Calculator : ICalculator
    {
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
