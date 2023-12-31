using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View
{
    public interface IProjectSection
    {
        event EventHandler EditProjectButtonClicked;
        string ProjectTitle { set; }
        string ProjectDescription { set; }
        
    }
}
