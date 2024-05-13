using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represents one entry in a matchup.
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represnets unique identifier for the matchup entry
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The uniquw identifier for the team.
        /// </summary>
        public int TeamCompetingID { get; set; }

        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for that team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// the unique identifier for the matchup that this team came from
        /// </summary>
        public int ParentMatchupID { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from
        /// as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
