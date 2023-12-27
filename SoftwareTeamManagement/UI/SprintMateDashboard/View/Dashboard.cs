namespace SoftwareTeamManagement.UI.SprintMateDashboard.View
{
    public partial class Dashboard : Form
    {
        private static Dashboard instance;
        public string userEmail;
        public Dashboard()
        {
            InitializeComponent();
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
