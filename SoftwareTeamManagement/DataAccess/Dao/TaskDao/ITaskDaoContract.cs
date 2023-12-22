using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

