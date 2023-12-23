
using SoftwareTeamManagement;

using MySql.Data.MySqlClient;
using SoftwareTeamManagement.Constants.DatabaseConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;

using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.DataAccess.Dao.AnnouncementDao;
using SoftwareTeamManagement.BusinessLogic.DataModel.Announcement;
using SoftwareTeamManagement.DataAccess.Repository;
using SoftwareTeamManagement.BusinessLogic.DataModel.Meeting;
using SoftwareTeamManagement.DataAccess.Dao.MeetingDao;
using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;
using SoftwareTeamManagement.BusinessLogic.DataModel.Enums;
using SoftwareTeamManagement.BusinessLogic.DataModel.Team;
using SoftwareTeamManagement.BusinessLogic.Configuration.Roles;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.TaskPermission;

using SoftwareTeamManagement.ui.main_dashboard;
using SoftwareTeamManagement.ui.login;

namespace SoftwareTeamManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            //AnnouncementRepository repo = new AnnouncementRepository();
            // repo.AddAnnouncement(new Announcement("İlan Başlığı", "İlan Açıklaması", DateTime.Now));
            //repo.RemoveAnnouncement(new Announcement(7));
            // Announcement a = new Announcement("İlan Başlığı", "İlan Açıklaması", DateTime.Now);
            //Announcement updated = a with { AnnouncementId = 6, Content = "1212" };

            // List<IAnnouncementContract> announcements = repo.GetAnnoucements();

            //Meeting meeting = new Meeting("toplantı var",DateTime.Now, DateTime.Now,"ev",2);
            //MeetingRepository repository = new MeetingRepository();
            // repository.AddMeeting(meeting);
            //repository.EditMeeting(meeting with { Location="yurt", MeetingId=1} );
            //repository.RemoveMeeting(meeting with { MeetingId=3});
            //var a = repository.GetMeetings();
            //MessageBox.Show(a.Count().ToString());

            //Project project = new Project("benim projem","proje açıklaması");

            // ProjectRepository repository = new ProjectRepository();
            //repository.AddProject(project);
            // repository.EditProject(project with { Id=1});
            //repository.RemoveProject(project with { Id=2});

            //var a = repository.GetProjects();
            // MessageBox.Show(a[0].Description);

            // Task task = new Task("görev başlığı", "görev açıklaması",PriorityLevelHelper.getPriority(PriorityLevel.Medium), DateTime.Now, TaskCatagoryHelper.GetCatagory(TaskCatagory.Done));

            // TaskRepository repository = new TaskRepository();
            // repository.AddTask(task);
            //repository.EditTask(task with {Id=2, Description="güncellenen açıklama" });
            //repository.RemoveTask(task with { Id=1});
            // List<ITaskContract> a = repository.GetTasks();
            // MessageBox.Show(a[0].CreatedTime.ToString());

           // Team team = new Team("X Takımı", "Projemya !");
           // TeamRepository repository = new TeamRepository();
           //  repository.AddTeam(team);
            //repository.EditTeam(team with {Id=1, Description="upddd"});
            // repository.RemoveTeam(team with { Id=1});
            //List<ITeamContract> a = repository.GetTeams();
            //MessageBox.Show(a[0].Name);

           // TeamMember teamMember = new TeamMember("serhat","me.serhaterdem@gmail.com","erdem3451",new Role(RoleType.SoftwareProjectManager,RoleDepartment.ITInfrastructure),new TaskPermissionSet(false, false,false),new ProjectPermissionSet(false, false, false,false,false,false,false,false));

           // TeamMemberRepository repo = new TeamMemberRepository();
            //repo.AddTeamMember(teamMember with { FullName="samet berkant koca", Email="example@gmail.com"});
            //repo.EditTeamMember(teamMember with { Id = 3, TaskPermissionSetContract = new TaskPermissionSet(true, true, true) });
            // repo.EditTeamMember(teamMember with { Id = 2, ProjectPermissionSet =new ProjectPermissionSet(true, true, true, true, true, true, true, true) });
            //repo.RemoveTeamMember(teamMember with { Id=1});
           // List<TeamMember> members = repo.GetTeamMembers();
           // foreach (TeamMember member in members)
           // {
                
           //     {
               //     MessageBox.Show($"{member.ProjectPermissionSet.CanUpdateMemberPermissionSetInformation}");  
            //    }
          //  }
























             ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}