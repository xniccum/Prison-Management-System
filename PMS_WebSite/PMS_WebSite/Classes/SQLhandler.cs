using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PMS_WebSite.Classes
{
    /// <summary>
    /// This is a class designed to handle all interactions with a database server. 
    /// It has the dummy username and password hard-coded as instance variables for the Prison Management Project of winter 2015
    /// To use, construct the object, then run openConnection() to connect to the database.
    /// Once connected the method verifyUsernamePassword(string, string) returns a boolean if the username and password are stored 
    /// in the User table of the database. 
    /// </summary>
    public static class SQLhandler
    {
        private static string dummyUsername = "333Winter2014Prisoner";
        private static string dummyPassword = "prisoner";
        private static string connectionString;
        private static SqlConnection dbConnection;
        private static Boolean dbConnectionOpen = false;

        /// <summary>
        /// Creates a connection to the database using the default dummy username and password. 
        /// All database interaction shoudl be done through this user. 
        /// </summary>
        /// <returns> Returns false if the connection could not be made, and true if it was successfully created</returns>
        public static Boolean openConnection()
        {
            SqlConnection myConn = new SqlConnection();

            connectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=PMS; User ID=" + dummyUsername + "; password=" + dummyPassword + ";";
            dbConnection = new SqlConnection(connectionString);
            try
            {
                dbConnection.Open();
                dbConnectionOpen = true;
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// Closes an open connection to the database  
        /// <returns> Returns false if the connection could not be closed, and true if it was successfully closes</returns>
        public static Boolean closeConnection()
        {
            try
            {
                dbConnection.Close();
                dbConnectionOpen = false;
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// This method verifies a username and password. Currently does not use any sort of encryption. 
        /// This method will not run if there is not a valid connection to the database. 
        /// </summary>
        /// <param name="username">username as spelled in the User table.</param>
        /// <param name="password">password as spelled in the User table</param>
        /// <returns> returns a boolean corresponding to the validity of the Username/Password passed</returns>
        public static Boolean verifyUsernamePassword(string username, string password)
        {
            if (!dbConnectionOpen)
                return false;
            password = (password == null) ? " " : password;

            SqlCommand verificationCommand = new SqlCommand();
            verificationCommand.CommandText = "dbo.pms_checkUsernamePassword";
            verificationCommand.CommandType = CommandType.StoredProcedure;
            verificationCommand.Connection = dbConnection;
            verificationCommand.Parameters.Add("@Username", SqlDbType.NVarChar);
            verificationCommand.Parameters.Add("@Password", SqlDbType.NVarChar);
            verificationCommand.Parameters["@Username"].Value = username;
            verificationCommand.Parameters["@Password"].Value = password;

            Object returned = verificationCommand.ExecuteScalar();
            if (returned.ToString() == "1")
                return true;

            return false;
        }
    }
}