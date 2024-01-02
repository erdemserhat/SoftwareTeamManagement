using SoftwareTeamManagement.UI.Login.Controller;
using SoftwareTeamManagement.UI.Login.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.Presenter
{
    public class LogoutController
    {
        private ILogoutForm _view = LogoutForm.GetInstance();

        public LogoutController()
        {
            _view.CancelButtonClicked += OnCancelButtonClicked;
            _view.LogoutButtonClicked += OnLogoutButtonClicked;
        }

        private void OnCancelButtonClicked(object sender, EventArgs e)
        {

            LogoutForm.GetInstance().Hide();
        }

        private void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            UserDataModelTransferLoginToDashboard.Reset();
            LoginForm.GetInstance().Show();
            DashboardForm.GetInstance().Dispose();
            LogoutForm.GetInstance().Hide();





        }
    }
}
