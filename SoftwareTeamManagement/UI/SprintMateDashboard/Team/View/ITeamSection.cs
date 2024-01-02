using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Team.View
{
    public interface ITeamSection
    {
        event EventHandler UpdateProfileButtonClicked;
        public void ShowMemberList();
    }
}
