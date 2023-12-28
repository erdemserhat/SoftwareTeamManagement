using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.View
{
    public partial class Dashboard : Form, IDashboard
    {
        //Instance of singleton form
        private static Dashboard instance;
        //to hold user's email info.
        public string userEmail;

        //implmeneting the IDashboard...
        public event EventHandler TasksButtonClicked;
        public event EventHandler ProjectsButtonClicked;
        public event EventHandler TeamButtonClicked;
        public event EventHandler AnnouncementButtonClicked;
        public event EventHandler MeetingButtonClicked;
        public event EventHandler LogoutButtonClicked;

        public Dashboard()
        {
            InitializeComponent();

            //Initialize events.
            tasksBtn.Click += (sender, e) => TasksButtonClicked?.Invoke(this, EventArgs.Empty);
            projectsBtn.Click += (sender, e) => ProjectsButtonClicked?.Invoke(this, EventArgs.Empty);
            teamBtn.Click += (sender, e) => TeamButtonClicked?.Invoke(this, EventArgs.Empty);
            teamBtn.Click += (sender, e) => AnnouncementButtonClicked?.Invoke(this, EventArgs.Empty);
            projectsBtn.Click += (sender, e) => ProjectsButtonClicked?.Invoke(this, EventArgs.Empty);
            projectsBtn.Click += (sender, e) => ProjectsButtonClicked?.Invoke(this, EventArgs.Empty);



        }


        public static Dashboard GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new Dashboard();
            }
            return instance;
        }






    }
}
