using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao;
using SoftwareTeamManagement.DataAccess.Dao.MeetingDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Repository
{
    public class MeetingRepository
    {
        private IMeetingDaoContract dao;


        public void AddMeeting(IMeetingContract meeting)
        {
            dao = new  MeetingDao(meeting);
            dao.AddMeeting();

        }

        public void RemoveMeeting(IMeetingContract meeting)
        {
            dao=new MeetingDao(meeting);
            dao.DeleteMeeting();
           

        }

        public void EditMeeting(IMeetingContract meeting)
        {
           dao = new MeetingDao(meeting);
           dao.UpdateMeeting();

        }

        public List<IMeetingContract> GetMeetings()
        {
            dao = new MeetingDao();
            return dao.GetAllMeetings();
            
        }




    }
}

