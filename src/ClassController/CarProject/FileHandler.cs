using ClassController.Interfaces;
using System.Runtime.InteropServices;
using System.Text;

namespace ClassController.CarProject
{
    /// <summary>
    /// Impltation of result handling operations when we are using the filesystem.
    /// </summary>
    /// <seealso cref="ClassController.Interfaces.IDataHandler" />
    internal class FileHandler<T> : IDataHandler<T>
        where T : class
    {
        /// <summary>
        /// Reads the result.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>the result in a List</returns>
        public IList<T> ReadData(string source)
        {
            if (string.IsNullOrEmpty(source) || !File.Exists(source))
            {
                return new List<T>();
            }

            var result = new List<T>();
            var lines = File.ReadAllLines(source);

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                try
                {
                    var item = Activator.CreateInstance(typeof(T), line) as T;
                    if (item != null)
                    {
                        result.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating instance of {typeof(T).Name} from line: {line}. Exception: {ex.Message}");
                }
            }

            return result;
        }

        /// <summary>
        /// Writes the result.
        /// </summary>
        /// <param name="destination">The destination.</param>
        /// <param name="data">The result.</param>
        /// <returns>
        /// true if the result was written successfully; otherwise, false.
        /// </returns>
        public bool WriteData(string destination, IList<T> data)
        {
            if (data == null || string.IsNullOrEmpty(destination) || data.Count == 0)
            {
                return false;
            }

            if (!Directory.Exists(Path.GetDirectoryName(destination)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(destination)!);
            }

            var dataAsString = new StringBuilder();

            foreach(var item in data)
            {
                dataAsString.Append($"{item.ToString()}{Environment.NewLine}");
            }

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

            File.WriteAllText(destination, dataAsString.ToString());
            return true;
        }
    }
}
