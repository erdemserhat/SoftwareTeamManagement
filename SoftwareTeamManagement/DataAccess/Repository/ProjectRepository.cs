using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.DataAccess.Dao.ProjectDao;
using System;
using System.Collections.Generic;

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
    }
}
