using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.DataModel.Announcement
{
    public interface IAnnouncementContract
    {
        int AnnouncementId { get; set; }
        string Title { get; set; }
        string Content { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
        bool IsPublished { get; set; }
        // ... other properties or methods if needed
    }
}
