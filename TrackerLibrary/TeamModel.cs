using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {

        /// <summary>
        /// Represents the list of people in this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the team name.
        /// </summary>
        public string TeamName { get; set; }

    }
}
