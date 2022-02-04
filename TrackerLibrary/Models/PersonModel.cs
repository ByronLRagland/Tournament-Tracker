using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents individual team member's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents individual team member's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents individual team member's email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents individual team member's cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
