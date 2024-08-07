using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represents a prize for a place in a tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represnets unique identifier for the prize
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Represents wich place recieves this price.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represnts the name of the place in the rankings.
        /// </summary>
        /// <example>
        /// Winner
        /// </example>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the amount of money the prize is.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the total prize money this 
        /// place recieves.
        /// </summary>
        /// <example>
        /// The Winner recieves 50% of the total amount of money given 
        /// as prize money.
        /// </example>
        public decimal PrizePercentage { get; set; }

        
    }
}
