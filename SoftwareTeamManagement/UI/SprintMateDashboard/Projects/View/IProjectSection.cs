namespace SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View
{
    public interface IProjectSection
    {
        event EventHandler EditProjectButtonClicked;
        event EventHandler SaveProjectButtonClicked;
        string ProjectTitle { set; get; }
        string ProjectDescription { set; get; }

    }
}
