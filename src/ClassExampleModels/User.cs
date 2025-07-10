namespace ClassExampleModels
{
    /// <summary>
    /// Model representation of a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public User(string user)
        {
            if (string.IsNullOrEmpty(user))
            {
                throw new ArgumentException("User cannot be null or empty", nameof(user));
            }
            var parts = user.Split(',');
            this.Id = parts[0];
            this.Name = parts[1];
            this.Password = parts[2];
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; } = string.Empty;
    }
}
