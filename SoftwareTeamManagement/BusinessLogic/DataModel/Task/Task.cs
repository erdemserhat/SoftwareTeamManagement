using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.BusinessLogic.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Task
{
    public class Task : ITaskContract
    {
        private string _title;
        private string _description;
        private List<TeamMember> _responsibleMembers;
        private PriorityLevel _priorityLevel;
        private DateTime _createdTime;
        private TaskCatagory _catagory;

        public string Title { get=>_title; set=>_title=value; }
        public string Description { get=>_description; set=>_description=value; }
        public List<TeamMember> ResponsibleMembers { get => _responsibleMembers; set => _responsibleMembers = value; }
        public PriorityLevel PriorityLevel { get=>_priorityLevel; set=>_priorityLevel=value; }
        public DateTime CreatedTime { get=>_createdTime; set=>_createdTime=value; }

        public TaskCatagory TaskCatagory { get=>_catagory; set=>_catagory=value; }
    }
}
