using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.DataAccess.Dao.ProjectDao;
using SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Projects.Presenter
{
    public class ProjectSectionController
    {
        IProjectContract project;
        private IProjectSection _view = ProjectSection.GetInstance();

        //Main Constructor of controller
        public ProjectSectionController()
        {
            _view.EditProjectButtonClicked += OnEditButtonClicked;
            SetProjectInformation();
            LockProjectEditStatus(true);

        }


        //Events
        //this functions runs when edit button is clicked...
        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            LockProjectEditStatus(false);
            ProjectSection.GetInstance().generalContainer.BackgroundImage = Properties.Resources.editableBg;
            ProjectSection.GetInstance().projectDescriptionTB.BackColor = Color.White;




        }

        private void SetProjectInformation()
        {
            ProjectRepository repo = new ProjectRepository();
            project = repo.GetSingleProject();
            _view.ProjectTitle = project.Name;
            _view.ProjectDescription = project.Description;

        }

        private void LockProjectEditStatus(bool condition)
        {
            ProjectSection.GetInstance().projectDescriptionTB.ReadOnly = condition;
            ProjectSection.GetInstance().projectTitleTB.ReadOnly = condition;
        }

       
        

    }








}

