
using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter
{
    public class TasksSectionController
    {
        private ITasksSection _view = TasksSection.GetInstance();

        public TasksSectionController()
        {
            _view.AddTaskClicked += OnAddTaskClicked;
            _view.AddTaskClicked += OnDeleteTaskClicked;
            _view.AddTaskClicked += OnEditTaskClicked;
            _view.RefreshTaskClicked += OnRefreshTaskClicked;
        }

        private void OnAddTaskClicked(object sender, EventArgs e)
        {

        }

        private void OnEditTaskClicked(object sender, EventArgs e)
        {

        }

        private void OnDeleteTaskClicked(object sender, EventArgs e)
        {

        }

        public void UpdateTaskList()
        {
            TaskRepository repo = new TaskRepository();
            List<ITaskContract> tasksList = repo.GetTasks();
       
            TasksSection.GetInstance().taskListView.BeginUpdate(); // BeginUpdate
            TasksSection.GetInstance().taskListView.Items.Clear();


            foreach (var task in tasksList)
            {

                ListViewItem item = new ListViewItem(task.Title);
                item.SubItems.Add(task.PriorityLevel);
                item.SubItems.Add(task.CreatedTime.ToString());
                item.SubItems.Add(task.TaskCatagory);
                item.SubItems.Add(task.Description);
       
              

                TasksSection.GetInstance().taskListView.Items.Add(item);
            }

            TasksSection.GetInstance().taskListView.EndUpdate();//FinishUpdate

           
        }


        private void OnRefreshTaskClicked(object sender, EventArgs e)
        {
            UpdateTaskList();
            CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Task List Updated from Server!");
        }
    }



}

