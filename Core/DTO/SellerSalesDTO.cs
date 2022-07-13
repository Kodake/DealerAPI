using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    /// <summary>
    /// Class for <see cref="SellerSalesDTO"/> dto
    /// </summary>
    public class SellerSalesDTO
    {
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
        /// Represents the Seller's total sales
        /// </summary>
        public int TotalSales { get; set; }
    }
}
