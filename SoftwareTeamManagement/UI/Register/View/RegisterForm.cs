using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.Register.Presenter;

namespace SoftwareTeamManagement.UI.Register.View
{
    public partial class RegisterForm : Form, IRegisterForm
    {
        private static RegisterForm instance;

        public event EventHandler RegisterButtonClicked;
        public event EventHandler GoBackButtonClicked;
        public event EventHandler ExitButtonClicked;

        public string Email => emailTextBox.Text;

        public string Password => passwordTextBox.Text;

        public string ConfirmPassword => confirmPasswordTextBox.Text;

        public static RegisterForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new RegisterForm();
            }
            return instance;
        }
        public RegisterForm()
        {
            InitializeComponent();
            instance = this;
            RegisterController controller = new RegisterController();
            exitBtn.Click += ExitButtonClicked;
            goBackToLoginBtn.Click += (sender, e) => GoBackButtonClicked?.Invoke(this, EventArgs.Empty);
            registerBtn.Click += (sender, e) => RegisterButtonClicked?.Invoke(this, EventArgs.Empty);

        }


    }
}
