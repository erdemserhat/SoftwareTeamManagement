using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Project
{
    public class Project :IProjectContract
    {
        private string _name;
        private string _description;
        private List<Task.Task> _tasks;

        public string Name
        {
            get => _name; 
            set => _name = value;
        }
        public string Description
        { 
            get => _description; 
            set => _description = value; 
        }

        public List<Task.Task> Tasks
        {
            get => _tasks;
            set => _tasks=value;
        }
    }
}
