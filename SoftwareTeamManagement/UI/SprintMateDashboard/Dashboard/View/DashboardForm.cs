﻿using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.Presenter;

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

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(announcementsBtn, "Bu bir butondur.");



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
            tasksBtn.BackColor = Color.FromArgb(34, 40, 49);

        }

        private void projectsBtn_MouseEnter(object sender, EventArgs e)
        {
            projectsBtn.BackColor = Color.FromArgb(95, 106, 115);
        }

        private void projectsBtn_MouseLeave(object sender, EventArgs e)
        {
            projectsBtn.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void teamBtn_MouseEnter(object sender, EventArgs e)
        {
            teamBtn.BackColor = Color.FromArgb(95, 106, 115);
        }

        private void teamBtn_MouseLeave(object sender, EventArgs e)
        {
            teamBtn.BackColor = Color.FromArgb(34, 40, 49);
        }

        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.FromArgb(95, 106, 115);
        }

        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            logoutBtn.BackColor = Color.FromArgb(34, 40, 49);
        }
    }
}
