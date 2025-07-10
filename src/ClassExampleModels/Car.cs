using ClassExampleModels.Interfaces;

namespace ClassExampleModels
{
    /// <summary>
    /// Implementation of a car model.
    /// </summary>
    /// <seealso cref="ClassExampleModels.Interfaces.CarBase" />
    public class Car : CarBase
    {
        /// <summary>
        /// Gets or sets the passenger capacity.
        /// </summary>
        /// <value>
        /// The passenger capacity.
        /// </value>
        public int PassengerCapacity { get; set; }
    }
}
