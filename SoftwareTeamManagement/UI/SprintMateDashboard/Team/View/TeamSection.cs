using SoftwareTeamManagement.UI.SprintMateDashboard.Team.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Team.View
{
    public partial class TeamSection : UserControl, ITeamSection
    {
        //Singleton object of the section
        private static TeamSection instance;
        TeamSectionController controller;

        //Events
        public event EventHandler UpdateProfileButtonClicked;


        //main constructor of class..
        public TeamSection()
        {
            InitializeComponent();
            instance = this;
            InitializeEvents();
            controller = new TeamSectionController();



        }




        //use this function to provide singleton object of the class...
        public static TeamSection GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TeamSection();
            }

            return instance;
        }

        public void ShowMemberList()
        {
            controller.PrepareMemberList();
        }

        public void InitializeEvents()
        {
            updateProfile.Click += (sender, e) => UpdateProfileButtonClicked(this, EventArgs.Empty);
        }
    }
}
