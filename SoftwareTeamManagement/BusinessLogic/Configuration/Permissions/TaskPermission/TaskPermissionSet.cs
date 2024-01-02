namespace SoftwareTeamManagement.BusinessLogic.Configuration.Permissions.TaskPermission
{
    public class TaskPermissionSet : ITaskPermissionSetContract
    {
        //Attributes 
        private bool canAddTask;
        private bool canRemoveTask;
        private bool canEditTask;

        //Main Constructor
        public TaskPermissionSet(bool canAddTask, bool canRemoveTask, bool canEditTask)
        {
            this.canAddTask = canAddTask;
            this.canRemoveTask = canRemoveTask;
            this.canEditTask = canEditTask;
        }

        //Getters and Setters

        public bool CanAddTask
        {
            get { return canAddTask; }
            set { canAddTask = value; }
        }

        public bool CanRemoveTask
        {
            get { return canRemoveTask; }
            set { canRemoveTask = value; }

        }

        public bool CanEditTask
        {
            get { return canEditTask; }
            set { canEditTask = value; }
        }

        //Implementation of PermissionSet data model

        public void changePermissionSet(bool canAddTask, bool canRemoveTask, bool canEditTask)
        {
            this.canAddTask = canAddTask;
            this.canRemoveTask = canRemoveTask;
            this.canEditTask = canEditTask;
        }

        public bool canAddTaskInformation()
        {
            return canAddTask;
        }

        public bool canRemoveTaskInformation()
        {
            return canRemoveTask;
        }

        public bool canEditTaskInformation()
        {
            return canEditTask;
        }




    }
}
