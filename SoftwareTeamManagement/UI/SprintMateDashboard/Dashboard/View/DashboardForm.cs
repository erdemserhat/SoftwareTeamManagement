using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.Presenter;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    public partial class DashboardForm : Form, IDashboardForm
    {

        //Constructor of Main Menu
        public DashboardForm()
        {
            InitializeComponent();
            instance = this;
            DashboardController controller = new DashboardController();
            InitializeEvents();



        }

        //IDashboard Form İmpl.
        public event EventHandler? TasksButtonClicked;
        public event EventHandler? ProjectsButtonClicked;
        public event EventHandler? TeamButtonClicked;
        public event EventHandler? AnnouncementButtonClicked;
        public event EventHandler? MeetingButtonClicked;
        public event EventHandler? LogoutButtonClicked;
        public string WelcomeText { set => welcomeText.Text = value; }


        private void InitializeEvents()
        {
            tasksBtn.Click += (sender, e) => TasksButtonClicked?.Invoke(sender, e);
            projectsBtn.Click += (sender, e) => ProjectsButtonClicked?.Invoke(sender, e);
            teamBtn.Click += (sender, e) => TeamButtonClicked?.Invoke(sender, e);
            announcementsBtn.Click += (sender, e) => AnnouncementButtonClicked?.Invoke(sender, e);
            meetingsBtn.Click += (sender, e) => MeetingButtonClicked?.Invoke(sender, e);
            logoutBtn.Click += (sender, e) => LogoutButtonClicked?.Invoke(sender, e);
        }





        //Singleton impl. of form
        public static DashboardForm instance;



        public static DashboardForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new DashboardForm();

            }
            return instance;
        }

        private void tasksBtn_MouseEnter(object sender, EventArgs e)
        {
            tasksBtn.BackColor = Color.FromArgb(95, 106, 115);
        }

        private void tasksBtn_MouseLeave(object sender, EventArgs e)
        {
            tasksBtn.BackColor = Color.FromArgb(6, 6, 6);

        }

        private void welcomeText_Click(object sender, EventArgs e)
        {

        }


    }
}
