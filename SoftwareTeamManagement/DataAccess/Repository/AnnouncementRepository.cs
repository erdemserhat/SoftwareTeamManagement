using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Repository
{
    public  class AnnouncementRepository
    {
        private IAnnouncementDaoContract dao;
      

        public void AddAnnouncement(IAnnouncementContract announcement)
        {
            dao = new AnnouncementDao(announcement);
            dao.AddAnnouncement();

        }

        public void RemoveAnnouncement(IAnnouncementContract announcement)
        {
            dao = new AnnouncementDao(announcement);
            dao.DeleteAnnouncement();

        }

        public void EditAnnouncement(IAnnouncementContract announcement)
        {
            dao = new AnnouncementDao(announcement);
            dao.UpdateAnnouncement();

        }

        public List<IAnnouncementContract> GetAnnoucements()
        {
            dao = new AnnouncementDao();
            return dao.GetAllAnnouncements();
        }




    }
}
