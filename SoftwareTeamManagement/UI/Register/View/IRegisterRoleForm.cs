namespace SoftwareTeamManagement.UI.Register.View
{
    public interface IRegisterRoleForm
    {
        string Role { get; }
        string Department { get; }

        event EventHandler NextButtonClicked;
        event EventHandler ExitButtonClicked;

    }
}
