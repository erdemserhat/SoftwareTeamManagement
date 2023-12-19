using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Team
{
        public interface ITeamContract
        {

        string Name { get; set; }
        string Description { get; set; }
        int Size { get; set; }
        TeamMember TeamLeader { get; set; }
        List<TeamMember> Members { get; set; }
    }
}
