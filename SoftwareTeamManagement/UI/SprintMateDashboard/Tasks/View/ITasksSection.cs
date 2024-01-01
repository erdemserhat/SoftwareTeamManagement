namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public interface ITasksSection
    {
        event EventHandler AddTaskClicked;
        event EventHandler DeleteTaskClicked;
        event EventHandler EditTasksClicked;
        event EventHandler RefreshTaskClicked;
        event EventHandler TaskDoubleClicked;
        event EventHandler OverviewTaskClicked;

        public void UpdateTaskList();

    }
}
