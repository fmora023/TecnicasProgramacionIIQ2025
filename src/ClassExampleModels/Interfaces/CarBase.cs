namespace ClassExampleModels.Interfaces
{
    /// <summary>
    /// Abstract class to represent a car.
    /// </summary>
    public abstract class CarBase
    {
        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>
        /// The brand.
        /// </value>
        public string Brand { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>
        /// The year.
        /// </value>
        public int Year { get; set; }
    }
}
