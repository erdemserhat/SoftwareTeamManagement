using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Project
{
    public interface IProjectContract
    {
        string Name { get; set; }
        string Description { get; set; }

        List<SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task> Tasks { get; set; }


    }
}
