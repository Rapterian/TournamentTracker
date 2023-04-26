using System;
using System.Collections.Generic;
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
      
        /// <summary>
        /// A list of the diffrent sort of connections where data will be sored
        /// </summary>
        /// <example>
        /// database,textfile
        /// </example>
        public  static List<IDataConnection> Connections { get; private set; }= new List<IDataConnection>();

        /// <summary>
        /// Initializes the connections that was chosen to store data in
        /// </summary>
        /// <param name="databse">boolean that detirmens if a database should be used to store data</param>
        /// <param name="textFile">boolean that detirmens if a text file should be used to store data</param>
        public static void InitializeConnections(bool databse,bool textFile)
        {
            if (databse)
            {
                //TODO - Set up the SQL connector properly
                SqlConnector sqlConnector = new SqlConnector();
                Connections.Add(sqlConnector);
            }

            if(textFile)
            {
                //TODO - Set up the text connection properly
                TextConnector textConnection = new TextConnector();
                Connections.Add(textConnection);
            }
        }
    }
}
