using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts;
using SoftwareTeamManagement.BusinessLogic.BaseDataModel.User;
using SoftwareTeamManagement.BusinessLogic.Configuration.Roles;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.TaskPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember
{
    public abstract class TeamMember : User.User , ITeamMemberTaskContract
    {
        //Dependecy Injection as property
        private IRoleContract roleContract;
        private ITaskPermissionSetContract taskPermissionSetContract;
        private IProjectPermissionSetContract projectPermissionSetContract;


        //Getters and Setters

        public IRoleContract RoleContract
        {
            get { return roleContract; }
            set { roleContract = value; }
        }

        public ITaskPermissionSetContract TaskPermissionSetContract
        {
            get { return taskPermissionSetContract; }
            set { taskPermissionSetContract = value; }
        }



        public void AddTask(Task task)
        {
            //If user can add task
            if (TaskPermissionSetContract.canAddTaskInformation())
            {
                //execute database operations
                throw new NotImplementedException();

            }
            else
            {
                //else, throw an exception
                throw new NotImplementedException();
            }
           
        }

        public void DeleteTask(Task task)
        {
           //If user can add task,
           if(TaskPermissionSetContract.canRemoveTaskInformation())
            {
                //execute database operations.
                throw new NotImplementedException();

            }
            else
            {
                //Else, throw an exception
                throw new NotImplementedException();
            }
        }

        public List<Task> ReadTask()
        {
            //There is no condition, all type of users can read tasks
            throw new NotImplementedException();
        }

        public void UpdateTask(Task task)
        {
            //If user can edit task,
            if(TaskPermissionSetContract.canEditTaskInformation())
            {
                //execute database operations
                throw new NotImplementedException();
            }
            else
            {
                //else throw an exception
                throw new NotImplementedException();
            }
        }

        public string showRole()
        {
            return roleContract.RoleTypeInformation();
        }
    }
}
