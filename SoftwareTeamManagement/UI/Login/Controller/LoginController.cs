using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.Register.View;
using SoftwareTeamManagement.UI.ResetPassword.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.View;
using System.Text.RegularExpressions;

namespace SoftwareTeamManagement.UI.Login.Controller
{
    public class LoginController
    {
        private readonly ILoginForm _view = LoginForm.GetInstance();


        public LoginController()
        {

            // Controller, View'dan gelen olayları dinleyebilir
            _view.ExitButtonClicked += OnExitButtonClicked;
            _view.LoginButtonClicked += OnLoginButtonClicked;
            _view.RegisterButtonClicked += OnRegistertButtonClicked;
            _view.ForgotPasswordClicked += OnForgotPasswordButtonClicked;
        }




        private void OnRegistertButtonClicked(object sender, EventArgs e)
        {
            RegisterForm.GetInstance().Show();
            LoginForm.GetInstance().Hide();

        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {

            string errorMessage = ValidateEmailAndPassword(_view.Email, _view.Password);
            if (errorMessage != null)
            {
                CustomErrorMessageBoxForm messageBox = new CustomErrorMessageBoxForm(errorMessage);

            }
            else
            {
                TeamMemberRepository repository = new TeamMemberRepository();
                if (repository.IsValidUser(_view.Email, _view.Password))
                {
                    Dashboard.GetInstance().userEmail = _view.Email;
                    Dashboard.GetInstance().Show();
                    LoginForm.GetInstance().Hide();


                    CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Succesfully logged in. Welcome!");


                }
                else
                {
                    CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("Invalid email address or password. Please check your credentials and try again.");
                }

            }




        }


        private void OnExitButtonClicked(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void OnForgotPasswordButtonClicked(object sender, EventArgs e)
        {
            ForgotPasswordForm.GetInstance().Show();
            LoginForm.GetInstance().Hide();
        }


        //controls

        public static string ValidateEmailAndPassword(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return "Email or password cannot be empty!";
            }

            if (!IsValidEmail(email))
            {
                return "Invalid email format!";
            }

            if (password.Length < 6)
            {
                return "Password should be at least 6 characters long!";
            }

            // Return null if there are no errors to indicate everything is valid.
            return null;
        }


        private static bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return emailRegex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }
    }
}
