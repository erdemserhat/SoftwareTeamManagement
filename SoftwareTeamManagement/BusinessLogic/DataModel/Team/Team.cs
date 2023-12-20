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
        private string _id;
        private string _name;
        private string _description;
        private int _size;
        private BaseDataModel.TeamMember.TeamMember _teamLeader;
        private List<BaseDataModel.TeamMember.TeamMember>  _members;
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

        public BaseDataModel.TeamMember.TeamMember TeamLeader
        {
            get { return _teamLeader; }
            set { _teamLeader = value; }
        }

        public List<BaseDataModel.TeamMember.TeamMember> Members
        {
            get { return _members; }
            set { _members = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }




    }
}
