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
    public class DeleteTaskController
    {
        //Depedency Injection as Singleton
        private IDeleteTaskFrame _view = DeleteTaskFrame.GetInstance();

        public DeleteTaskController()
        {
            _view.DeleteButtonClicked += OnDeleteButtonClicked;
            _view.ExitButtonClicked += OnExitButtonClicked;
        }

        //handling events

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            TaskRepository repo = new TaskRepository();
            Task task = new Task(Convert.ToInt32(DeleteTaskFrame.GetInstance().Id));
            repo.RemoveTask(task);

            DeleteTaskFrame.GetInstance().Hide();
            TasksSection.GetInstance().UpdateTaskList();
            CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Task is  successfully deleted.");

        }

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            //for performance !!  used "Hide()" func.
            DeleteTaskFrame.GetInstance().Hide();

        }


    }
}
