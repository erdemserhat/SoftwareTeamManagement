using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.ProjectDao
{
    public interface IProjectDaoContract
    {
        public void InsertProject(Project Project);
        public void UpdateProject(Project Project);
        public void DeleteProject(Project Project);

    }
}
