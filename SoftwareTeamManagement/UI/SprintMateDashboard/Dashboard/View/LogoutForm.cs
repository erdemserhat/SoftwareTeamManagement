using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.Presenter;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    public partial class LogoutForm : Form, ILogoutForm
    {
        private static LogoutForm instance;
        public event EventHandler CancelButtonClicked;
        public event EventHandler LogoutButtonClicked;
        public LogoutForm()
        {
            InitializeComponent();
            instance = this;
            InitializeEvents();
            LogoutController controller = new LogoutController();
        }

        public static LogoutForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LogoutForm();
            }

            return instance;
        }

        private void InitializeEvents()
        {
            logoutBtn.Click += (sender, e) => LogoutButtonClicked?.Invoke(this, EventArgs.Empty);
            cancelBtn.Click += (sender, e) => CancelButtonClicked?.Invoke(this, EventArgs.Empty);
        }






    }
}
