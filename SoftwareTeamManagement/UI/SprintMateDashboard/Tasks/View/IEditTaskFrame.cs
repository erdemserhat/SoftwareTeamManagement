namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public interface IEditTaskFrame
    {
        string Title { get; }
        string Description { get; }
        int Id { get; }
        string PriorityLevel { get; }
        string Category { get; }

        event EventHandler ExitButtonClicked;
        event EventHandler SaveButtonClicked;
    }
}
