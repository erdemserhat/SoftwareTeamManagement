using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao
{
    public interface ITeamMemberDaoContract
    {
        void AddMember();
        void UpdateMember();
        void DeleteMember();
        List<TeamMember> getAllMembers();
        bool IsAlreadyRegistered(string email);

        bool IsValidUser(string email, string password);

        void ChangePassword(string email, string password);

    }
}
