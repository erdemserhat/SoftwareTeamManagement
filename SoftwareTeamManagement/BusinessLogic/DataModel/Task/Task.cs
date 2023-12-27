namespace SoftwareTeamManagement.BusinessLogic.DataModel.Task
{
    public record class Task : ITaskContract
    {
        private int _id;
        private string _title;
        private string _description;
        private string _priorityLevel;
        private DateTime _createdTime;
        private string _catagory;

        public Task(int id, string title, string description, string priorityLevel, DateTime createdTime, string catagory)
        {
            _id = id;
            _title = title;
            _description = description;
            _priorityLevel = priorityLevel;
            _createdTime = createdTime;
            _catagory = catagory;
        }

        public Task(string title, string description, string priorityLevel, DateTime createdTime, string catagory)
        {
            _title = title;
            _description = description;
            _priorityLevel = priorityLevel;
            _createdTime = createdTime;
            _catagory = catagory;
        }

        public Task(int id)
        {
            _id = id;
        }

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public string PriorityLevel { get => _priorityLevel; set => _priorityLevel = value; }
        public DateTime CreatedTime { get => _createdTime; set => _createdTime = value; }

        public string TaskCatagory { get => _catagory; set => _catagory = value; }
        public int Id { get => _id; set => _id = value; }

    }
}
