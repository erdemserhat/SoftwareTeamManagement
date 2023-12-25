using SoftwareTeamManagement.UI.Login.View;

namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public partial class ResetPasswordForm : Form
    {
        private static ResetPasswordForm? instance;

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
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            //handle process

            ////.....
            ///
            //
            LoginForm.GetInstance().Show();
            this.Hide();

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            this.Hide();
        }
    }
}
