using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SoftwareTeamManagement.UI.CustomMessageBox;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public partial class TasksSection : UserControl, ITasksSection
    {

        //Events
        public event EventHandler AddTaskClicked;
        public event EventHandler DeleteTaskClicked;
        public event EventHandler EditTasksClicked;
        public event EventHandler RefreshTaskClicked;
        public event EventHandler TaskDoubleClicked;

        TasksSectionController controller;

        public TasksSection()
        {
            InitializeComponent();
            instance = this;
            controller = new TasksSectionController();
            InitializeEvents();
            UpdateTaskList();



        }

        //Singleton Pattern

        private static TasksSection instance;

        public static TasksSection GetInstance()
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new TasksSection();
            }

            return instance;
        }




        public void UpdateTaskList()
        {
            controller.UpdateTaskList();
        }

        private void InitializeEvents()
        {
            addTaskBtn1.Click += (sender, e) => AddTaskClicked?.Invoke(this, EventArgs.Empty);
            deleteTaskBtn.Click += (sender, e) => DeleteTaskClicked?.Invoke(this, EventArgs.Empty);
            editTaskBtn.Click += (sender, e) => EditTasksClicked?.Invoke(this, EventArgs.Empty);
            refreshTask.Click += (sender, e) => RefreshTaskClicked?.Invoke(this, EventArgs.Empty);
            taskListView.MouseDoubleClick += (sender, e) => TaskDoubleClicked?.Invoke(this, EventArgs.Empty);
        }

        private void TasksSection_Load(object sender, EventArgs e)
        {
            taskListView.FullRowSelect = true;
        }

        private void taskListView_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteTaskClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}