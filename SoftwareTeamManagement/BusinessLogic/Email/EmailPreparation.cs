using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Repository;

namespace SoftwareTeamManagement.BusinessLogic.Email
{
    public static class EmailPreparation
    {
        public static string PrepareEmailBody(string email, int code)
        {

            TeamMemberRepository teamMemberRepository = new TeamMemberRepository();
            List<TeamMember> memberList = teamMemberRepository.GetTeamMembers();
            string fullname = "";

            foreach (var member in memberList)
            {
                if (member.Email == email)
                {
                    fullname = member.FullName; break;
                }

            }

            string body = $"Hello {fullname},\r\n\r\nYou have requested to reset your password. To complete the password reset process, you can use the 6-digit verification code below:\r\n\r\nVerification Code: {code}\r\n\r\nYou can use this verification code to enter the password reset screen and create your new password. For your security, please do not share this verification code with anyone.\r\n\r\nIf you did not request a password reset, you can disregard this email.\r\n\r\nIf you have any questions or need assistance, feel free to contact us.\r\n\r\nBest regards,\r\nSprint Mate  Team";




            return body;
        }
    }
}
