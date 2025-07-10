using System.Collections;

namespace ClassController.Interfaces
{
    /// <summary>
    /// Interface for data handling operations.
    /// </summary>
    public interface IDataHandler<T>
    {
        /// <summary>
        /// Reads the data.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public IList<T> ReadData(string source);

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <param name="destination">The destination.</param>
        /// <param name="data">The data.</param>
        /// <returns>
        ///     true if the data was written successfully; otherwise, false.
        /// </returns>
        public bool WriteData(string destination, IList<T> data);
    }
}
