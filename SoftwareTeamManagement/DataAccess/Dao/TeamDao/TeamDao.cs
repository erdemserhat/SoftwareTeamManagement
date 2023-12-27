using MySql.Data.MySqlClient;
using SoftwareTeamManagement.BusinessLogic.DataModel.Team;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamDao
{
    public class TeamDao : ITeamDaoContract
    {
        private int id;
        private string name;
        private string description;

        public TeamDao(ITeamContract team)
        {
            id = team.Id;
            name = team.Name;
            description = team.Description;
        }

        public TeamDao()
        {
        }

        public void AddTeam()
        {
            string insertQuery = $"INSERT INTO {DatabaseTable.TABLE_TEAM} " +
                                 $"({TeamColumn.NAME}, {TeamColumn.DESCRIPTION}) " +
                                 $"VALUES (@name, @description)";

            MySqlCommand? command = DatabaseManager.GetCommand(insertQuery);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public void DeleteTeam()
        {
            string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_TEAM} WHERE {TeamColumn.ID} = @id";

            MySqlCommand? command = DatabaseManager.GetCommand(deleteQuery);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }

        public List<ITeamContract> GetTeams()
        {
            List<ITeamContract> teams = new List<ITeamContract>();

            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_TEAM}";
            MySqlDataReader? reader = DatabaseManager.GetReader(selectQuery);

            if (reader != null)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(TeamColumn.ID);
                    string name = reader.GetString(TeamColumn.NAME);
                    string description = reader.GetString(TeamColumn.DESCRIPTION);

                    ITeamContract team = new Team(id, name, description);
                    teams.Add(team);
                }

                reader.Close();
                DatabaseManager.CloseConnection();
            }

            return teams;
        }

        public void UpdateTeam()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_TEAM} SET " +
                                 $"{TeamColumn.NAME} = @name, " +
                                 $"{TeamColumn.DESCRIPTION} = @description " +
                                 $"WHERE {TeamColumn.ID} = @id;";

            MySqlCommand? command = DatabaseManager.GetCommand(updateQuery);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            DatabaseManager.CloseConnection();
        }
    }
}
