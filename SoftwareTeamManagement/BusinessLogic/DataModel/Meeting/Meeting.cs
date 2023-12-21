using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Meeting
{
    public class Meeting : IMeetingContract
    {
        // Properties
        private int _meetingId = 0;
        private string _title;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _location;
        private int _organizatorId;


        //to insert data
        public Meeting(string title, DateTime startTime, DateTime endTime, string location, int organizatorId)
        {
            _title = title;
            _startTime = startTime;
            _endTime = endTime;
            _location = location;
            _organizatorId = organizatorId;
        }

        //to read and update data
        public Meeting(int meetingId, string title, DateTime startTime, DateTime endTime, string location, int organizatorId)
        {
            _meetingId = meetingId;
            _title = title;
            _startTime = startTime;
            _endTime = endTime;
            _location = location;
            _organizatorId = organizatorId;
        }

        //to delete data
        public Meeting(int meetingId)
        {
            _meetingId = meetingId;
        }

        public int MeetingId
        {
            get { return _meetingId; }
            set { _meetingId = value; }

        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
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

        public int OrganizatorId
        {
            get => _organizatorId;
            set => _organizatorId=value;
        }

    }
}
