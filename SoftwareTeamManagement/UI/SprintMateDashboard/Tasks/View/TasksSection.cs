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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {

        }

        private void optionsSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void optionsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taskListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editTaskBtn_Click(object sender, EventArgs e)
        {

        }

        private void tasksContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}