using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.DataAccess.Dao.TaskDao;
using System;
using System.Collections.Generic;

namespace SoftwareTeamManagement.DataAccess.Repository
{
    public class TaskRepository
    {
        private ITaskDaoContract dao;

        public void AddTask(ITaskContract task)
        {
            dao = new TaskDao(task);
            dao.AddTask();
        }

        public void RemoveTask(ITaskContract task)
        {
            dao = new TaskDao(task);
            dao.DeleteTask();
        }

        public void EditTask(ITaskContract task)
        {
            dao = new TaskDao(task);
            dao.UpdateTask();
        }

        public List<ITaskContract> GetTasks()
        {
            dao = new TaskDao();
            return dao.GetAllTasks();
        }
    }
}
