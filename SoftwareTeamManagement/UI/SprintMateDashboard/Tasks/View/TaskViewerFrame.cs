using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.UI.CustomMessageBox;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View
{
    public partial class TaskViewerFrame : Form, ITaskViewerFrame
    {
        TaskViewerController controller;

        public string Title { set => titleTB.Text = value; }
        public string Description { set => descriptionTB.Text = value; }
        public string DateAndIdInfo { set => taskDateAndNo.Text = value; }
        public Image PriorityImage { set => priorityImage.Image = value; }
        public Image CategoryImage { set => categoryImage.Image = value; }

        public event EventHandler ExitButtonClicked;
        private static TaskViewerFrame instance;

        public static TaskViewerFrame GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TaskViewerFrame();
            }

            return instance;
        }

        public TaskViewerFrame()
        {
            InitializeComponent();

            //TextBox Arrangements...

            descriptionTB.Multiline = true;
            //to cancel selection
            categoryImage.Focus();
            descriptionTB.Select(0, 0);
            //activating scrollable feature
            descriptionTB.ScrollBars = ScrollBars.Vertical;
            descriptionTB.Size = new Size(330, 148);

            //Preparing controller
            instance = this;
            exitBtn.Click += (sender, e) => ExitButtonClicked?.Invoke(this, EventArgs.Empty);
            controller = new TaskViewerController();





        }



        private void TaskViewerFrame_Load(object sender, EventArgs e)
        {
            descriptionTB.Select(0, 0);

        }



        private void descriptionTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //prevents the editing text
            e.Handled = true;

        }

        private void titleTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //prevents the editing text
            e.Handled = true;

        }

        public void NotifyDataSet()
        {
            controller.OverviewTask();
        }


    }


}

