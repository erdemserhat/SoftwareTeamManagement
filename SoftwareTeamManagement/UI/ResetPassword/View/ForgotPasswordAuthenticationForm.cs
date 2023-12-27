using SoftwareTeamManagement.UI.ResetPassword.Presenter;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public partial class ForgotPasswordAuthenticationForm : Form, IForgotPasswordAuthenticationForm
    {
        public int authCode;
        private static ForgotPasswordAuthenticationForm? instance;

        public event EventHandler ConfirmButtonClicked;
        public event EventHandler GoBackLoginClicked;
        public event EventHandler ExitButtonClicked;


        public string Code => authenticationCodeTextBox.Text;

        public static ForgotPasswordAuthenticationForm? GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ForgotPasswordAuthenticationForm();

            }
            return instance;
        }


        public ForgotPasswordAuthenticationForm()
        {
            InitializeComponent();
            instance = this;
            ForgotPasswordAuthenticationController controller = new ForgotPasswordAuthenticationController();
            confirmButton.Click += (sender, e) => ConfirmButtonClicked(this, EventArgs.Empty);
            goBackToLoginBtn.Click += (sender, e) => GoBackLoginClicked(this, EventArgs.Empty);
            exitBtn.Click += (sender, e) => ExitButtonClicked(this, EventArgs.Empty);
            authenticationCodeTextBox.MaxLength = 6;
        }

        private void authenticationCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 6 karakterden fazla veya sayısal olmayan karakterlerin engellenmesi
            }
        }
    }
}
