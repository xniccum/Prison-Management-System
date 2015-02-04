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
             public Boolean isUserLoggedIn()
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

        private DataTable executeSproc(SqlCommand command)
        {
            if (!dbConnectionOpen || !userLoggedIn)
                return new DataTable();
            SqlDataReader dataRead;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                dataRead = command.ExecuteReader();
            }
            catch
            {
                return new DataTable();
            }

            DataTable returnTable = new DataTable();
            returnTable.Load(dataRead);
            return returnTable;

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
            if (!dbConnectionOpen)
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
            if (returned.ToString() == "1")
            {
                userLoggedIn = true;
                this.userUsername = username;
                this.userPassword = password;
                return true;
            }

            return false;
        }

        public int checkUsernamePermissions(string username)
        {
            using (SqlCommand sprocCommand = new SqlCommand())
            {
                sprocCommand.CommandText = "dbo.pms_getPermissions";
                sprocCommand.CommandType = CommandType.StoredProcedure;
                sprocCommand.Connection = dbConnection;
                sprocCommand.Parameters.Add("@Username", SqlDbType.VarChar);
                sprocCommand.Parameters["@Username"].Value = username;

                Object returned = sprocCommand.ExecuteScalar();
                if (returned.ToString() == "1")
                    return 1;
                else if (returned.ToString() == "2")
                    return 2;
                else
                    return 0;
            }

        }


        public DataTable getGuardsDataTable()
        {
            using (SqlCommand sprocCommand = new SqlCommand("dbo.pms_guards", dbConnection))
            {
                return executeSproc(sprocCommand);
            }
        }
        
        public DataTable getAltercationTable()
        {
            using (SqlCommand sprocCommand = new SqlCommand("dbo.pms_altercations", dbConnection))
            {
                return executeSproc(sprocCommand);
            }
        }

        public DataTable getCellTable()
        {
            using (SqlCommand sprocCommand = new SqlCommand("dbo.pms_cell", dbConnection))
            {
                return executeSproc(sprocCommand);
            }
        }

        public DataTable getPrisonersTable()
        {

            using (SqlCommand sprocCommand = new SqlCommand("dbo.getAllPrisoners", dbConnection))
            {
                return executeSproc(sprocCommand);
            }
        }

        public DataTable getShiftsTable()
        {

            using (SqlCommand sprocCommand = new SqlCommand("dbo.pms_shifts", dbConnection))
            {
                return executeSproc(sprocCommand);
            }

        }





        }

}
