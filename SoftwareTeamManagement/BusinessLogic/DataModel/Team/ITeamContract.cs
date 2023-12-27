namespace SoftwareTeamManagement.BusinessLogic.DataModel.Team
{
    public interface ITeamContract
    {

        string Name { get; set; }
        string Description { get; set; }


        int Id { get; set; }
    }
}
