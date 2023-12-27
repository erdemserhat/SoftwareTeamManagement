namespace SoftwareTeamManagement.UI.ResetPassword.View
{
    public interface IForgotPasswordForm
    {
        event EventHandler SearchButtonClicked;
        event EventHandler GoBackLoginButtonClicked;
        event EventHandler ExitButtonClicked;

        string Email { get; }
    }
}
