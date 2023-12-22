using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao
{
    public interface ITeamMemberDaoContract
    {
        void AddMember();
        void UpdateMember();
        void DeleteMember();
        List<TeamMember> getAllMembers();

    }
}
