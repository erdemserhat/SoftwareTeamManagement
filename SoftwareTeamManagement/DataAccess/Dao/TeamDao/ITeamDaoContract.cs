using SoftwareTeamManagement.BusinessLogic.DataModel.Team;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamDao
{
    public interface ITeamDaoContract
    {
        void AddTeam();
        void DeleteTeam();
        void UpdateTeam();
        List<ITeamContract> GetTeams();
    }

}
