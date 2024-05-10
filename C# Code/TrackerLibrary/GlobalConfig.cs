using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    /// <summary>
    /// Global static calss that holds unchanging information that needs to be set when the program starts
    /// </summary>
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PersonFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        /// <summary>
        /// A list of the diffrent sort of connections where data will be sored
        /// </summary>
        /// <example>
        /// database,textfile
        /// </example>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Initializes the connections that was chosen to store data in
        /// </summary>
        /// <param name="databse">boolean that detirmens if a database should be used to store data</param>
        /// <param name="textFile">boolean that detirmens if a text file should be used to store data</param>
        public static void InitializeConnections(DatabaseType type)
        {

            switch (type)
            {
                case DatabaseType.SQL:
                    //TODO - Set up the SQL connector properly
                    SqlConnector sqlConnector = new SqlConnector();
                    Connection = sqlConnector;
                    break;
                case DatabaseType.TextFile:
                    //TODO - Set up the text connection properly
                    TextConnector textConnection = new TextConnector();
                    Connection = textConnection;
                    break;
            }
        }

        /// <summary>
        /// Returns the connection string
        /// </summary>
        /// <param name="name">Represents the name of the connectionstring wanted</param>
        /// <returns>the connectionstring with name specified</returns>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
