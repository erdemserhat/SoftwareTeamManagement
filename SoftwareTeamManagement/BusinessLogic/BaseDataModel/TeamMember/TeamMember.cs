using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts;
using SoftwareTeamManagement.BusinessLogic.Configuration.Permissions.ProjectPermission;
using SoftwareTeamManagement.BusinessLogic.Configuration.Permissions.TaskPermission;
using SoftwareTeamManagement.BusinessLogic.Configuration.Roles;
using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember
{
    public record class TeamMember : User.User, ITeamMemberTaskContract, ITeamMemberProjectContract, ITeamMemberGeneralContract
    {
        //Dependecy Injection as property
        private IRoleContract _roleContract;
        private ITaskPermissionSetContract _taskPermissionSetContract = new TaskPermissionSet(true, true, true);
        private IProjectPermissionSetContract _projectPermissionSetContract = new ProjectPermissionSet(true, true, true, true, true, true, true, true);

        public TeamMember(int id, string fullName, string email, string password, IRoleContract roleContract, ITaskPermissionSetContract taskPermissionSetContract, IProjectPermissionSetContract projectPermissionSetContract)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;

            _roleContract = roleContract;
            _taskPermissionSetContract = taskPermissionSetContract;
            _projectPermissionSetContract = projectPermissionSetContract;
        }

        public TeamMember(string fullName, string email, string password, IRoleContract roleContract, ITaskPermissionSetContract taskPermissionSetContract, IProjectPermissionSetContract projectPermissionSetContract)
        {
            Id = 0;
            FullName = fullName;
            Email = email;
            Password = password;

            _roleContract = roleContract;
            _taskPermissionSetContract = taskPermissionSetContract;
            _projectPermissionSetContract = projectPermissionSetContract;
        }

        public TeamMember(string fullName, string email, string password, IRoleContract roleContract)
        {
            Id = 0;
            FullName = fullName;
            Email = email;
            Password = password;

            _roleContract = roleContract;

        }

        public TeamMember(int id)
        {
            Id = id;

        }





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
            get { return _projectPermissionSetContract; }
            set { _projectPermissionSetContract = value; }
        }



        //Task operation implementations

        public void AddTask(DataModel.Task.Task task)
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

        public void DeleteTask(DataModel.Task.Task task)
        {
            //If user delete add task,
            if (TaskPermissionSetContract.canRemoveTaskInformation())
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

        public List<DataModel.Task.Task> ReadTask()
        {
            //There is no condition, all type of users can read tasks
            throw new NotImplementedException();
        }

        public void UpdateTask(DataModel.Task.Task task)
        {
            //If user can edit task,
            if (TaskPermissionSetContract.canEditTaskInformation())
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
            if (ProjectPermissionSet.CanResetMemberPasswordInformation())
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
