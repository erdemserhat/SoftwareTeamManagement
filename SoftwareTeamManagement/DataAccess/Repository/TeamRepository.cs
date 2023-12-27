using SoftwareTeamManagement.BusinessLogic.DataModel.Team;
using SoftwareTeamManagement.DataAccess.Dao.TeamDao;

namespace SoftwareTeamManagement.DataAccess.Repository
{
    public class TeamRepository
    {
        private ITeamDaoContract teamDao;

        public void AddTeam(ITeamContract team)
        {
            teamDao = new TeamDao(team);
            teamDao.AddTeam();
        }

        public void RemoveTeam(ITeamContract team)
        {
            teamDao = new TeamDao(team);
            teamDao.DeleteTeam();
        }

        public void EditTeam(ITeamContract team)
        {
            teamDao = new TeamDao(team);
            teamDao.UpdateTeam();
        }

        public List<ITeamContract> GetTeams()
        {
            teamDao = new TeamDao();
            return teamDao.GetTeams();
        }
    }
}
