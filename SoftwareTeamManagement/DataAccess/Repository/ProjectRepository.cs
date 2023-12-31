using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.DataAccess.Dao.ProjectDao;

namespace SoftwareTeamManagement.DataAccess.Repository
{
    internal class ProjectRepository
    {
        private IProjectDaoContract dao;

        public void AddProject(IProjectContract project)
        {
            dao = new ProjectDao(project);
            dao.InsertProject();
        }

        public void RemoveProject(IProjectContract project)
        {
            dao = new ProjectDao(project);
            dao.DeleteProject();
        }

        public void EditProject(IProjectContract project)
        {
            dao = new ProjectDao(project);
            dao.UpdateProject();
        }

        public List<IProjectContract> GetProjects()
        {
            dao = new ProjectDao();
            return dao.GetAllProjects();
        }

        public IProjectContract GetSingleProject()
        {
            dao = new ProjectDao();
            return dao.GetAllProjects()[0];
        }
    }
}
