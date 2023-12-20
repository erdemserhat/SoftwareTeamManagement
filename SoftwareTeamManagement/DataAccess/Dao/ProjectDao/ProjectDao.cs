using Microsoft.EntityFrameworkCore.Storage;
using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftwareTeamManagement.DataAccess.Dao.ProjectDao
{
    public class ProjectDao : IProjectDaoContract
    {
        
        void IProjectDaoContract.DeleteProject(Project projectToDelete)
        {
          int id = projectToDelete.Id;
            try
            {
                DatabaseManager.ExecuteQuery("DELETE FROM");


            }catch (Exception ex)
            {


            }
        }

        void IProjectDaoContract.InsertProject(Project Project)
        {
            throw new NotImplementedException();
        }

        void IProjectDaoContract.UpdateProject(Project Project)
        {
            throw new NotImplementedException();
        }
    }
}
