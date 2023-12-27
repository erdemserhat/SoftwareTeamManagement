using SoftwareTeamManagement.BusinessLogic.DataModel.Task;

namespace SoftwareTeamManagement.DataAccess.Dao.TaskDao
{
    public interface ITaskDaoContract
    {
        void AddTask();
        void DeleteTask();
        void UpdateTask();

        public List<ITaskContract> GetAllTasks();


    }
}

