using MySql.Data.MySqlClient;
using SoftwareTeamManagement.BusinessLogic.DataModel.Project;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;

namespace SoftwareTeamManagement.DataAccess.Dao.ProjectDao
{
    public class ProjectDao : IProjectDaoContract
    {
        private int id;
        private string name;
        private string description;

        public ProjectDao(IProjectContract project)
        {
            this.id = project.Id;
            this.name = project.Name;
            this.description = project.Description;
        }

        public ProjectDao()
        {
        }

        public void DeleteProject()
        {
            string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_PROJECT} WHERE {ProjectColumn.ID} = @id";

            MySqlCommand? command = DatabaseManager.GetCommand(deleteQuery);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public List<IProjectContract> GetAllProjects()
        {
            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_PROJECT}";
            MySqlDataReader? reader = DatabaseManager.GetReader(selectQuery);
            List<IProjectContract> projects = new List<IProjectContract>();

            if (reader != null)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(ProjectColumn.ID);
                    string name = reader.GetString(ProjectColumn.NAME);
                    string description = reader.GetString(ProjectColumn.DESCRIPTION);

                    // Project sınıfını kullanarak record oluşturuluyor
                    Project project = new Project(id, name, description);
                    projects.Add(project);
                }

                reader.Close();
                DatabaseManager.CloseConnection();
            }

            return projects;
        }

        public void InsertProject()
        {
            string insertQuery = $"INSERT INTO {DatabaseTable.TABLE_PROJECT} " +
                          $"({ProjectColumn.NAME}, {ProjectColumn.DESCRIPTION}) " +
                          $"VALUES (@name, @description)";

            MySqlCommand? command = DatabaseManager.GetCommand(insertQuery);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public void UpdateProject()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_PROJECT} SET " +
                                 $"{ProjectColumn.NAME} = @name, " +
                                 $"{ProjectColumn.DESCRIPTION} = @description " +
                                 $"WHERE {ProjectColumn.ID} = @id;";

            MySqlCommand? command = DatabaseManager.GetCommand(updateQuery);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }
    }
}
