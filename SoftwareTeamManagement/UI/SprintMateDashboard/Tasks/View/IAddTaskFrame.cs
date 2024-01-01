namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public interface IAddTaskFrame
    {
        event EventHandler ExitButtonClicked;
        event EventHandler SaveButtonClicked;
        string? Title { get; }
        string? Description { get; }
        string? Priority { get; }
    }
}
