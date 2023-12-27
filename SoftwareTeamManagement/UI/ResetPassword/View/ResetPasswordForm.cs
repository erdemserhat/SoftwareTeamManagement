using SoftwareTeamManagement.UI.ResetPassword.Presenter;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public partial class ResetPasswordForm : Form, IResetPasswordForm
    {
        private static ResetPasswordForm? instance;

        public event EventHandler ResetPasswordClicked;
        public event EventHandler GoBackLoginButtonClicked;
        public event EventHandler ExitButtonClicked;

        public string Password => resetPasswordTextBox.Text;


        public string ConfirmPassowrd => resetPasswordConfirmTextBox.Text;

        public static ResetPasswordForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ResetPasswordForm();
            }
            return instance;
        }
        public ResetPasswordForm()
        {
            InitializeComponent();
            instance = this;
            //init. impl.
            ResetPasswordController controller = new ResetPasswordController();


            resetPasswordButton.Click += (sender, e) => ResetPasswordClicked?.Invoke(this, EventArgs.Empty);
            goBackLoginBtn.Click += (sender, e) => GoBackLoginButtonClicked?.Invoke(this, EventArgs.Empty);
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
