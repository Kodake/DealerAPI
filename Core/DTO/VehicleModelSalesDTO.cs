using Core.Entities;
using System.Collections.Generic;

namespace Core.DTO
{
    /// <summary>
    /// Class for <see cref="SellerDTO"/> dto
    /// </summary>
    public class VehicleModelSalesDTO
    {
        /// <summary>
        /// Represents the VehicleModel's brand
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Represents the VehicleModel's model
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents the VehicleModel's build year
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Represents the VehicleModel's total sales
        /// </summary>
        public int TotalSales { get; set; }

        /// <summary>
        /// Represents the navigation prop for Sale's table
        /// </summary>
        public IList<Sale> Sales { get; set; }
    }
}
