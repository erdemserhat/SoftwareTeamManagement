using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.TaskDao
{
    public interface ITaskDaoContract
    {
        void AddTask(Task task);
        void DeleteTask(Task task);
        void UpdateTask(Task task);
    }
}

