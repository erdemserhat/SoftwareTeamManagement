using SoftwareTeamManagement.UI.Login.View;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public partial class ForgotPasswordAuthenticationForm : Form
    {
        private static ForgotPasswordAuthenticationForm? instance;

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
        }

        private void authenticationCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // controls the entered char if it's numeric or not
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goBackToLoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            this.Hide();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ResetPasswordForm.GetInstance().Show();
            this.Hide();
        }
    }
}
