using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.Constants.Queries
{
    public class AnnouncementQueries
    {
        //to keep destructured values
        private int? id;
        private string title;
        private string content;
        private DateTime dateCreated;


        //Use this constructor in repository in the cases of ;
        //-->Insert, Update, Delete
        public AnnouncementQueries(IAnnouncementContract announcement)
        {
            //desctructiring values
            id = announcement.AnnouncementId;
            title = announcement.Title;
            content = announcement.Content;
            dateCreated = announcement.DateCreated;

        }

        //Use this constructor in repository in the cases of ;
        //-->Read Data
        public AnnouncementQueries()
        {
          

        }

        public string GenerateInsertQuery()
        {
            string addQuery = $"INSERT INTO {DatabaseTable.TABLE_ANNOUNCEMENT} " +
            $"({AnnouncementColumn.TITLE}, {AnnouncementColumn.CONTENT}, {AnnouncementColumn.DATE_CREATED}) " +
            $"VALUES ('{title}', '{content}', '{dateCreated:yyyy-MM-dd HH:mm:ss}');";

            return addQuery;

        }

        public string GenerateDeleteQuery()
        {
            string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_ANNOUNCEMENT} WHERE {AnnouncementColumn.ANNOUNCEMENT_ID} ={id};";
            return deleteQuery;
        }

        public string GenerateUpdateQuery()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_ANNOUNCEMENT} SET {AnnouncementColumn.TITLE} = '{title}', {AnnouncementColumn.CONTENT} = '{content}' WHERE {AnnouncementColumn.ANNOUNCEMENT_ID}={id};";

            return updateQuery;

        }

        public string GenerateSelectQuery()
        {
            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_ANNOUNCEMENT};";
            return selectQuery;

        }
    }
}
