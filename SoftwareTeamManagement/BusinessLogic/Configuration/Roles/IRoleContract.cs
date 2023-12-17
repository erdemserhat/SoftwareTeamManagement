using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.Configuration.Roles
{
    public interface IRoleContract
    {
        string RoleTypeInformation();
        string RoleDepartmentInformation();
        void changeRoleType(RoleType roleType);
        void changeRoleDepartmentInformation(RoleDepartment roleDepartment);
    }
}
