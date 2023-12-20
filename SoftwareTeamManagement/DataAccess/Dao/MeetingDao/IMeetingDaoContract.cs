using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.MeetingDao
{
    internal interface IMeetingDaoContract
    {
        void AddMeeting(Meeting meeting);
        void DeleteMeeting(Meeting meeting);
        void UpdateMeeting(Meeting meeting);
    }

}
