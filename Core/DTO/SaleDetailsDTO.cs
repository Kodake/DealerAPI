using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    /// <summary>
    /// Class for <see cref="SaleDetailsDTO"/> dto
    /// </summary>
    public class SaleDetailsDTO
    {
        /// <summary>
        /// Represents the foreign key for Seller's table
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Represents the foreign key for VehicleModel's table
        /// </summary>s
        public int VehicleModelId { get; set; }

        /// <summary>
        /// Represents the billing or selling date for Seller's table
        /// </summary>
        public DateTime SellDate { get; set; }

        /// <summary>
        /// Represents the Seller's name
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// Represents the VehicleModel's brand
        /// </summary>
        public string VehicleBrand { get; set; }
    }
}
