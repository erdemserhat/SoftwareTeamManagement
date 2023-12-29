using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter
{
    public class EditTaskController
    {
        // dependecny injection as Singleton object.
        private IEditTaskFrame _view = EditTaskFrame.GetInstance();

        //constructor
        public EditTaskController()
        {
            _view.SaveButtonClicked += OnSaveButtonClicked;
            _view.ExitButtonClicked += OnExitButtonClicked;
        }

        //Handling events

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (ControlInputs())
            {
                //controls are valid in this scope...
                TaskRepository repo = new TaskRepository();
                Task task = new Task(_view.Id, _view.Title, _view.Description, _view.PriorityLevel, DateTime.Now, _view.Category);
                repo.EditTask(task);
                EditTaskFrame.GetInstance().Hide();

                TasksSection.GetInstance().UpdateTaskList();
                CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Task is  successfully updated.");

            }

        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            EditTaskFrame.GetInstance().Hide();
        }


        //to control input
        private bool ControlInputs()
        {
            CustomErrorMessageBoxForm message;

            if (_view.Title == null || string.IsNullOrWhiteSpace(_view.Title))
            {
                message = new CustomErrorMessageBoxForm("Please fill the title field..");
                return false;
            }
            else if (_view.Description == null || string.IsNullOrWhiteSpace(_view.Description))
            {
                message = new CustomErrorMessageBoxForm("Please fill the description field..");
                return false;
            }
            else if (_view.Category == null)
            {
                message = new CustomErrorMessageBoxForm("Please select a priority level..");
                return false;
            }
            else if (_view.Category == null)
            {
                message = new CustomErrorMessageBoxForm("Please select a category..");
                return false;
            }


            return true;


        }
    }
}
