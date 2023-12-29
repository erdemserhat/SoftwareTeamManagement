using SoftwareTeamManagement.Constants.DatabaseConstants;

namespace SoftwareTeamManagement.DataAccess
{
    using MySql.Data.MySqlClient;
    using SoftwareTeamManagement.UI.CustomMessageBox;
    using System;

    namespace DataAccess
    {
        public class DatabaseManager
        {
            //Backing field property (underlying property)
            private static MySqlConnection _connection;

            //consant connection text
            private static readonly string ConnectionString = DatabaseCredentials.CONNECTION_STRING;


            //Implementation of Singleton Design Pattern
            public static MySqlConnection GetConnection()
            {
                //If connection is null, then instantiate an new MySqlConnection object,
                //and open the connection
                if (_connection == null)
                {
                    try
                    {
                        _connection = new MySqlConnection(ConnectionString);
                        _connection.Open();
                        //MessageBox.Show("Connection ✓");

                    }
                    catch (Exception ex)
                    {
                        CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("Please check your internet connection : " + ex.Message);
                        

                    }


                }

                return _connection;
            }

            public static void CloseConnection()
            {
                //If connection is established, closes the connection
                if (_connection != null)
                {
                    try
                    {
                        _connection.Close();
                        //MessageBox.Show("Connection is closed ✓");
                        _connection = null;
                    }
                    catch (Exception ex)
                    {
                        
                        CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("An error while closing the connection: " + ex.Message);

                    }

                }
            }

            //
            public static void ExecuteQuery(string query)
            {
                MySqlConnection connection = GetConnection();
                if (connection != null)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        // MessageBox.Show("Query executed successfully ✓");
                    }
                    catch (Exception ex)
                    {
                        CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm("An error occurred while executing the query: " + ex.Message);
                       
                    }
                    finally
                    {
                        CloseConnection();
                    }
                }
            }


            public static MySqlDataReader? GetReader(string selectQuery)
            {
                MySqlConnection connection = GetConnection();
                MySqlDataReader reader = null;
                if (connection != null)
                {
                    try
                    {
                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        reader = command.ExecuteReader();
                        // MessageBox.Show("Reader is created successfully ✓");

                    }
                    catch (Exception ex)
                    {
                        CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm(ex.Message);
                        
                    }
                    finally
                    {


                    }
                }
                return reader;

            }

            public static MySqlCommand? GetCommand(string query)
            {
                MySqlConnection connection = GetConnection();
                MySqlCommand? command = null;


                if (connection != null)
                {
                    try
                    {
                        command = new MySqlCommand(query, connection);

                        // MessageBox.Show("Command  is created successfully ✓");

                    }
                    catch (Exception ex)
                    {
                        CustomErrorMessageBoxForm message = new CustomErrorMessageBoxForm(ex.Message);
                       
                    }
                    finally
                    {


                    }
                }
                return command;

            }
        }
    }
}

