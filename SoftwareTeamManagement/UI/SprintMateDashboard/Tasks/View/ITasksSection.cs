using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public interface ITasksSection
    {
        event EventHandler AddTaskClicked;
        event EventHandler DeleteTaskClicked;
        event EventHandler EditTasksClicked;
        event EventHandler RefreshTaskClicked;

        public void UpdateTaskList();

    }
}
