namespace SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember.TeamMemberContracts
{
    public interface ITeamMemberTaskContract
    {
        void AddTask(DataModel.Task.Task task);
        void DeleteTask(DataModel.Task.Task task);
        void UpdateTask(DataModel.Task.Task task);



    }
}
