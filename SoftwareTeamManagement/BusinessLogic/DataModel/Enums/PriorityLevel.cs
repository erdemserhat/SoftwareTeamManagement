namespace SoftwareTeamManagement.BusinessLogic.DataModel.Enums
{
    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

    public static class PriorityLevelHelper
    {
        public static string getPriority(PriorityLevel priorityLevel)
        {
            Dictionary<PriorityLevel, string> keyValuePairs = new Dictionary<PriorityLevel, string> {

                { PriorityLevel.High, priorityLevel.ToString() },
                {PriorityLevel.Low, priorityLevel.ToString() },
                {PriorityLevel.Medium, priorityLevel.ToString() }



            };

            return keyValuePairs[priorityLevel];



        }
    }
}
