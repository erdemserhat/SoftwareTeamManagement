using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View
{
    public partial class DashboardForm : Form, IDashboardForm
    {
        public string userEmail;
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
        private static DashboardForm instance;
        public static DashboardForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {

                instance = new DashboardForm();

            }
            return instance;
        }







    }
}
