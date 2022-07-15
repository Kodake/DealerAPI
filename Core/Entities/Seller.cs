using System.Collections.Generic;

namespace Core.Entities
{
    /// <summary>
    /// Class for <see cref="Sale"/> entity
    /// </summary>
    public class Seller
    {
        /// <summary>
        /// Represents the primary key for Seller's table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the Seller's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the Seller's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the Seller's identification number
        /// </summary>
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Represents the navigation prop for Sale's table
        /// </summary>
        public IList<Sale> Sales { get; set; }
    }
}
