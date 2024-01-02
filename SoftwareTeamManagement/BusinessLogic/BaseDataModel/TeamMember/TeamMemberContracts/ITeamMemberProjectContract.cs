using SoftwareTeamManagement.BusinessLogic.Configuration.Permissions.ProjectPermission;
using SoftwareTeamManagement.BusinessLogic.Configuration.Permissions.TaskPermission;
using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts
{
    public interface ITeamMemberProjectContract
    {
        void ChangeProjectName(string name);
        void UpdateProjectDescription(string description);
        void AddMember(TeamMember member);
        void RemoveMember(TeamMember member);
        void DeleteMember(TeamMember member);
        void ResetMemberPassword(string password, int userId);
        void MakeAnnouncement(IAnnouncementContract announcement);
        void HoldMeeting(IMeetingContract meeting);
        void EditMemberTaskPermisions(ITaskPermissionSetContract permissionSet, int userId);
        void EditMemberProjectPermissions(IProjectPermissionSetContract permissionSet, int userId);




    }
}
