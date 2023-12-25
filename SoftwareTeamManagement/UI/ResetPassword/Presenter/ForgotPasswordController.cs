using SoftwareTeamManagement.BusinessLogic.Email;
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
    public class ForgotPasswordController
    {
        private static IForgotPasswordForm _view = ForgotPasswordForm.GetInstance();

        public ForgotPasswordController()
        {
            _view.ExitButtonClicked += OnExitButtonClicked;
            _view.GoBackLoginButtonClicked += OnGoBackLoginButtonClicked;
            _view.SearchButtonClicked += OnSearchButtonClicked;

        }

        //event handling

        //Exit Button
        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Go back to login button
        private void OnGoBackLoginButtonClicked(object sender, EventArgs e)
        {

            LoginForm.GetInstance().Show();
            ForgotPasswordForm.GetInstance().Hide();

        }

        //Search button

        private   void OnSearchButtonClicked(object sender, EventArgs e)
        {
            if (IsStringValid(_view.Email))
            {
                TeamMemberRepository repo = new TeamMemberRepository();

                if (repo.IsEmailAlreadyRegistered(_view.Email))
                {
                    Random random = new Random();
                    int code = random.Next(100000, 1000000);

                    if (SendEmailService.SendMail(_view.Email, "Password Reset Request", EmailPreparation.PrepareEmailBody(_view.Email, code)))
                    {
                        ForgotPasswordAuthenticationForm.GetInstance().Show();
                        ForgotPasswordForm.GetInstance().Hide();     
                        CustomSuccessMessageBoxForm custom = new CustomSuccessMessageBoxForm("Email sent successfully!");
                        ForgotPasswordAuthenticationForm.GetInstance().Show();
                        ForgotPasswordForm.GetInstance().Hide();                     
                        ForgotPasswordAuthenticationForm.GetInstance().authCode= code;
                        ForgotPasswordAuthenticationController.ResetCounter();
                       


                    }

                }
                else
                {
                    CustomErrorMessageBoxForm custom = new CustomErrorMessageBoxForm("Password reset failed. The provided email address is not registered in our system.");
                }

            }
        }

        //controls

        public bool IsStringValid(string input)
        {
            // Check if the string is empty or consists only of whitespace
            if (string.IsNullOrWhiteSpace(input))
            {
                CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("Email adress cannot be empty or consist only of whitespace.");
                return false;
            }

            // Check if the string is in email format
            if (!IsEmailFormatValid(input))
            {
                CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("Invalid email format.");
                return false;
            }

            // Return true if it passes both checks
            return true;
        }

        private bool IsEmailFormatValid(string email)
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
