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
        private RoleType _roleType;
        private RoleDepartment _roleDepartment;


        //Constructor
        public Role(RoleType roleType, RoleDepartment roleDepartment)
        {
            _roleType = roleType;
            _roleDepartment = roleDepartment;
        }

        //Getters and Setters

        public RoleType RoleType
        {
            get { return _roleType; }
            set { _roleType = value; }

        }

        public RoleDepartment RoleDepartment
        {
            get { return _roleDepartment; }
            set { _roleDepartment = value; }


        }

        //Implementation of role class

        public void changeRoleDepartmentInformation(RoleDepartment roleDepartment)
        {
            _roleDepartment = roleDepartment;
        }

        public void changeRoleType(RoleType roleType)
        {
            _roleType = roleType;
        }

        public string RoleDepartmentInformation()
        {
            return RoleDepartmentHelper.GetRoleDepartment(RoleDepartment);
        }

        public string RoleTypeInformation()
        {
            return RoleTypeHelper.GetRoleName(_roleType);
        }
    }
}
