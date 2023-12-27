using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;

namespace SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao
{
    public interface IAnnouncementDaoContract
    {
        void AddAnnouncement();
        void DeleteAnnouncement();
        void UpdateAnnouncement();

        List<IAnnouncementContract> GetAllAnnouncements();

    }
}
