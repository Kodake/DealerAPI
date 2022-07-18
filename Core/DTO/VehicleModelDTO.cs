namespace Core.DTO
{
    /// <summary>
    /// Class for <see cref="VehicleModelDTO"/> dto
    /// </summary>
    public class VehicleModelDTO
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
    }
}
