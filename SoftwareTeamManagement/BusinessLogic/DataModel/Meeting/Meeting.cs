using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Meeting
{
    public class Meeting :IMeetingContract
    {
        // Properties
        private int _meetingId;
        private string _title;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _location;
        private BaseDataModel.TeamMember.TeamMember _organizator;
        private BaseDataModel.TeamMember.TeamMember[] _participants;


  
        public int MeetingId
        {
        get {return _meetingId;}
        set { _meetingId = value;}
        
        }
        public string Title
        {
            get { return _title;}
            set { _title = value;}
        }
        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        public DateTime EndTime
        {

            get { return _endTime; }
            set { _endTime = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public BaseDataModel.TeamMember.TeamMember Organizer
        {
            get { return _organizator; }
            set { _organizator = value; }
        }
        public BaseDataModel.TeamMember.TeamMember[] Participants
        {
            get { return _participants; }
            set { _participants = value; } 
        }

      

        // ... other properties

        // Constructor
        public Meeting()
        {
            // Constructor logic if needed
        }
    }
}
