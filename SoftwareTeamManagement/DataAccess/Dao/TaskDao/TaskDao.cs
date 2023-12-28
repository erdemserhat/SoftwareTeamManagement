using MySql.Data.MySqlClient;
using SoftwareTeamManagement.BusinessLogic.DataModel.Task;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;
using Task = SoftwareTeamManagement.BusinessLogic.DataModel.Task.Task;

namespace SoftwareTeamManagement.DataAccess.Dao.TaskDao
{
    public class TaskDao : ITaskDaoContract
    {
        private int id;
        private string title;
        private string description;
        private string priortiyLevel;
        private DateTime cretedTime;
        private string catagory;

        public TaskDao(ITaskContract task)
        {
            id = task.Id;
            title = task.Title;
            priortiyLevel = task.PriorityLevel;
            cretedTime = task.CreatedTime;
            catagory = task.TaskCatagory;
            description = task.Description;
        }

        public TaskDao()
        {
        }

        public void AddTask()
        {
            string insertQuery = $"INSERT INTO {DatabaseTable.TABLE_TASK} " +
                                 $"({TaskColumn.TITLE}, {TaskColumn.PRIORITY_LEVEL}, {TaskColumn.CREATED_TIME}, {TaskColumn.CATEGORY}, {TaskColumn.DESCRIPTION}) " +
                                 $"VALUES (@title, @priorityLevel, @createdTime, @category, @description)";

            MySqlCommand? command = DatabaseManager.GetCommand(insertQuery);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@priorityLevel", priortiyLevel);
            command.Parameters.AddWithValue("@createdTime", cretedTime.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@category", catagory);
            command.Parameters.AddWithValue("@description", description);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public void DeleteTask()
        {
            string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_TASK} WHERE {TaskColumn.ID} = @id";

            MySqlCommand? command = DatabaseManager.GetCommand(deleteQuery);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public List<ITaskContract> GetAllTasks()
        {
            List<ITaskContract> tasks = new List<ITaskContract>();

            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_TASK} WHERE {TaskColumn.DESCRIPTION} IS NOT NULL";
            MySqlDataReader? reader = DatabaseManager.GetReader(selectQuery);

            if (reader != null)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(TaskColumn.ID);
                    string title = reader.GetString(TaskColumn.TITLE);
                    string priorityLevel = reader.GetString(TaskColumn.PRIORITY_LEVEL);
                    DateTime createdTime = reader.GetDateTime(TaskColumn.CREATED_TIME);
                    string category = reader.GetString(TaskColumn.CATEGORY);
                    string description = reader.GetString(TaskColumn.DESCRIPTION);

                    Task task = new Task(id, title, description, priorityLevel, createdTime, category);
                    tasks.Add(task);
                }

                reader.Close();
                DatabaseManager.CloseConnection();
            }

            return tasks;
        }

        public void UpdateTask()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_TASK} SET " +
                                 $"{TaskColumn.TITLE} = @title, " +
                                 $"{TaskColumn.PRIORITY_LEVEL} = @priorityLevel, " +
                                 $"{TaskColumn.CREATED_TIME} = @createdTime, " +
                                 $"{TaskColumn.CATEGORY} = @category, " +
                                 $"{TaskColumn.DESCRIPTION} = @description " +
                                 $"WHERE {TaskColumn.ID} = @id;";

            MySqlCommand? command = DatabaseManager.GetCommand(updateQuery);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@priorityLevel", priortiyLevel);
            command.Parameters.AddWithValue("@createdTime", cretedTime.ToString("yyyy-MM-dd HH:mm:ss"));
            command.Parameters.AddWithValue("@category", catagory);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }
    }
}
