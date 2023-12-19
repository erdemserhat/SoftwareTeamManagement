using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Team
{
    public class Team :ITeamContract
    {
        private string _name;
        private string _description;
        private int _size;
        private TeamMember _teamLeader;
        private List<TeamMember>  _members;
        // private Project project;

        //Getters and setters

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public TeamMember TeamLeader
        {
            get { return _teamLeader; }
            set { _teamLeader = value; }
        }

        public List<TeamMember> Members
        {
            get { return _members; }
            set { _members = value; }
        }




    }
}
