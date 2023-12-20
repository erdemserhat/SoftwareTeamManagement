using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao
{
    public interface IAnnouncementDaoContract
    {
        void AddAnnouncement(Announcement announcement);
        void DeleteAnnouncement(Announcement announcement);
        void UpdateAnnouncement(Announcement announcement);

    }
}
