using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;

using System;
using System.Collections.Generic;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao
{
    public class TeamMemberDao : ITeamMemberDaoContract
    {
        // Destructuring all properties to process
        private int id;
        private string fullName;
        private string email;
        private string password;

        // Role
        private string roleDepartment;
        private string roleType;

        // Task permissions
        private bool canAddTask;
        private bool canRemoveTask;
        private bool canEditTask;

        // Project permissions
        private bool canChangeProjectName;
        private bool canUpdateProjectDescription;

        // Member permissions
        private bool canAddMember;
        private bool canRemoveMember;
        private bool canResetMemberPassword;
        private bool canUpdateMemberPermissionSet;

        // Announce and meeting permissions
        private bool canAnnounce;
        private bool canHoldMeeting;

        public TeamMemberDao(TeamMember teamMember)
        {
            // Destructuring all properties to process
            id = teamMember.Id;
            fullName = teamMember.FullName;
            email = teamMember.Email;
            password = teamMember.Password;

            // Role
            roleDepartment = teamMember.RoleContract?.RoleDepartmentInformation();
            roleType = teamMember.RoleContract?.RoleTypeInformation();

            // Task permissions
            canAddTask = teamMember.TaskPermissionSetContract?.canAddTaskInformation() ?? false;
            canRemoveTask = teamMember.TaskPermissionSetContract?.canRemoveTaskInformation() ?? false;
            canEditTask = teamMember.TaskPermissionSetContract?.canEditTaskInformation() ?? false;

            // Project permissions
            canChangeProjectName = teamMember.ProjectPermissionSet?.CanChangeProjectNameInformation() ?? false;
            canUpdateProjectDescription = teamMember.ProjectPermissionSet?.CanUpdateProjectDescriptionInformation() ?? false;

            // Member permissions
            canAddMember = teamMember.ProjectPermissionSet?.CanAddMemberInformation() ?? false;
            canRemoveMember = teamMember.ProjectPermissionSet?.CanRemoveMemberInformation() ?? false;
            canResetMemberPassword = teamMember.ProjectPermissionSet?.CanResetMemberPasswordInformation() ?? false;
            canUpdateMemberPermissionSet = teamMember.ProjectPermissionSet?.CanUpdateMemberPermissionSetInformation() ?? false;

            // Announce and meeting permissions
            canAnnounce = teamMember.ProjectPermissionSet?.CanAnnounceInformation() ?? false;
            canHoldMeeting = teamMember.ProjectPermissionSet?.CanHoldMeetingInformation() ?? false;
        }

        public void AddMember()
        {
          
        }

        public void DeleteMember()
        {
            // Implement the logic to delete a member from the database
            throw new NotImplementedException();
        }

        public List<TeamMember> getAllMembers()
        {
            // Implement the logic to get all members from the database
            throw new NotImplementedException();
        }

        public void UpdateMember()
        {
            // Implement the logic to update a member in the database
            throw new NotImplementedException();
        }
    }
}
