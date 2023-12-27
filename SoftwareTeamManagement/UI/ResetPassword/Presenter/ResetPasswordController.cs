using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.ResetPassword.View;

namespace SoftwareTeamManagement.UI.ResetPassword.Presenter
{
    public class ResetPasswordController
    {
        //Dependency Injection with Singleton...
        private IResetPasswordForm _view = ResetPasswordForm.GetInstance();

        public ResetPasswordController()
        {
            _view.ExitButtonClicked += OnExitButtonClicked;
            _view.GoBackLoginButtonClicked += OnGoBackLoginButtonClicked;
            _view.ResetPasswordClicked += OnResetPasswordButtonClicked;
        }


        //Buttons' events handling
        public void OnExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void OnGoBackLoginButtonClicked(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            ResetPasswordForm.GetInstance().Hide();
        }

        public void OnResetPasswordButtonClicked(object sender, EventArgs e)
        {
            if (ControlPasswords(_view.Password, _view.ConfirmPassowrd))
            {
                //execute database

                string email = ForgotPasswordForm.GetInstance().Email;
                TeamMemberRepository repo = new TeamMemberRepository();
                repo.ChangePassword(email, _view.Password);

                LoginForm.GetInstance().Show();
                ResetPasswordForm.GetInstance().Hide();
                LoginForm.GetInstance().passwordTextBox.Text = "";
                CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("You have successfully changed your password!");

            }

        }


        public bool ControlPasswords(string password, string confirmPassword)
        {
            CustomErrorMessageBoxForm message;
            if (!(password.Length == 0 || confirmPassword.Length == 0))
            {
                if (password.Length > 5)
                {
                    if (password == confirmPassword)
                    {
                        return true;
                    }
                    else
                    {
                        message = new CustomErrorMessageBoxForm("Passwords don't match");
                        return false;
                    }
                }
                else
                {
                    message = new CustomErrorMessageBoxForm("Password must be at least 6 digits.");
                    return false;
                }
            }
            else
            {
                message = new CustomErrorMessageBoxForm("Please fill password fields.");
                return false;
            }
        }


    }
}
