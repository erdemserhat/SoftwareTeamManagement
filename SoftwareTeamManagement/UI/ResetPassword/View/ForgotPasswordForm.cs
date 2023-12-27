using SoftwareTeamManagement.UI.ResetPassword.Presenter;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public partial class ForgotPasswordForm : Form, IForgotPasswordForm
    {
        public static ForgotPasswordForm instance;

        public string Email => emailTextBox.Text;

        public event EventHandler SearchButtonClicked;
        public event EventHandler GoBackLoginButtonClicked;
        public event EventHandler ExitButtonClicked;

        public static ForgotPasswordForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ForgotPasswordForm();
            }
            return instance;
        }
        public ForgotPasswordForm()
        {
            InitializeComponent();
            instance = this;
            ForgotPasswordController controller = new ForgotPasswordController();

            searchBtn.Click += (sender, e) => SearchButtonClicked?.Invoke(this, EventArgs.Empty);
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
            goBackToLoginBtn.Click += (sender, e) => GoBackLoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
