using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.ResetPassword.View;

namespace SoftwareTeamManagement.UI.ResetPassword.Presenter
{
    public class ForgotPasswordAuthenticationController
    {
        static int EmailCounter = 4;
        public IForgotPasswordAuthenticationForm _view = ForgotPasswordAuthenticationForm.GetInstance();

        public ForgotPasswordAuthenticationController()
        {
            _view.ExitButtonClicked += OnExitButtonClicked;
            _view.ConfirmButtonClicked += OnConfirmButtonClicked;
            _view.GoBackLoginClicked += OnGoBackLoginClicked;
            EmailCounter = 4;

        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnConfirmButtonClicked(object sender, EventArgs e)
        {
            string temp = _view.Code;
            int userEnteredCode = Convert.ToInt32(temp);
            int sendedCode = ForgotPasswordAuthenticationForm.GetInstance().authCode;

            if (userEnteredCode == sendedCode)
            {
                ResetPasswordForm.GetInstance().Show();
                ForgotPasswordAuthenticationForm.GetInstance().Hide();
                CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Code accepted!");


            }
            else
            {
                EmailCounter--;
                CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm($"Code was wrong! \nRemaining attempts: {EmailCounter}");
                if (EmailCounter == 0)
                {
                    LoginForm.GetInstance().Show();
                    ForgotPasswordAuthenticationForm.GetInstance().Hide();
                    message = new CustomErrorMessageBoxForm("Warning: Restricted Access Due to Multiple Login Attempts");

                }
            }


        }

        private void OnGoBackLoginClicked(object sender, EventArgs e)
        {
            LoginForm.GetInstance().Show();
            ForgotPasswordAuthenticationForm.GetInstance().Hide();

        }

        public static void ResetCounter()
        {
            EmailCounter = 4;
        }




    }
}
