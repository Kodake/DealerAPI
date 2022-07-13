using System;

namespace Core.DTO
{
    /// <summary>
    /// Class for <see cref="SaleDTO"/> dto
    /// </summary>
    public class SaleDTO
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
    }
}
