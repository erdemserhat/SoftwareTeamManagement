using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using DatabaseTable = SoftwareTeamManagement.Constants.DatabaseTableConstants.DatabaseTable;
using MySql.Data.MySqlClient;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao
{
    public class AnnouncementDao : IAnnouncementDaoContract
    {
        private int? id;
        private string title;
        private string content;
        private DateTime dateCreated;


        //Dependency injection as param.
        public AnnouncementDao(IAnnouncementContract announcement)
        {
            //desctructiring values
            id = announcement.AnnouncementId;
            title = announcement.Title;
            content = announcement.Content;
            dateCreated = announcement.DateCreated;



        }

        public AnnouncementDao()
        {

        }
        public void AddAnnouncement()
        {
            string addQuery = $"INSERT INTO {DatabaseTable.TABLE_ANNOUNCEMENT} " +
                      $"({AnnouncementColumn.TITLE}, {AnnouncementColumn.CONTENT}, {AnnouncementColumn.DATE_CREATED}) " +
                      $"VALUES (@title, @content, @dateCreated)";


            MySqlCommand? command = DatabaseManager.GetCommand(addQuery);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@content", content);
            command.Parameters.AddWithValue("@dateCreated", dateCreated.ToString("yyyy-MM-dd HH:mm:ss"));

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public void DeleteAnnouncement()
        {
            string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_ANNOUNCEMENT} WHERE {AnnouncementColumn.ANNOUNCEMENT_ID} = @id";

            MySqlCommand? command = DatabaseManager.GetCommand(deleteQuery);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();


        }

        public List<IAnnouncementContract> GetAllAnnouncements()
        {
            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_ANNOUNCEMENT}";
            MySqlDataReader? reader = DatabaseManager.GetReader(selectQuery);
            List<IAnnouncementContract> announcements = new List<IAnnouncementContract>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(AnnouncementColumn.ANNOUNCEMENT_ID);
                    string title = reader.GetString(AnnouncementColumn.TITLE);
                    string content = reader.GetString(AnnouncementColumn.CONTENT);
                    DateTime dateTime = reader.GetDateTime(AnnouncementColumn.DATE_CREATED);
                    Announcement announcement = new Announcement(id, title, content, dateTime);
                    announcements.Add(announcement);

                }

                reader.Close();
                DatabaseManager.CloseConnection();


            }

            return announcements;

        }

        public void UpdateAnnouncement()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_ANNOUNCEMENT} " +
                        $"SET {AnnouncementColumn.TITLE} = @title, {AnnouncementColumn.CONTENT} = @content " +
                        $"WHERE {AnnouncementColumn.ANNOUNCEMENT_ID} = @id";


            MySqlCommand? command = DatabaseManager.GetCommand(updateQuery);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@content", content);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();




        }


    }
}
