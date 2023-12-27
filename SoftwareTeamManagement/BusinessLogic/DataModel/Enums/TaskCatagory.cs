namespace SoftwareTeamManagement.BusinessLogic.DataModel.Enums
{
    public enum TaskCatagory
    {
        ToDo,
        InProgress,
        Done
    }


    public static class TaskCatagoryHelper
    {
        public static string GetCatagory(TaskCatagory taskCatagory)
        {
            Dictionary<TaskCatagory, string> catogryStringPair = new Dictionary<TaskCatagory, string>
        {
            {TaskCatagory.ToDo, "To Do" },
            {TaskCatagory.InProgress, "In Progress" },
            {TaskCatagory.Done, "Done" }

        };

            return catogryStringPair[taskCatagory];

        }

    }

}

