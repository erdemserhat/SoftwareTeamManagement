using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts
{
    public interface ITeamMemberProjectContract
    {
        void ChangeProjectName(string name);
        void UpdateDeadline(DateTime? deadline);
        void UpdateProjectDescription(string description);
        void AddMember(TeamMember member);
        void RemoveMember(TeamMember member);
        void DeleteMember(TeamMember member);
        void ResetMemberPassword(string password,int userId);
       // void Makeannounce(Announcement announcement);
       // void HoldMeeting(Meeting meeting);
        void EditMemberPermisions()




    }
}
