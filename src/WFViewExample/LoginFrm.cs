using ClassController.CarProject;

namespace WFViewExample
{
    /// <summary>
    /// Login View Form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginFrm : Form
    {
        private UserOperations UserOperations { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginFrm"/> class.
        /// </summary>
        /// <param name="operations">The operations.</param>
        public LoginFrm(UserOperations operations)
        {
            InitializeComponent();
            this.UserOperations = operations;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var username = UserTxt.Text;
            var password = PasswordTxt.Text;
            var hasLoggedIn = this.UserOperations.Login(username, password);
            if (hasLoggedIn)
            {
                MessageBox.Show("Login successful!");
                var mainForm = new Form1();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your username and password.");
                this.UserTxt.Text = string.Empty;
                this.PasswordTxt.Text = string.Empty;
            }
        }
    }
}
