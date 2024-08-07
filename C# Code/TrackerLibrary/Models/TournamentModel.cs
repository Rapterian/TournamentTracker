using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represents one tournament.
    /// </summary>
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// Represnets unique identifier for the tournament
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the tournament Name.
        /// </summary>
        public string? TournamentName { get; set; }

        /// <summary>
        /// Represents the fee neede to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of all teams entered in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of prizes available.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();


        /// <summary>
        /// Represents the List of matchups in the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
