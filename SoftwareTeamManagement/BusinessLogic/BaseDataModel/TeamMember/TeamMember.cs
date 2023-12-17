using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts;
using SoftwareTeamManagement.BusinessLogic.BaseDataModel.User;
using SoftwareTeamManagement.BusinessLogic.Configuration.Roles;
using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.TaskPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember
{
    public abstract class TeamMember : User.User , ITeamMemberTaskContract, ITeamMemberProjectContract
    {
        //Dependecy Injection as property
        private IRoleContract _roleContract;
        private ITaskPermissionSetContract _taskPermissionSetContract;
        private IProjectPermissionSetContract _projectPermissionSetContract;


        //Getters and Setters

        public IRoleContract RoleContract
        {
            get { return _roleContract; }
            set { _roleContract = value; }
        }

        public ITaskPermissionSetContract TaskPermissionSetContract
        {
            get { return _taskPermissionSetContract; }
            set { _taskPermissionSetContract = value; }
        }



        //Task operation implementations

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


         //Task operation implementations
        public string showRole()
        {
            return RoleContract.RoleTypeInformation();
        }

        public void ChangeProjectName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateDeadline(DateTime? deadline)
        {
            throw new NotImplementedException();
        }

        public void UpdateProjectDescription(string description)
        {
            throw new NotImplementedException();
        }

        public void AddMember(TeamMember member)
        {
            throw new NotImplementedException();
        }

        public void RemoveMember(TeamMember member)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(TeamMember member)
        {
            throw new NotImplementedException();
        }

        public void ResetMemberPassword(string password, int userId)
        {
            throw new NotImplementedException();
        }

        public void MakeAnnouncement(IAnnouncementContract announcement)
        {
            throw new NotImplementedException();
        }

        public void HoldMeeting(IMeetingContract meeting)
        {
            throw new NotImplementedException();
        }

        public void EditMemberTaskPermisions(ITaskPermissionSetContract permissionSet, int userId)
        {
            throw new NotImplementedException();
        }

        public void EditMemberProjectPermissions(IProjectPermissionSetContract permissionSet, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
