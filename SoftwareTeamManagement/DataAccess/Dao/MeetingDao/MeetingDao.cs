using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.Constants.Queries;
using SoftwareTeamManagement.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.DataAccess.Dao.MeetingDao
{
    public class MeetingDao : IMeetingDaoContract
    {
        private MeetingQueries generator;


        //Use this constractor in the cases of ;
        //-->Insert, Update and Delete Processes.
        public MeetingDao(IMeetingContract meeting)
        {
            generator = new MeetingQueries(meeting);
        }

        //Use this constructor in the case of ;
        //-->Read Data (cause, no need to particular meeting object to read data)
        public MeetingDao()
        {
            generator = new MeetingQueries();
        }




        public void AddMeeting()
        {
            string addQuery = generator.GenerateInsertQuery();
            DatabaseManager.ExecuteQuery(addQuery);



        }

        public void DeleteMeeting()
        {
           
        }

        public List<IMeetingContract> GetAllAnnouncements()
        {
            throw new NotImplementedException();
        }

        public void UpdateMeeting()
        {
            
        }
    }
}
