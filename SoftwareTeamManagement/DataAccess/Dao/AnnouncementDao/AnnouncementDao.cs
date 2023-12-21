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
using SoftwareTeamManagement.Constants.Queries;
using MySql.Data.MySqlClient;

namespace SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao
{
    public class AnnouncementDao : IAnnouncementDaoContract
    {
        private AnnouncementQueries generator;


        //Dependency injection as param.
        public AnnouncementDao(IAnnouncementContract announcement)
        {
            generator = new AnnouncementQueries(announcement);



        }

        public AnnouncementDao()
        {
            generator = new AnnouncementQueries();
        }
        public void AddAnnouncement()
        {
            string addQuery = generator.GenerateInsertQuery();
            DatabaseManager.ExecuteQuery(addQuery);
        }

        public void DeleteAnnouncement()
        {
            string deleteQuery = generator.GenerateDeleteQuery();
            DatabaseManager.ExecuteQuery(deleteQuery);

        }

        public List<IAnnouncementContract> GetAllAnnouncements()
        {
            string selectQuery = generator.GenerateSelectQuery();
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
            string updateQuery = generator.GenerateUpdateQuery();
            DatabaseManager.ExecuteQuery(updateQuery);

        }


    }
}
