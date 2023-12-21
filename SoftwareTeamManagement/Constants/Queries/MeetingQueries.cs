using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.Constants.Queries
{
    public class MeetingQueries
    {
        //to hold desctructured properties
        private int meetingId;
        private string title;
        private DateTime startTime;
        private DateTime endTime;
        private string location;
        private int organizatorId;

        //Use this constractor in the cases of ;
        //-->Insert, Update and Delete Processes.
        public MeetingQueries(IMeetingContract meeting)
        {
            //destructuring meeting object.
            meetingId=meeting.MeetingId;
            title=meeting.Title;
            startTime = meeting.StartTime;
            endTime = meeting.EndTime;
            location = meeting.Location;
            organizatorId = meeting.OrganizatorId;

        }

        //Use this constructor in the case of ;
        //-->Read Data (cause, no need to particular meeting object to read data)
        public MeetingQueries()
        {

        }

        public string GenerateInsertQuery()
        {
            string insertQuery = $"INSERT INTO {DatabaseTable.TABLE_MEETING} ({MeetingColumn.TITLE}, {MeetingColumn.START_TIME}, {MeetingColumn.END_TIME}, {MeetingColumn.LOCATION}, {MeetingColumn.ORGANIZER_ID}) VALUES ('{title}','{startTime:yyyy-MM-dd HH:mm:ss}', '{endTime:yyyy-MM-dd HH:mm:ss}', '{location}', {organizatorId});";




            return "";
        }




    }


}
