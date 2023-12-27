namespace SoftwareTeamManagement.BusinessLogic.Configuration.Roles
{
    public class Role : IRoleContract
    {
        //Properties
        private string _roleType;
        private string _roleDepartment;


        //Constructor
        public Role(string roleType, string roleDepartment)
        {
            _roleType = roleType;
            _roleDepartment = roleDepartment;
        }

        //Getters and Setters

        public string RoleType
        {
            get { return _roleType; }
            set { _roleType = value; }

        }

        public string RoleDepartment
        {
            get { return _roleDepartment; }
            set { _roleDepartment = value; }


        }

        //Implementation of role class

        public void changeRoleDepartmentInformation(string roleDepartment)
        {
            _roleDepartment = roleDepartment;
        }

        public void changeRoleType(string roleType)
        {
            _roleType = roleType;
        }

        public string RoleDepartmentInformation()
        {
            return RoleDepartment;
        }

        public string RoleTypeInformation()
        {
            return RoleType;
        }
    }
}
