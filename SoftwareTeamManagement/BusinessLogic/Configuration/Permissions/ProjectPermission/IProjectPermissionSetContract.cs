using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission
{
    public interface IProjectPermissionSetContract
    {
        bool CanChangeProjectName { get; set; }
        bool CanUpdateDeadline { get; set; }
        bool CanUpdateProjectDescription { get; set; }
        bool CanAddMember { get; set; }
        bool CanRemoveMember { get; set; }
        bool CanResetMemberPassword { get; set; }
        bool CanAnnounce { get; set; }
        bool CanHoldMeeting { get; set; }
        bool CanUpdateMemberPermissionSet { get; set; }
    }
}
