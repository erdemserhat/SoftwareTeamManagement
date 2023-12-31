﻿using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.Login.Controller;
using SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.Meetings.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.Projects.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Dashboard.Presenter
{
    public class DashboardController
    {
        private IDashboardForm _view = DashboardForm.GetInstance();
        private TeamMember _member;

        public DashboardController()
        {
            _view.TasksButtonClicked += OnTaskButtonClicked;
            _view.ProjectsButtonClicked += OnProjectsButtonClicked;
            _view.TeamButtonClicked += OnTeamButtonClicked;
            _view.AnnouncementButtonClicked += OnAnnouncementButtonClicked;
            _view.MeetingButtonClicked += OnMeetingButtonClicked;
            _view.LogoutButtonClicked += OnLogoutButtonClicked;
            ConfigureUserDataModel();
            SetWelcomeText();

        }

        //Implementations...

        //When user navigates the task section
        public void OnTaskButtonClicked(object sender, EventArgs e)
        {

            //Adding the relavent panel..
            DashboardForm.GetInstance().mainSectionPanel.Controls.Clear();
            DashboardForm.GetInstance().mainSectionPanel.Controls.Add(TasksSection.GetInstance()); 

        }

        //When user navigates the projects section
        public void OnProjectsButtonClicked(object sender, EventArgs e)
        {
            DashboardForm.GetInstance().mainSectionPanel.Controls.Clear();
            DashboardForm.GetInstance().mainSectionPanel.Controls.Add(ProjectSection.GetInstance());

        }

        //When user navigates the team section
        public void OnTeamButtonClicked(object sender, EventArgs e)
        {

        }

        //When user navigates the announcements section
        public void OnAnnouncementButtonClicked(object sender, EventArgs e)
        {

        }

        //When user navigates the meetings section
        public void OnMeetingButtonClicked(object sender, EventArgs e)
        {

        }

        //When user navigates the logout section
        public void OnLogoutButtonClicked(object sender, EventArgs e)
        {

        }
        
        public void ConfigureUserDataModel()
        {
            TeamMemberRepository repo = new TeamMemberRepository();
          
            _member = repo.ProvideUserDataModelByEmail(UserDataModelTransferLoginToDashboard.GetEmail());

        }

       //Costumizing User Experience...

        public void SetWelcomeText()
        {
           _view.WelcomeText=$"Welcome, {_member.FullName}!";
        }

      





    }








}