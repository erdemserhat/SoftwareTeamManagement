namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    public interface IDashboardForm
    {
        event EventHandler? TasksButtonClicked;
        event EventHandler? ProjectsButtonClicked;
        event EventHandler? TeamButtonClicked;
        event EventHandler? AnnouncementButtonClicked;
        event EventHandler? MeetingButtonClicked;
        event EventHandler? LogoutButtonClicked;

        public string WelcomeText { set; }

    }
}
