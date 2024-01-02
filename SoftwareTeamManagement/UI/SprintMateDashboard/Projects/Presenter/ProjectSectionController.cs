using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Projects.Presenter
{
    public class ProjectSectionController
    {
        
        private IProjectSection _view = ProjectSection.GetInstance();

        //Main Constructor of controller
        public ProjectSectionController()
        {
            _view.EditProjectButtonClicked += OnEditButtonClicked;
            _view.SaveProjectButtonClicked += OnSaveButtonClicked;
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

        //this function runs when edit button is clicked....
        private void OnSaveButtonClicked(object sender, EventArgs e)
        {

            LockProjectEditStatus(true);
            ProjectSection.GetInstance().generalContainer.BackgroundImage = Properties.Resources.generalContainer_BackgroundImage;
            ProjectSection.GetInstance().projectDescriptionTB.BackColor = Color.FromArgb(192, 192, 192);
            UpdateProjectInformation(_view.ProjectTitle, _view.ProjectDescription);
            SetProjectInformation();




        }

        public void SetProjectInformation()
        {
            ProjectRepository repo = new ProjectRepository();
            IProjectContract project = repo.GetSingleProject();
            _view.ProjectTitle = project.Name;
            _view.ProjectDescription = project.Description;

        }

        private void LockProjectEditStatus(bool condition)
        {
            ProjectSection.GetInstance().projectDescriptionTB.ReadOnly = condition;
            ProjectSection.GetInstance().projectTitleTB.ReadOnly = condition;
        }

        private void UpdateProjectInformation(string title, string description)
        {
            ProjectRepository repo = new ProjectRepository();
            Project project = (Project) repo.GetSingleProject();
            repo.EditProject(project with { Description = description, Name=title });
            CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Project Information is successfully updated..");
            SetProjectInformation();

        }




    }








}

