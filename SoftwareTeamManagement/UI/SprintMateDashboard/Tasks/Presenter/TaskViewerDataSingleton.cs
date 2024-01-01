using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter
{
    public class TaskViewerDataSingleton
    {
        private TaskViewerDataSingleton()
        {

        }
        private static ITaskContract instance;

        public static ITaskContract SetInstance(ITaskContract task)
        {

            instance = task;
            return instance;
        }

        public static ITaskContract GetInstance()
        {
            if (instance == null)
            {
                instance = new Task();
                return instance;
            }

            return instance;
        }




    }
}
