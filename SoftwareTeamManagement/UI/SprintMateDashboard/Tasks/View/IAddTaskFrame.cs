using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public interface IAddTaskFrame
    {
        event EventHandler ExitButtonClicked;
        event EventHandler SaveButtonClicked;
        string? Title { get; }
        string? Description {  get; }
        string? Priority {  get; }
    }
}
