using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.TaskPermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts
{
    public interface ITeamMemberProjectContract
    {
        void ChangeProjectName(string name);
        void UpdateDeadline(DateTime? deadline);
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
