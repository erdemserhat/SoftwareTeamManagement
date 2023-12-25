using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.ResetPassword.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("OK");
                string email = ForgotPasswordForm.GetInstance().Email;
                TeamMemberRepository repo = new TeamMemberRepository();

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
