using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public interface ITaskViewerFrame
    {
        event EventHandler ExitButtonClicked;
        string Title { set; }
        string Description { set; }
        string DateAndIdInfo {  set; }
        Image PriorityImage { set; }
        Image CategoryImage { set; }

    }
}
