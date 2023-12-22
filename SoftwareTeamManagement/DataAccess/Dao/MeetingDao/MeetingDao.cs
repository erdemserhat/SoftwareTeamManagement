using MySql.Data.MySqlClient;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
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
        //to hold desctructured properties
        private int meetingId;
        private string title;
        private DateTime startTime;
        private DateTime endTime;
        private string location;
        private int organizatorId;



        //Use this constractor in the cases of ;
        //-->Insert, Update and Delete Processes.
        public MeetingDao(IMeetingContract meeting)
        {
            //destructuring meeting object.
            meetingId = meeting.MeetingId;
            title = meeting.Title;
            startTime = meeting.StartTime;
            endTime = meeting.EndTime;
            location = meeting.Location;
            organizatorId = meeting.OrganizatorId;

            //Use this constructor in the case of ;
            //-->Read Data (cause, no need to particular meeting object to read data)
        }
        public MeetingDao()
        {

        }




        public void AddMeeting()
        {
            string insertQuery = $"INSERT INTO {DatabaseTable.TABLE_MEETING} " +
                          $"({MeetingColumn.TITLE}, {MeetingColumn.START_TIME}, {MeetingColumn.END_TIME}, {MeetingColumn.LOCATION}, {MeetingColumn.ORGANIZER_ID}) " +
                          $"VALUES (@title, @startTime, @endTime, @location, @organizerId)";



            MySqlCommand? command = DatabaseManager.GetCommand(insertQuery);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@startTime", startTime.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@endTime", endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@organizerId", organizatorId);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();




        }

        public void DeleteMeeting()
        {
            string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_MEETING} WHERE {MeetingColumn.MEETING_ID} = @meetingId";

            MySqlCommand? command = DatabaseManager.GetCommand(deleteQuery);

            command.Parameters.AddWithValue("@meetingId", meetingId);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();


        }

        public List<IMeetingContract> GetAllMeetings()
        {
            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_MEETING}";
            MySqlDataReader? reader = DatabaseManager.GetReader(selectQuery);
            List<IMeetingContract> meetings = new List<IMeetingContract>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(MeetingColumn.MEETING_ID);
                    string title = reader.GetString(MeetingColumn.TITLE);
                    DateTime startTime = reader.GetDateTime(MeetingColumn.START_TIME);
                    DateTime endTime = reader.GetDateTime(MeetingColumn.END_TIME);
                    string location = reader.GetString(MeetingColumn.LOCATION);
                    int organizerId = reader.GetInt32(MeetingColumn.ORGANIZER_ID);

                    // Meeting sınıfını kullanarak record oluşturuluyor
                    Meeting meeting = new Meeting(id, title, startTime, endTime, location, organizerId);
                    meetings.Add(meeting);

                }

                reader.Close();
                DatabaseManager.CloseConnection();
            }

            return meetings;
        }


        public void UpdateMeeting()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_MEETING} SET " +
                                 $"{MeetingColumn.TITLE} = @title, " +
                                 $"{MeetingColumn.START_TIME} = @startTime, " +
                                 $"{MeetingColumn.END_TIME} = @endTime, " +
                                 $"{MeetingColumn.LOCATION} = @location, " +
                                 $"{MeetingColumn.ORGANIZER_ID} = @organizerId " +
                                 $"WHERE {MeetingColumn.MEETING_ID} = @meetingId;";

            MySqlCommand? command = DatabaseManager.GetCommand(updateQuery);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@startTime", startTime.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@endTime", endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@organizerId", organizatorId);
            command.Parameters.AddWithValue("@meetingId", meetingId);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();


        }
    }
}
