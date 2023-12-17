using SoftwareTeamManagement.BusinessLogic.Role;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember
{
    public interface ITeamMemberContract
    {
        void AddTask(Task task);
        void DeleteTask(Task task);
        void UpdateTask(Task task);
        List<Task> ReadTask();

    }
}
