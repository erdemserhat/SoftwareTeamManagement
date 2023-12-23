
using MySql.Data.MySqlClient;
using SoftwareTeamManagement.BusinessLogic.BaseDataModel.TeamMember;
using SoftwareTeamManagement.BusinessLogic.Configuration.Roles;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.ProjectPermission;
using SoftwareTeamManagement.BusinessLogic.Role.Permissions.TaskPermission;
using SoftwareTeamManagement.Constants.DatabaseColumnConstants;
using SoftwareTeamManagement.Constants.DatabaseTableConstants;
using SoftwareTeamManagement.DataAccess.DataAccess;
using DatabaseTable = SoftwareTeamManagement.Constants.DatabaseTableConstants.DatabaseTable;

namespace SoftwareTeamManagement.DataAccess.Dao.TeamMemberDao
{
    public class TeamMemberDao : ITeamMemberDaoContract
    {
        // Destructuring all properties to process
        private int id;
        private string fullName;
        private string email;
        private string password;

        // Role
        private string roleDepartment;
        private string roleType;

        // Task permissions
        private bool canAddTask;
        private bool canRemoveTask;
        private bool canEditTask;

        // Project permissions
        private bool canChangeProjectName;
        private bool canUpdateProjectDescription;

        // Member permissions
        private bool canAddMember;
        private bool canRemoveMember;
        private bool canResetMemberPassword;
        private bool canUpdateMemberPermissionSet;

        // Announce and meeting permissions
        private bool canAnnounce;
        private bool canHoldMeeting;

        public TeamMemberDao(TeamMember teamMember)
        {
            // Destructuring all properties to process
            id = teamMember.Id;
            fullName = teamMember.FullName;
            email = teamMember.Email;
            password = teamMember.Password;

            // Role
            roleDepartment = teamMember.RoleContract?.RoleDepartmentInformation();
            roleType = teamMember.RoleContract?.RoleTypeInformation();

            // Task permissions
            canAddTask = teamMember.TaskPermissionSetContract?.canAddTaskInformation() ?? false;
            canRemoveTask = teamMember.TaskPermissionSetContract?.canRemoveTaskInformation() ?? false;
            canEditTask = teamMember.TaskPermissionSetContract?.canEditTaskInformation() ?? false;

            // Project permissions
            canChangeProjectName = teamMember.ProjectPermissionSet?.CanChangeProjectNameInformation() ?? false;
            canUpdateProjectDescription = teamMember.ProjectPermissionSet?.CanUpdateProjectDescriptionInformation() ?? false;

            // Member permissions
            canAddMember = teamMember.ProjectPermissionSet?.CanAddMemberInformation() ?? false;
            canRemoveMember = teamMember.ProjectPermissionSet?.CanRemoveMemberInformation() ?? false;
            canResetMemberPassword = teamMember.ProjectPermissionSet?.CanResetMemberPasswordInformation() ?? false;
            canUpdateMemberPermissionSet = teamMember.ProjectPermissionSet?.CanUpdateMemberPermissionSetInformation() ?? false;

            // Announce and meeting permissions
            canAnnounce = teamMember.ProjectPermissionSet?.CanAnnounceInformation() ?? false;
            canHoldMeeting = teamMember.ProjectPermissionSet?.CanHoldMeetingInformation() ?? false;
        }

        //to read data
        public TeamMemberDao()
        { 
        }

            public void AddMember()
        {
            string addQuery = $"INSERT INTO {DatabaseTable.TABLE_TEAM_MEMBER}" +
                                          $"({TeamMemberColumn.ID}, {TeamMemberColumn.FULL_NAME}, {TeamMemberColumn.EMAIL}, {TeamMemberColumn.PASSWORD}, {TeamMemberColumn.ROLE_DEPARTMENT}, {TeamMemberColumn.ROLE_TYPE}, {TeamMemberColumn.CAN_ADD_TASK}, {TeamMemberColumn.CAN_REMOVE_TASK}, {TeamMemberColumn.CAN_EDIT_TASK}, {TeamMemberColumn.CAN_CHANGE_PROJECT_NAME}, {TeamMemberColumn.CAN_UPDATE_PROJECT_DESCRIPTION}, {TeamMemberColumn.CAN_ADD_MEMBER}, {TeamMemberColumn.CAN_REMOVE_MEMBER}, {TeamMemberColumn.CAN_RESET_MEMBER_PASSWORD}, {TeamMemberColumn.CAN_ANNOUNCE}, {TeamMemberColumn.CAN_HOLD_MEETING}, {TeamMemberColumn.CAN_UPDATE_MEMBER_PERMISSION_SET})" +
                                          $" VALUES (@Id, @FullName, @Email, @Password, @RoleDepartment, @RoleType, @CanAddTask, @CanRemoveTask, @CanEditTask, @CanChangeProjectName, @CanUpdateProjectDescription, @CanAddMember, @CanRemoveMember, @CanResetMemberPassword, @CanAnnounce, @CanHoldMeeting, @CanUpdateMemberPermissionSet);";

            try
            {
                using (MySqlCommand? command = DatabaseManager.GetCommand(addQuery))
                {
                    
                    command?.Parameters.AddWithValue("@Id", id);
                    command?.Parameters.AddWithValue("@FullName", fullName);
                    command?.Parameters.AddWithValue("@Email", email);
                    command?.Parameters.AddWithValue("@Password", password);
                    command?.Parameters.AddWithValue("@RoleDepartment", roleDepartment);
                    command?.Parameters.AddWithValue("@RoleType", roleType);
                    command?.Parameters.AddWithValue("@CanAddTask", canAddTask);
                    command?.Parameters.AddWithValue("@CanRemoveTask", canRemoveTask);
                    command?.Parameters.AddWithValue("@CanEditTask", canEditTask);
                    command?.Parameters.AddWithValue("@CanChangeProjectName", canChangeProjectName);
                    command?.Parameters.AddWithValue("@CanUpdateProjectDescription", canUpdateProjectDescription);
                    command?.Parameters.AddWithValue("@CanAddMember", canAddMember);
                    command?.Parameters.AddWithValue("@CanRemoveMember", canRemoveMember);
                    command?.Parameters.AddWithValue("@CanResetMemberPassword", canResetMemberPassword);
                    command?.Parameters.AddWithValue("@CanAnnounce", canAnnounce);
                    command?.Parameters.AddWithValue("@CanHoldMeeting", canHoldMeeting);
                    command?.Parameters.AddWithValue("@CanUpdateMemberPermissionSet", canUpdateMemberPermissionSet);

                    command?.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Hata oluştu: {ex.Message}");
            }
            finally
            {
                DatabaseManager.CloseConnection();
            }



        }

        public void DeleteMember()
        {
           string deleteQuery = $"DELETE FROM {DatabaseTable.TABLE_TEAM_MEMBER} WHERE {TeamMemberColumn.ID} = @Id;";
            try
            {
                using (MySqlCommand? command = DatabaseManager.GetCommand(deleteQuery))
                {
                   
                    command?.Parameters.AddWithValue("@Id", id);

                    command?.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            finally
            {
                DatabaseManager.CloseConnection();
            }
        }


        public List<TeamMember> getAllMembers()
        {
            List<TeamMember> members = new List<TeamMember>();
            string selectQuery = $"SELECT * FROM {DatabaseTable.TABLE_TEAM_MEMBER};";
            MySqlDataReader? reader = DatabaseManager.GetReader(selectQuery);

            if (reader != null)
            {
                while (reader.Read())
                {
                    int memberId = reader.GetInt32(TeamMemberColumn.ID);
                    string memberFullName = reader.GetString(TeamMemberColumn.FULL_NAME);
                    string memberEmail = reader.GetString(TeamMemberColumn.EMAIL);
                    string memberPassword = reader.GetString(TeamMemberColumn.PASSWORD);
                    string roleDepartment = reader.GetString(TeamMemberColumn.ROLE_DEPARTMENT);
                    string roleType = reader.GetString(TeamMemberColumn.ROLE_TYPE);
                    bool canAddTask = reader.GetBoolean(TeamMemberColumn.CAN_ADD_TASK);
                    bool canRemoveTask = reader.GetBoolean(TeamMemberColumn.CAN_REMOVE_TASK);
                    bool canEditTask = reader.GetBoolean(TeamMemberColumn.CAN_EDIT_TASK);
                    bool canChangeProjectName = reader.GetBoolean(TeamMemberColumn.CAN_CHANGE_PROJECT_NAME);
                    bool canUpdateProjectDescription = reader.GetBoolean(TeamMemberColumn.CAN_UPDATE_PROJECT_DESCRIPTION);
                    bool canAddMember = reader.GetBoolean(TeamMemberColumn.CAN_ADD_MEMBER);
                    bool canRemoveMember = reader.GetBoolean(TeamMemberColumn.CAN_REMOVE_MEMBER);
                    bool canResetMemberPassword = reader.GetBoolean(TeamMemberColumn.CAN_RESET_MEMBER_PASSWORD);
                    bool canAnnounce = reader.GetBoolean(TeamMemberColumn.CAN_ANNOUNCE);
                    bool canHoldMeeting = reader.GetBoolean(TeamMemberColumn.CAN_HOLD_MEETING);
                    bool canUpdateMemberPermissionSet = reader.GetBoolean(TeamMemberColumn.CAN_UPDATE_MEMBER_PERMISSION_SET);

                    //create a member
                    TeamMember member = new TeamMember
                    (
                        //assiging values
                        memberId,
                        memberFullName,
                        memberEmail,
                        memberPassword,

                        new Role(roleType,roleDepartment),
                        new TaskPermissionSet(canAddTask, canRemoveTask, canEditTask),
                        new ProjectPermissionSet(canChangeProjectName, canUpdateProjectDescription, canAddMember, canRemoveMember, canResetMemberPassword, canAnnounce, canHoldMeeting, canUpdateMemberPermissionSet)
                    );

                    //add the crated member to list
                    members.Add(member);
                }

                reader.Close();
                DatabaseManager.CloseConnection();
            }

            return members;



        }

        public void UpdateMember()
        {
            string updateQuery = $"UPDATE {DatabaseTable.TABLE_TEAM_MEMBER} SET " +
                                          $"{TeamMemberColumn.FULL_NAME} = @FullName, " +
                                          $"{TeamMemberColumn.EMAIL} = @Email, " +
                                          $"{TeamMemberColumn.PASSWORD} = @Password, " +
                                          $"{TeamMemberColumn.ROLE_DEPARTMENT} = @RoleDepartment, " +
                                          $"{TeamMemberColumn.ROLE_TYPE} = @RoleType, " +
                                          $"{TeamMemberColumn.CAN_ADD_TASK} = @CanAddTask, " +
                                          $"{TeamMemberColumn.CAN_REMOVE_TASK} = @CanRemoveTask, " +
                                          $"{TeamMemberColumn.CAN_EDIT_TASK} = @CanEditTask, " +
                                          $"{TeamMemberColumn.CAN_CHANGE_PROJECT_NAME} = @CanChangeProjectName, " +
                                          $"{TeamMemberColumn.CAN_UPDATE_PROJECT_DESCRIPTION} = @CanUpdateProjectDescription, " +
                                          $"{TeamMemberColumn.CAN_ADD_MEMBER} = @CanAddMember, " +
                                          $"{TeamMemberColumn.CAN_REMOVE_MEMBER} = @CanRemoveMember, " +
                                          $"{TeamMemberColumn.CAN_RESET_MEMBER_PASSWORD} = @CanResetMemberPassword, " +
                                          $"{TeamMemberColumn.CAN_ANNOUNCE} = @CanAnnounce, " +
                                          $"{TeamMemberColumn.CAN_HOLD_MEETING} = @CanHoldMeeting, " +
                                          $"{TeamMemberColumn.CAN_UPDATE_MEMBER_PERMISSION_SET} = @CanUpdateMemberPermissionSet " +
                                          $"WHERE {TeamMemberColumn.ID} = @Id;";
            try
            {
                using (MySqlCommand? command = DatabaseManager.GetCommand(updateQuery))
                {
                    

                    command?.Parameters.AddWithValue("@Id", id);
                    command?.Parameters.AddWithValue("@FullName", fullName);
                    command?.Parameters.AddWithValue("@Email", email);
                    command?.Parameters.AddWithValue("@Password", password);
                    command?.Parameters.AddWithValue("@RoleDepartment", roleDepartment);
                    command?.Parameters.AddWithValue("@RoleType", roleType);
                    command?.Parameters.AddWithValue("@CanAddTask", canAddTask);
                    command?.Parameters.AddWithValue("@CanRemoveTask", canRemoveTask);
                    command?.Parameters.AddWithValue("@CanEditTask", canEditTask);
                    command?.Parameters.AddWithValue("@CanChangeProjectName", canChangeProjectName);
                    command?.Parameters.AddWithValue("@CanUpdateProjectDescription", canUpdateProjectDescription);
                    command?.Parameters.AddWithValue("@CanAddMember", canAddMember);
                    command?.Parameters.AddWithValue("@CanRemoveMember", canRemoveMember);
                    command?.Parameters.AddWithValue("@CanResetMemberPassword", canResetMemberPassword);
                    command?.Parameters.AddWithValue("@CanAnnounce", canAnnounce);
                    command?.Parameters.AddWithValue("@CanHoldMeeting", canHoldMeeting);
                    command?.Parameters.AddWithValue("@CanUpdateMemberPermissionSet", canUpdateMemberPermissionSet);

                    command?.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            finally
            {
                DatabaseManager.CloseConnection();
            }
        }

    }
}
