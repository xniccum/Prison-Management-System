using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PMSTest
{
    /// <summary>
    /// This is a class designed to handle all interactions with a database server. 
    /// It has the dummy username and password hard-coded as instance variables for the Prison Management Project of winter 2015
    /// To use, construct the object, then run openConnection() to connect to the database.
    /// Once connected the method verifyUsernamePassword(string, string) returns a boolean if the username and password are stored 
    /// in the User table of the database. 
    /// </summary>
    class SQLhandler
    {
        private string dummyUsername = "333Winter2014Prisoner";
        private string dummyPassword = "prisoner";
        string connectionString;
        SqlConnection dbConnection;
        private Boolean dbConnectionOpen = false;
        private Boolean userLoggedIn = false;
        private string userUsername = "";
        private string userPassword = "";
        
        /// <summary>
        /// Constructer. Takes no paramaters.
        /// </summary>
        public SQLhandler()
        {
            connectionString= "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=PMS; User ID=" + dummyUsername + "; password=" + dummyPassword + ";";
            openConnection();
        }

        /// <summary>
        /// Creates a connection to the database using the default dummy username and password. 
        /// All database interaction shoudl be done through this user. 
        /// </summary>
        /// <returns> Returns false if the connection could not be made, and true if it was successfully created</returns>
        public Boolean openConnection()
        {
            dbConnection = new SqlConnection();

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
        /// This method verifies a username and password. Currently does not use any sort of encryption. 
        /// This method will not run if there is not a valid connection to the database. 
        /// </summary>
        /// <param name="username">username as spelled in the User table.</param>
        /// <param name="password">password as spelled in the User table</param>
        /// <returns> returns a boolean corresponding to the validity of the Username/Password passed</returns>
        public Boolean verifyUsernamePassword(string username, string password)
        {
            if(!dbConnectionOpen)
                return false;

            SqlCommand verificationCommand = new SqlCommand();
            verificationCommand.CommandText = "dbo.pms_checkUsernamePassword";
            verificationCommand.CommandType = CommandType.StoredProcedure;
            verificationCommand.Connection = dbConnection;
            verificationCommand.Parameters.Add("@Username", SqlDbType.NVarChar);
            verificationCommand.Parameters.Add("@Password", SqlDbType.NVarChar);
            verificationCommand.Parameters["@Username"].Value = username;
            verificationCommand.Parameters["@Password"].Value = password;

            Object returned = verificationCommand.ExecuteScalar();
            Console.WriteLine(returned.ToString());
            if (returned.ToString() == "1") 
            {
                userLoggedIn = true;
                this.userUsername = username;
                this.userPassword = password;
                return true;
            }

            return false;
        }

        public Boolean userLogged()
        {

            return this.userLoggedIn;
        }

        public Boolean isConnected()
        {

            return dbConnectionOpen;
        }
        public Boolean logOut()
        {
            if (!this.userLoggedIn || !this.dbConnectionOpen)
            {
                return false;
            }
            this.userLoggedIn = false;
            this.userUsername = "";
            this.userPassword = "";
            return true;

        }
        //public SqlDataReader getGuardsReader()
        //{
        //    return new SqlDataReader();
        //}

        //public SqlDataReader getPrisonersReader()
        //{
        //    return new SqlDataReader();
        //}

        //public SqlDataReader getScheduleReader()
        //{
        //    return new SqlDataReader();
        //}

        }
}
