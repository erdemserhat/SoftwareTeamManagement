namespace SoftwareTeamManagement.UI.Login.View
{
    public interface ILoginForm
    {
        public event EventHandler ExitButtonClicked;
        public event EventHandler RegisterButtonClicked;
        public event EventHandler LoginButtonClicked;
        public event EventHandler ForgotPasswordClicked;
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
