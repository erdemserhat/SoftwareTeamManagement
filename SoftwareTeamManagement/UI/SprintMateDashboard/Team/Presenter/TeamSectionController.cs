using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.UI.CustomMessageBox;
using SoftwareTeamManagement.UI.SprintMateDashboard.Tasks.View;
using SoftwareTeamManagement.UI.SprintMateDashboard.Team.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTeamManagement.UI.SprintMateDashboard.Team.Presenter
{
    public class TeamSectionController
    {
        //Providing TeamSection object by injecting depedency as Singleton object...
        private ITeamSection _view = TeamSection.GetInstance();


        //constructor of controller class...
        public TeamSectionController()
        {
            BindEvents();
            PrepareMemberList();
        }


        //Binding events and their implementation methods..
        private void BindEvents()
        {
            _view.UpdateProfileButtonClicked += OnUpdateProfileButtonClicked;
        }

        //event implementations...

        //This function runs when updateProfileButton is clicked by user...
        private void OnUpdateProfileButtonClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        //Update member list...
        public void PrepareMemberList()
        {
            //getting repo to execute db op.
            TeamMemberRepository repo = new TeamMemberRepository();
            List<TeamMember> memberList = repo.GetTeamMembers();
           


            TeamSection.GetInstance().memberListView.BeginUpdate();
            TeamSection.GetInstance().memberListView.Items.Clear();

            foreach (var member in memberList)
            {

                ListViewItem item = new ListViewItem(member.Id.ToString());
                item.SubItems.Add(member.FullName);
                item.SubItems.Add(member.RoleContract.RoleTypeInformation());
                item.SubItems.Add(member.RoleContract.RoleDepartmentInformation());
                item.SubItems.Add(member.Email);



                TeamSection.GetInstance().memberListView.Items.Add(item);
            }

            TeamSection.GetInstance().memberListView.EndUpdate();
        }

    }
}
