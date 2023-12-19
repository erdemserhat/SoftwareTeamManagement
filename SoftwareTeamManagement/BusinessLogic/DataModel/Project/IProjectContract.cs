using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Project
{
    public interface IProjectContract
    {
        string Name { get; set; }
        string Description { get; set; }

        List<Task> Tasks { get; set; }


    }
}
