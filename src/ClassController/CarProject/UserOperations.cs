using ClassController.Interfaces;
using ClassExampleModels;

namespace ClassController.CarProject
{
    /// <summary>
    /// Class in charge of user operations.
    /// </summary>
    public class UserOperations
    {
        private string FileName { get; set; }

        public List<User> Users { get; set; }

        private IDataHandler<User> DataHandler { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOperations"/> class.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public UserOperations(string fileName, IDataHandler<User> handler)
        {
            FileName = fileName;
            DataHandler = handler;
            Users = Load();
        }

        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            foreach (var user in Users)
            {
                if (user.Name.Equals(username) && user.Password.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }

        private List<User> Load()
        {
            return (List<User>)this.DataHandler.ReadData(this.FileName);
        }
    }
}
