using ClassController.CarProject;
using ClassController.Interfaces;
using ClassExampleModels;
using Moq;
using System.Text;

namespace ClassController.Test.CarProject
{
    /// <summary>
    /// Test for <see cref="UserOperations"/>
    /// </summary>
    [TestClass]
    public class UserOperationsTest
    {
        private readonly List<User> users = new List<User>
        {
            new User("0,user1,password1"),
            new User("1,user2,password2"),
        };

        /// <summary>
        /// Users the operations should initialize with elements with Mock.
        /// Unit test.
        /// </summary>
        [TestMethod]
        public void UserOperationsShouldInitializeWithElementsWithMock()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<User>>();
            var fileName = "testFile.txt";
            dataHandlerMock.Setup(x => x.ReadData(fileName)).Returns(users);

            // Act
            var userOperations = new UserOperations(fileName, dataHandlerMock.Object);

            // Assert
            Assert.IsNotNull(userOperations);
            Assert.IsNotNull(userOperations.Users);
            Assert.AreEqual(2, userOperations.Users.Count);
            Assert.AreEqual("user1", userOperations.Users[0].Name);
        }

        /// <summary>
        /// Users the operations should initialize with elements with Real File.
        /// Integration test.
        /// </summary>
        [TestMethod]
        public void UserOperationsShouldInitializeWithElementsWithRealFile()
        {
            // Arrange
            var destination = Path.Combine(Directory.GetCurrentDirectory(), "testFile.csv");
            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

            var dataAsString = new StringBuilder();
            foreach (var user in users)
            {
                dataAsString.Append($"{user.Id},{user.Name},{user.Password}{Environment.NewLine}");
            }

            File.WriteAllText(destination, dataAsString.ToString());

            var dataHandler = new FileHandler<User>();

            // Act
            var userOperations = new UserOperations(destination, dataHandler);

            // Assert
            Assert.IsNotNull(userOperations);
            Assert.IsNotNull(userOperations.Users);
            Assert.AreEqual(2, userOperations.Users.Count);
            Assert.AreEqual("user1", userOperations.Users[0].Name);
        }
    }
}
