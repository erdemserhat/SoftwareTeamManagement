namespace SoftwareTeamManagement.BusinessLogic.Configuration.Roles
{
    public interface IRoleContract
    {
        string RoleTypeInformation();
        string RoleDepartmentInformation();
        void changeRoleType(string roleType);
        void changeRoleDepartmentInformation(string roleDepartment);
    }
}
