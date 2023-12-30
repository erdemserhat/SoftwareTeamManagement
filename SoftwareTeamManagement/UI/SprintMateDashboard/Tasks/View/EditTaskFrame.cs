using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public partial class EditTaskFrame : Form, IEditTaskFrame
    {
        private static EditTaskFrame instance;
        //holding data to control
        public string selectedPriority;
        public string selectedcategory;
        public int taskNo;

        //Implementing events...
        public event EventHandler ExitButtonClicked;
        public event EventHandler SaveButtonClicked;

        public string Title => titleTextBox.Text;

        public string Description => descriptionTextBox.Text;

        public string PriorityLevel => selectedPriority;

        public string Category => selectedcategory;

        public int Id => taskNo;

        //Constructor
        public EditTaskFrame()
        {
            InitializeComponent();
            //instance should assign form before init. controller, cause controler uses instance :)
            instance = this;
            InitializeEvents();
            EditTaskController controller = new EditTaskController();
            Button acceptButton = new Button();
            acceptButton.Click += (sender, e) => { SaveButtonClicked.Invoke(sender, e); };
            this.AcceptButton = acceptButton;


        }

        public static EditTaskFrame GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EditTaskFrame();
            }

            return instance;
        }
        //previewsing data for user experience
        public void PreviewData(Task task)
        {
            titleTextBox.Text = task.Title;
            descriptionTextBox.Text = task.Description;
            priorityListBox.SelectedItem = task.PriorityLevel;
            categoryListBox.SelectedItem = task.TaskCatagory;
            taskNo = (task.Id);

        }

        private void priorityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priorityListBox.SelectedIndex != -1)
            {
                object selectedObject = priorityListBox.SelectedItem;
                string content = selectedObject.ToString();
                selectedPriority = content;



            }
            else
            {
                selectedPriority = null;
            }
        }

        private void categoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryListBox.SelectedIndex != -1)
            {
                object selectedObject = categoryListBox.SelectedItem;
                string content = selectedObject.ToString();
                selectedcategory = content;



            }
            else
            {
                selectedcategory = null;
            }

        }

        //Initalize events for controller

        private void InitializeEvents()
        {
            saveBtn.Click += (sender, e) => SaveButtonClicked?.Invoke(this, EventArgs.Empty);
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
