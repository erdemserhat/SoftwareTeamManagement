﻿namespace SoftwareTeamManagement.BusinessLogic.Configuration.Permissions.ProjectPermission
{
    public interface IProjectPermissionSetContract
    {
        bool CanChangeProjectNameInformation();
        bool CanUpdateProjectDescriptionInformation();
        bool CanAddMemberInformation();
        bool CanRemoveMemberInformation();
        bool CanResetMemberPasswordInformation();
        bool CanAnnounceInformation();
        bool CanHoldMeetingInformation();
        bool CanUpdateMemberPermissionSetInformation();
    }
}
