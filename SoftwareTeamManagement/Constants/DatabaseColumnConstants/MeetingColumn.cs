using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace SoftwareTeamManagement.Constants.DatabaseColumnConstants
{
    public static class MeetingColumn
    {
        public const string MEETING_ID = "MeetingId";
        public const string TITLE = "Title";
        public const string START_TIME = "StartTime";
        public const string END_TIME = "EndTime";
        public const string LOCATION = "Location";
        public const string ORGANIZER_ID = "OrganizatorId";
    }


}
