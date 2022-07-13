using System;

namespace Core.Entities
{
    /// <summary>
    /// Class for <see cref="Sale"/> entity
    /// </summary>
    public sealed class Sale
    {
        /// <summary>
        /// Represents the primary key for Sale's table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the foreign key for Seller's table
        /// </summary>
        public int? SellerId { get; set; }

        /// <summary>
        /// Represents the foreign key for VehicleModel's table
        /// </summary>s
        public int? VehicleModelId { get; set; }

        /// <summary>
        /// Represents the billing or selling date for Seller's table
        /// </summary>
        public DateTime SellDate { get; set; }

        /// <summary>
        /// Represents the navigation prop for Seller's table
        /// </summary>
        public Seller Seller { get; set; }

        /// <summary>
        /// Represents the navigation prop for VehicleModel's table
        /// </summary>
        public VehicleModel VehicleModel { get; set; }
    }
}
