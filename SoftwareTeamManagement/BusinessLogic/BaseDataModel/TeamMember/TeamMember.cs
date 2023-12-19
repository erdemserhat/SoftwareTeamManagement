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
    public abstract class TeamMember : User.User , ITeamMemberTaskContract, ITeamMemberProjectContract,ITeamMemberGeneralContract
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

        public IProjectPermissionSetContract ProjectPermissionSet
        {
            get { return _projectPermissionSetContract;}
            set { _projectPermissionSetContract = value;}
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
       

        public void ChangeProjectName(string name)
        {
            if (ProjectPermissionSet.CanChangeProjectNameInformation())
            {
                //implement db op.
            }
            else
            {
                //handle else proc.
            }
        }

        public void UpdateDeadline(DateTime? deadline)
        {
            if (ProjectPermissionSet.CanUpdateDeadlineInformation())
            {
                //implement db. op.
            }
            else
            {
                //handle else op.
            }
        }

        public void UpdateProjectDescription(string description)
        {
            if (ProjectPermissionSet.CanUpdateProjectDescriptionInformation())
            {

            }
            else
            {

            }
        }

        public void AddMember(TeamMember member)
        {
            if (ProjectPermissionSet.CanAddMemberInformation())
            {

            }
            else
            {

            }
        }

        public void RemoveMember(TeamMember member)
        {
            if (ProjectPermissionSet.CanRemoveMemberInformation())
            {

            }
            else
            {

            }
        }

        public void DeleteMember(TeamMember member)
        {
            if (ProjectPermissionSet.CanRemoveMemberInformation())
            {


            }
            else
            {

            }
        }

        public void ResetMemberPassword(string password, int userId)
        {
            if(ProjectPermissionSet.CanResetMemberPasswordInformation())
            {

            }
            else
            {

            }
        }

        public void MakeAnnouncement(IAnnouncementContract announcement)
        {
            if (ProjectPermissionSet.CanAnnounceInformation())
            {

            }
            else
            {

            }
        }

        public void HoldMeeting(IMeetingContract meeting)
        {
            if (ProjectPermissionSet.CanHoldMeetingInformation())
            {

            }
            else
            {

            }
        }

        public void EditMemberTaskPermisions(ITaskPermissionSetContract permissionSet, int userId)
        {
            if (ProjectPermissionSet.CanUpdateMemberPermissionSetInformation())
            {

            }
            else
            {

            }
        }

        public void EditMemberProjectPermissions(IProjectPermissionSetContract permissionSet, int userId)
        {
            if (ProjectPermissionSet.CanUpdateMemberPermissionSetInformation())
            {

            }
        }

        //Generak contract imp.
        public string showRole()
        {
            return RoleContract.RoleTypeInformation();
        }
    }
}
