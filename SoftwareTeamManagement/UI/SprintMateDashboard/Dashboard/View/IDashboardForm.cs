using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    public interface IDashboardForm
    {
        event EventHandler? TasksButtonClicked;
        event EventHandler? ProjectsButtonClicked;
        event EventHandler? TeamButtonClicked;
        event EventHandler? AnnouncementButtonClicked;
        event EventHandler? MeetingButtonClicked;
        event EventHandler? LogoutButtonClicked;

    }
}
