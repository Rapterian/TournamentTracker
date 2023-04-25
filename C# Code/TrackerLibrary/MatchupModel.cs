using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents one mathcup in a round.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents a List of entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the winner in the matchup.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents in wich round the matchup is.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
