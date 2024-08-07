using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represnets unique identifier for the person
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the firstname of this person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the lastname of this person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the emailaddres of this person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of this person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }
    }
}
