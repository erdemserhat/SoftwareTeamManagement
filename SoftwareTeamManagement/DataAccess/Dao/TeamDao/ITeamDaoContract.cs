using SoftwareTeamManagement.BusinessLogic.DataModel.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamDao
{
    public interface ITeamDaoContract
    {
        void AddTeam(Team team);
        void DeleteTeam(Team team);
        void UpdateTeam(Team team);
    }

}
