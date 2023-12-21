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

        int OrganizatorId {  get; set; }
        // ... other properties or methods related to meetings
    }
}
