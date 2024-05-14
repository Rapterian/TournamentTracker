using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{


    /// <summary>
    /// Represents one mathcup in a round.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represnets unique identifier for the matchup
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents a List of entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// The ID from the database that will be used to identify the winner.
        /// </summary>
        public int WinnerID { get; set; }

        /// <summary>
        /// Represents the winner in the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents in wich round the matchup is.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName 
        { 
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
