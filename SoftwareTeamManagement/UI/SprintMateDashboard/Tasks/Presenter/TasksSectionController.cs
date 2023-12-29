
using Google.Protobuf;
using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _view.DeleteTaskClicked += OnDeleteTaskClicked;
            _view.EditTasksClicked += OnEditTaskClicked;
            _view.RefreshTaskClicked += OnRefreshTaskClicked;
            _view.TaskDoubleClicked += OnTaskDoubleClicked;
        }

        private void OnAddTaskClicked(object sender, EventArgs e)
        {
            AddTaskFrame.GetInstance().ShowDialog();

        }

        private void OnEditTaskClicked(object sender, EventArgs e)
        {
            if (ProvideSelectedRowInformation()!=null)
            {
                Task task = ProvideSelectedRowInformation();
                EditTaskFrame.GetInstance().PreviewData(task);
                EditTaskFrame.GetInstance().ShowDialog();

            }
            else
            {
                CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("Please select a task to edit..");
            }


        }

        private void OnDeleteTaskClicked(object sender, EventArgs e)
        {
            if (ProvideSelectedRowInformation() != null)
            {
                Task task = ProvideSelectedRowInformation();
                string title = task.Title;
                string id = task.Id.ToString();
                DeleteTaskFrame.GetInstance().ProvideTaskInformation(title, id);
                DeleteTaskFrame.GetInstance().ShowDialog();

            }
            else
            {
                CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("Please select a task to delete..");
            }

        }

        public  bool UpdateTaskList()
        {
            TaskRepository repo = new TaskRepository();
            List<ITaskContract> tasksList = repo.GetTasks();
       
            TasksSection.GetInstance().taskListView.BeginUpdate(); // BeginUpdate
            TasksSection.GetInstance().taskListView.Items.Clear();


            foreach (var task in tasksList)
            {

                ListViewItem item = new ListViewItem(task.Id.ToString());
                item.SubItems.Add(task.Title);
                item.SubItems.Add(task.PriorityLevel);
                item.SubItems.Add(task.CreatedTime.ToString());
                item.SubItems.Add(task.TaskCatagory);
                item.SubItems.Add(task.Description);
       
              

                TasksSection.GetInstance().taskListView.Items.Add(item);
            }

            TasksSection.GetInstance().taskListView.EndUpdate();

            if (TasksSection.GetInstance().taskListView.Items.Count> 0)
            {
                return true;
            }

            return false;


        }


        private void OnRefreshTaskClicked(object sender, EventArgs e)
        {

            if (UpdateTaskList()) { 
            CustomSuccessMessageBoxForm message = new CustomSuccessMessageBoxForm("Task List Updated from Server!");
            }

        }

        private void OnTaskDoubleClicked(object sender, EventArgs e)
        {
            Task task = null;
            if (TasksSection.GetInstance().taskListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = TasksSection.GetInstance().taskListView.SelectedItems[0]; // Seçilen öğeyi al

                //provide information

                string id = selectedRow.SubItems[0].Text;
                string title = selectedRow.SubItems[1].Text;
                string priority = selectedRow.SubItems[2].Text;
                string createdTime = selectedRow.SubItems[3].Text;
                string category = selectedRow.SubItems[4].Text;
                string description = selectedRow.SubItems[5].Text;

                task = new Task(Convert.ToInt32(id), title, description, priority, DateTime.Parse(createdTime), category);

                TaskViewerDataSingleton.SetInstance(task);
                TaskViewerFrame.GetInstance().NotifyDataSet();
                TaskViewerFrame.GetInstance().ShowDialog();
                







            }



        }



        //to 
        private Task ProvideSelectedRowInformation()
        {
            Task? task = null;
            if (TasksSection.GetInstance().taskListView.SelectedItems.Count > 0)
            {
                //take the selected row 
                ListViewItem selectedRow = TasksSection.GetInstance().taskListView.SelectedItems[0];

                //provide information
                
                string id = selectedRow.SubItems[0].Text;
                string title = selectedRow.SubItems[1].Text;
                string priority = selectedRow.SubItems[2].Text;
                //no need time to update
                //string createdTime = selectedRow.SubItems[3].Text;
                string category = selectedRow.SubItems[4].Text;
                string description = selectedRow.SubItems[5].Text;

                task = new Task(Convert.ToInt32(id), title, description, priority, DateTime.Now, category);

              
            }

            return task;
        }
    }



}

