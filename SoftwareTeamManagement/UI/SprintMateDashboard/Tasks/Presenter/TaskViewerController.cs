using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.Presenter
{
    public class TaskViewerController
    {
        //Dependency Injection as Singleton Object...
        private static ITaskViewerFrame _view = TaskViewerFrame.GetInstance();

        //assinging the descturcted the data model...
        private string title;
        private string description;
        private DateTime date;
        private string id;
        private string category;
        private string priority;


        //Constructor
        public TaskViewerController()
        {
            _view.ExitButtonClicked += OnExitButtonClicked;
            OverviewTask();
        }

        //handling exit button

        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            TaskViewerFrame.GetInstance().Hide();
        }

        public void OverviewTask()
        {
            InitializeDataset();

            //Setting values...
            _view.Title = title;
            _view.Description = description;
            _view.DateAndIdInfo = ConfigureInfo(date, id);
            ConfigureImageInformation(category, priority);

        }

        //Init. data.
        private void InitializeDataset()
        {
            ITaskContract task = TaskViewerDataSingleton.GetInstance();
            title = task.Title;
            description = task.Description;
            id = task.Id.ToString();
            date = task.CreatedTime;
            category = task.TaskCatagory;
            priority = task.PriorityLevel;
        }

        //this methods configures a info text for task
        private string ConfigureInfo(DateTime date, string id)
        {
            string configuredText = $"{date}  #{id}";
            return configuredText;

        }

        //this method catogorizes the possible options for category and priority level
        private void ConfigureImageInformation(string category, string priority)
        {
            _view.PriorityImage = priorityImage[priority];
            _view.CategoryImage = categoryImage[category];




        }


        //defining the dynamic dictinory model
        private Dictionary<String, Image> priorityImage = new Dictionary<String, Image>()
        {
            { "High", Properties.Resources.highPriorityIcon }, 
            { "Medium", Properties.Resources.mediumPriortityIcon },
            { "Low", Properties.Resources.lowPriorityIcon } 
        };

        private Dictionary<String, Image> categoryImage = new Dictionary<String, Image>()
        {
            { "Pending", Properties.Resources.pendingIcon },
            { "In Progress", Properties.Resources.progressIcon },
            { "Done", Properties.Resources.doneIcon }
        };




    }
}
