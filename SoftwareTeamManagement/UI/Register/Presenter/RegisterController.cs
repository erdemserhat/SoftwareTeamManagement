using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.Register.View;

namespace SoftwareTeamManagement.UI.Register.Presenter
{
    public class RegisterController
    {
        private IRegisterForm _view = RegisterForm.GetInstance();

        public RegisterController()
        {
            _view.GoBackButtonClicked += onGoBackButtonClicked;
            _view.ExitButtonClicked += onExitButtonClicked;
            _view.RegisterButtonClicked += onRegisterButtonClicked;




        }

        public void onGoBackButtonClicked(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            RegisterForm.GetInstance().Hide();

        }

        public void onExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void onRegisterButtonClicked(object sender, EventArgs e)
        {
            // Validate user information
            string validationResult = ValidateUserRegistration(_view.Name, _view.Email, _view.Password, _view.ConfirmPassword);

            if (validationResult == "Success")
            {
                RegisterForm.GetInstance().fullName = _view.Name;
                RegisterForm.GetInstance().email = _view.Email;
                RegisterForm.GetInstance().password = _view.Password;
                TeamMemberRepository repo = new TeamMemberRepository();
                if (!repo.IsEmailAlreadyRegistered(_view.Email))
                {

                    RegisterRoleForm.GetInstance().Show();
                    RegisterForm.GetInstance().Hide();
                }
                else
                {
                    CustomErrorMessageBoxForm messageBox = new CustomErrorMessageBoxForm("E-posta address is already registered in the system.");


                }

            }
            else
            {

                CustomErrorMessageBoxForm customMesage = new CustomErrorMessageBoxForm(validationResult);
            }


        }


        //controls

        private string ValidateUserRegistration(string fullName, string email, string password, string confirmPassword)
        {
            // Perform necessary validations
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                return "Please fill in all fields.";
            }

            if (!IsValidEmail(email))
            {
                return "Enter a valid email address.";
            }

            if (password != confirmPassword)
            {
                return "Passwords do not match.";
            }
            if (password.Length < 6)
            {
                return "Password must be at least 6 characters long.";
            }


            return "Success";
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }




        }
    }
}
