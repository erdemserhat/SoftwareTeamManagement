using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;

namespace SoftwareTeamManagement.DataAccess.Dao.MeetingDao
{
    internal interface IMeetingDaoContract
    {
        void AddMeeting();
        void DeleteMeeting();
        void UpdateMeeting();

        List<IMeetingContract> GetAllMeetings();

    }

}
