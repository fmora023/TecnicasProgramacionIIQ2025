using ClassController.CarProject;

namespace WFViewExample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var userController = new UserOperations(Constants.UsersFileName);
            Application.Run(new LoginFrm(userController));
        }
    }
}