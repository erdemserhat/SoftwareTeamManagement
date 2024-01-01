using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter
{
    public class AddTaskController
    {
        private static IAddTaskFrame _view = AddTaskFrame.GetInstance();

        public AddTaskController()
        {
            _view.SaveButtonClicked += OnSaveButtonClicked;
            _view.ExitButtonClicked += OnExitButtonClicked;
        }

        //Handling events
        public void OnExitButtonClicked(object sender, EventArgs e)
        {
            AddTaskFrame.GetInstance().Hide();
            AddTaskFrame.GetInstance().ClearSelections();
        }

        public void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (ControlInputs())
            {
                TaskRepository repo = new TaskRepository();
                Task task = new Task(_view.Title, _view.Description, _view.Priority, DateTime.Now, "Pending");
                repo.AddTask(task);

                AddTaskFrame.GetInstance().Hide();
                AddTaskFrame.GetInstance().ClearSelections();
                TasksSection.GetInstance().UpdateTaskList();
                CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Task Successfully Added!");

            }
        }

        public bool ControlInputs()
        {
            CustomErrorMessageBoxForm message;
            if (_view.Title == null || string.IsNullOrWhiteSpace(_view.Title))
            {
                message = new CustomErrorMessageBoxForm("Title field cannot be empty.");
                return false;
            }
            else if (_view.Description == null || string.IsNullOrWhiteSpace(_view.Description))
            {
                message = new CustomErrorMessageBoxForm("Description field cannot be empty.");
                return false;
            }
            else if (_view.Priority == null)
            {
                message = new CustomErrorMessageBoxForm("You must select a priority level");
                return false;
            }
            return true;
        }

    }
}

