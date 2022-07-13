namespace Core.Entities
{
    /// <summary>
    /// Class for <see cref="VehicleModel"/> entity
    /// </summary>
    public sealed class VehicleModel
    {
        /// <summary>
        /// Represents the primary key for VehicleModel's table
        /// </summary>
        public int Id { get; set; }

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
        /// Represents the VehicleModel's tech or extra details
        /// </summary>
        public byte[] TechnicalDetails { get; set; }

        /// <summary>
        /// Represents the navigation prop for Sale's table
        /// </summary>
        public Sale Sale { get; set; }
    }
}
