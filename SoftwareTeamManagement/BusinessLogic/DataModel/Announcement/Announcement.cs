namespace SoftwareTeamManagement.BusinessLogic.DataModel.Announcement
{
    public record class Announcement : IAnnouncementContract
    {
        // backing fields
        private int _announcementId = 0;
        private string _title;
        private string _content;
        private DateTime _dateCreated;


        //to dee
        public Announcement(int announcementId)
        {
            _announcementId = announcementId;

        }


        //to insert data
        public Announcement(string title, string content, DateTime dateCreated)
        {

            _title = title;
            _content = content;
            _dateCreated = dateCreated;
        }


        //to read and update data
        public Announcement(int announcementId, string title, string content, DateTime dateCreated) : this(announcementId)
        {
            _title = title;
            _content = content;
            _dateCreated = dateCreated;
        }

        public Announcement(int announcementId, string title, string content) : this(announcementId)
        {
            _title = title;
            _content = content;

        }









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



    }
}
