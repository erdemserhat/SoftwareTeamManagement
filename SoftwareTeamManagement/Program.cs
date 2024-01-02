using SoftwareTeamManagement.UI.Splash.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View;

namespace SoftwareTeamManagement
{
    internal static class FF
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreenForm());
        }

    }
}
