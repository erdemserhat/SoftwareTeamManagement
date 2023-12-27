namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public interface IForgotPasswordAuthenticationForm
    {
        public string Code { get; }
        event EventHandler ConfirmButtonClicked;
        event EventHandler GoBackLoginClicked;
        event EventHandler ExitButtonClicked;

    }
}
