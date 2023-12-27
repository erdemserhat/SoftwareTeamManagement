namespace SoftwareTeamManagement.BusinessLogic.Role.Permissions.TaskPermission
{
    public interface ITaskPermissionSetContract
    {
        void changePermissionSet(bool canAddTask, bool canRemoveTask, bool canEditTask);

        bool canAddTaskInformation();
        bool canRemoveTaskInformation();
        bool canEditTaskInformation();

    }
}
