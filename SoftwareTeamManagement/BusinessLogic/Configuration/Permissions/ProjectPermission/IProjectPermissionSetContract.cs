using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission
{
    public interface IProjectPermissionSetContract
    {
        bool CanChangeProjectNameInformation();
        bool CanUpdateDeadlineInformation();
        bool CanUpdateProjectDescriptionInformation();
        bool CanAddMemberInformation();
        bool CanRemoveMemberInformation();
        bool CanResetMemberPasswordInformation();
        bool CanAnnounceInformation();
        bool CanHoldMeetingInformation();
        bool CanUpdateMemberPermissionSetİnformation();
    }
}
