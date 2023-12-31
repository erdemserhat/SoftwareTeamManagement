using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao;
using SoftwareTeamManagement.UI.CustomMessageBox;

namespace SoftwareTeamManagement.DataAccess.Repository
{
    public class TeamMemberRepository
    {
        private ITeamMemberDaoContract dao;

        public void AddTeamMember(TeamMember teamMember)
        {
            dao = new TeamMemberDao(teamMember);
            dao.AddMember();
        }

        public void RemoveTeamMember(TeamMember teamMember)
        {
            dao = new TeamMemberDao(teamMember);
            dao.DeleteMember();
        }

        public void EditTeamMember(TeamMember teamMember)
        {
            dao = new TeamMemberDao(teamMember);
            dao.UpdateMember();
        }

        public List<TeamMember> GetTeamMembers()
        {
            dao = new TeamMemberDao();

            return dao.getAllMembers();
        }

        public bool IsEmailAlreadyRegistered(string email)
        {
            dao = new TeamMemberDao();
            return dao.IsAlreadyRegistered(email);
        }

        public bool IsValidUser(string email, string password)
        {
            dao = new TeamMemberDao();

            return dao.IsValidUser(email, password);
        }

        public void ChangePassword(string email, string password)
        {
            dao = new TeamMemberDao();
            dao.ChangePassword(email, password);



        }

        public TeamMember? ProvideUserDataModelByEmail(string email)
        {
            dao = new TeamMemberDao();
            TeamMember member = dao.GetUserByEmail(email);
            if (member == null)
            {
                CustomErrorMessageBoxForm error = new CustomErrorMessageBoxForm("An error occured while providing user information (null)");
                return null;
            }

            return member;
        }



    }
}
