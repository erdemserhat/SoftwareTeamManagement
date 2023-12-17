using System;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Announcement
{
    public class Announcement : IAnnouncementContract
    {
        // backing fields
        private int _announcementId;
        private string _title;
        private string _content;
        private DateTime _dateCreated;
        private DateTime _dateModified;
        private bool _isPublished;

        // Properties
        public int AnnouncementId
        {
            get { return _announcementId; }
            set { _announcementId = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }

        public DateTime DateModified
        {
            get { return _dateModified; }
            set { _dateModified = value; }
        }

        public bool IsPublished
        {
            get { return _isPublished; }
            set { _isPublished = value; }
        }

        // ... other properties

        // Constructor
        public Announcement()
        {
            // Constructor logic if needed
        }
    }
}
