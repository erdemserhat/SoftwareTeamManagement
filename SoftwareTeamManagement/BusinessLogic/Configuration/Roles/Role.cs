using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.Configuration.Roles
{
    public class Role : IRoleContract
    {
        //Properties
        private RoleType roleType;
        private RoleDepartment roleDepartment;


        //Constructor
        public Role(RoleType roleType, RoleDepartment roleDepartment)
        {
            this.roleType = roleType;
            this.roleDepartment = roleDepartment;
        }

        //Getters and Setters

        public RoleType RoleType
        {
            get { return roleType; }
            set { roleType = value; }

        }

        public RoleDepartment RoleDepartment
        {
            get { return roleDepartment; }
            set { roleDepartment = value; }


        }

        //Implementation of role class

        public void changeRoleDepartmentInformation(RoleDepartment roleDepartment)
        {
            this.roleDepartment = roleDepartment;
        }

        public void changeRoleType(RoleType roleType)
        {
            this.roleType = roleType;
        }

        public string RoleDepartmentInformation()
        {
            return RoleDepartmentHelper.GetRoleDepartment(roleDepartment);
        }

        public string RoleTypeInformation()
        {
            return RoleTypeHelper.GetRoleName(roleType);
        }
    }
}
