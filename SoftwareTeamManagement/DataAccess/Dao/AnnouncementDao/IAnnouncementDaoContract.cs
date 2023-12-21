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
        void AddAnnouncement();
        void DeleteAnnouncement();
        void UpdateAnnouncement();

        List<IAnnouncementContract> GetAllAnnouncements();

    }
}
