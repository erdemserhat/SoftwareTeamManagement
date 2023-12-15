using SoftwareTeamManagement.ui.loginForm;
using SoftwareTeamManagement.ui.registerForm.EmailRegisterForm;
using SoftwareTeamManagement.view.welcomeForm;
using SoftwareTeamManagement;
using SoftwareTeamManagement.ui.registerForm.IdentifyEmailForm;
using SoftwareTeamManagement.ui.registerForm.UltimateRegisterForm;
using SoftwareTeamManagement.ui.dashboards.leaderDashboard;

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
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeForm());
        }
    }
}