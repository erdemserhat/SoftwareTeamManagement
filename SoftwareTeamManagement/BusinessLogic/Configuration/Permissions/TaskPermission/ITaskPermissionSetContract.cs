using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
