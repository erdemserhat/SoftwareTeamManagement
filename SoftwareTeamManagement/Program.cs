using SoftwareTeamManagement.ui.loginForm;
using SoftwareTeamManagement.ui.registerForm.EmailRegisterForm;
using SoftwareTeamManagement.view.welcomeForm;
using SoftwareTeamManagement;
using SoftwareTeamManagement.ui.registerForm.IdentifyEmailForm;
using SoftwareTeamManagement.ui.registerForm.UltimateRegisterForm;
using SoftwareTeamManagement.ui.dashboards.leaderDashboard;
using MySql.Data.MySqlClient;
using SoftwareTeamManagement.Constants.DatabaseConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;

using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao;
using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.DataAccess.Dao.MeetingDao;

namespace SoftwareTeamManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            IMeetingContract meeting = new Meeting("Serhatın Toplantısı", new DateTime(2022, 1, 1, 12, 30, 00), new DateTime(2023, 12, 12, 12, 00, 00), "Fırat Üniversitesi",2);
            MeetingDao dao = new MeetingDao(meeting);
            dao.AddMeeting();








            // ApplicationConfiguration.Initialize();
            //Application.Run(new WelcomeForm());
        }
    }
}