using ClassExampleModels.Interfaces;

namespace ClassExampleModels
{
    /// <summary>
    /// Car implementation for work purposes.
    /// </summary>
    /// <seealso cref="ClassExampleModels.Interfaces.CarBase" />
    public class WorkCar : CarBase
    {
        /// <summary>
        /// Gets or sets the load capacity.
        /// </summary>
        /// <value>
        /// The load capacity.
        /// </value>
        public int LoadCapacity { get; set; }
    }
}
