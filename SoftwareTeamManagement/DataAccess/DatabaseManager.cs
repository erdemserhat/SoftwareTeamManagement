﻿using MySql.Data.MySqlClient;
using SoftwareTeamManagement.Constants.DatabaseConstants;
using System;

namespace SoftwareTeamManagement.DataAccess
{
    using System;
    using MySql.Data.MySqlClient;

    namespace DataAccess
    {
        public  class DatabaseManager
        {
            //Backing field property (underlying property)
            private static MySqlConnection _connection;

            //consant connection text
            private static readonly string ConnectionString = $"Server={DatabaseCredentials.Server};Database={DatabaseCredentials.DatabaseName};Uid={DatabaseCredentials.Username};Pwd={DatabaseCredentials.Password};";


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
                        MessageBox.Show("Connection ✓");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check your internet connection : " + ex.Message);

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
                        MessageBox.Show("Connection is closed ✓");
                        _connection = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error while closing the connection: " + ex.Message);

                    }

                }
            }
        }
    }

}