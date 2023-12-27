using SoftwareTeamManagement.BusinessLogic.DataModel.Project;

namespace SoftwareTeamManagement.DataAccess.Dao.ProjectDao
{
    public interface IProjectDaoContract
    {
        public void InsertProject();
        public void UpdateProject();
        public void DeleteProject();
        public List<IProjectContract> GetAllProjects();

    }
}
