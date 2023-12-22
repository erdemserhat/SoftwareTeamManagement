using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Project
{
    public record class Project :IProjectContract
    {
        private int _id = 0;
        private string _name;
        private string _description;

        public Project(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }

        public Project()
        {
        }

        public Project(string name, string description)
        {
            _name = name;
            _description = description;
        }

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

    

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        internal void Deconstruct(out object projectId, out object projectName, out object projectDescription)
        {
            throw new NotImplementedException();
        }
    }
}
