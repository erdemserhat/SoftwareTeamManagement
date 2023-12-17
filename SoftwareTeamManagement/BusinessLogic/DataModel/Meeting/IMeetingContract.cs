using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using System;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Meeting
{
    public interface IMeetingContract
    {
        int MeetingId { get; set; }
        string Title { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        string Location { get; set; }
        TeamMember Organizer { get; set; }
        TeamMember[] Participants { get; set; }
        // ... other properties or methods related to meetings
    }
}
