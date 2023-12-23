using SoftwareTeamManagement.UI.Login.View;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public partial class ForgotPasswordForm : Form
    {
        public static ForgotPasswordForm instance;

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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordAuthenticationForm.GetInstance().Show();
            this.Hide();

        }
    }
}
